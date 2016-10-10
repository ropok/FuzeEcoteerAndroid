using System;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Util;
using Android.Views;
using Android.Widget;
using com.refractored;
using Java.Interop;
using Java.Lang;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;
using String = Java.Lang.String;
using Sample.Fragments;
using Android.Support.V7.Widget;
namespace Sample
{
    [Activity(Label = "Fuze Ecoteer", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity, IOnTabReselectedListener, ViewPager.IOnPageChangeListener
    {
        private MyPagerAdapter adapter;
        private int count = 1;
        private int currentColor;
        private Drawable oldBackground;
        private ViewPager pager;
        //FrameLayout beranda1_button, beranda2_button;
      //  private PagerSlidingTabStrip tabs;


        protected override int LayoutResource
        {
            get { return Resource.Layout.activity_main; }
        }

        public void OnPageScrollStateChanged(int state)
        {
            Console.WriteLine("Page scroll state changed: " + state);
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
            Console.WriteLine("Page Scrolled");
        }

        public void OnPageSelected(int position)
        {
            Console.WriteLine("Page selected: " + position);
        }

        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);

            adapter = new MyPagerAdapter(SupportFragmentManager);
            pager = FindViewById<ViewPager>(Resource.Id.pager);
            //tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            pager.Adapter = adapter;
            //tabs.SetViewPager(pager); // Menu Tab - Action bar

            var pageMargin = (int) TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.PageMargin = pageMargin;
            pager.CurrentItem = 0;
            //tabs.OnTabReselectedListener = this;
            //tabs.OnPageChangeListener = this;

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);

            ChangeColor(Resources.GetColor(Resource.Color.blue));

            #region button Initialization
            var menuT_submit = FindViewById<RelativeLayout>(Resource.Id.menu1);
            var menuT_intro = FindViewById<RelativeLayout>(Resource.Id.menu2);
            var menuT_projects = FindViewById<RelativeLayout>(Resource.Id.menu3);
            var menuT_turtleType = FindViewById<RelativeLayout>(Resource.Id.menu4);
            var menuT_teamMember = FindViewById<RelativeLayout>(Resource.Id.menu5);

            menuT_submit.Click += MenuT_submit_Click;
            menuT_intro.Click += MenuT_intro_Click;
            menuT_projects.Click += MenuT_projects_Click;
            menuT_turtleType.Click += MenuT_turtleType_Click;
            menuT_teamMember.Click += MenuT_teamMember_Click;
            #endregion

            var menuUtama = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.menu_beranda);
            menuUtama.InflateMenu(Resource.Menu.beranda);
            menuUtama.MenuItemClick += MenuUtama_MenuItemClick;

           //var trans = SupportFragmentManager.BeginTransaction();
           // trans.Add(Resource.Id.fragmentContainer, new Fragment1(), "Fragment1");
           // trans.Commit();
        }


        #region button Control
        private void MenuT_teamMember_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Team Members", ToastLength.Short).Show();
        }

        private void MenuT_turtleType_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Turtle Type", ToastLength.Short).Show();
        }

        private void MenuT_projects_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Project", ToastLength.Short).Show();
        }

        private void MenuT_intro_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Introduction", ToastLength.Short).Show();
        }

        private void MenuT_submit_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Submit", ToastLength.Short).Show();
        }
        #endregion

        void MenuUtama_MenuItemClick(object sender, Android.Support.V7.Widget.Toolbar.MenuItemClickEventArgs e)
        {
            switch (e.Item.ItemId)
            {
                case Resource.Id.beranda_turtle:
                    //StartActivity(new Intent(this, typeof(acti)));
                    break;

                case Resource.Id.beranda_map:
                    StartActivity(new Intent(this, typeof(activity3_map)));
                    break;
                    
            }
        }

        //private void beranda1_button_click(object sender, EventArgs e)
        //{
        //    var trans = SupportFragmentManager.BeginTransaction();
        //    trans.Add(Resource.Id.fragmentContainer, new Fragment1(), "Fragment1");
        //    trans.Commit();
        //}
        //private void beranda2_button_click(object sender, EventArgs e)
        //{
        //    var trans = SupportFragmentManager.BeginTransaction();
        //    trans.Add(Resource.Id.fragmentContainer, new Fragment2(), "Fragment2");
        //    trans.Commit();
        //}

        private void ChangeColor(Color newColor)
        {
            //tabs.SetBackgroundColor(newColor);

            // change ActionBar color just if an ActionBar is available
            Drawable colorDrawable = new ColorDrawable(newColor);
            Drawable bottomDrawable = new ColorDrawable(Resources.GetColor(Android.Resource.Color.Transparent));
            var ld = new LayerDrawable(new[] { colorDrawable, bottomDrawable });
            if (oldBackground == null)
            {
                SupportActionBar.SetBackgroundDrawable(ld);
            }
            else
            {
                var td = new TransitionDrawable(new[] { oldBackground, ld });
                SupportActionBar.SetBackgroundDrawable(td);
                td.StartTransition(200);
            }

            oldBackground = ld;
            currentColor = newColor;
        }
        
        //[Export("onColorClicked")]
        //public void OnColorClicked(View v)
        //{
        //    var color = Color.ParseColor(v.Tag.ToString());
        //    ChangeColor(color);
        //}


        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            outState.PutInt("currentColor", currentColor);
        }

        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);
            currentColor = savedInstanceState.GetInt("currentColor");
            //ChangeColor(new Color(currentColor));
        }

        #region IOnTabReselectedListener implementation

        public void OnTabReselected(int position)
        {
            Toast.MakeText(this, "Tab reselected: " + position, ToastLength.Short).Show();
        }

        #endregion

        #region menu

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            var inflater = MenuInflater;
            inflater.Inflate(Resource.Menu.main, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            // Handle presses on the action bar items
            switch (item.ItemId)
            {

                case Resource.Id.beranda_map:

                    var intent = new Intent(this, typeof(activity3_map));
                    StartActivity(intent);
                    return true;


                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

        #endregion

        //private void CreateTab(Type activityType, string tag, string label, int dtawableId)
        //{
        //    var intent = new Intent(this, activityType);
        //    intent.AddFlags(ActivityFlags.NewTask);

        //    var spec = TabHost.NewTabSpec(tag);
        //    var drawbleIcon = Resource.GetDrawable(drawableId);
        //    spec.SetIndicator(label, drawbleIcon);
        //    spec.SetContent(intent);

        //    TabHost.AddTab(spec);
        //}
    }

    public class MyPagerAdapter : FragmentPagerAdapter
    {
        private readonly string[] Titles =
        {
                "Turtle Project", "Report", "Map", "Explore"
        };

        public MyPagerAdapter(FragmentManager fm) : base(fm)
        {
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new String(Titles[position]);
        }

        #region implemented abstract members of PagerAdapter

        public override int Count
        {
            get { return Titles.Length; }
        }

        #endregion

        #region implemented abstract members of FragmentPagerAdapter

        public override Fragment GetItem(int position)
        {
            return SuperAwesomeCardFragment.NewInstance(position);
        }

        #endregion
    }


}