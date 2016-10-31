using Android.App;
using Android.OS;
using com.refractored;
using Android.Support.V4.View;
using Android.Util;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using System;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Content;

namespace Sample
{
    [Activity(Label = "Fuze Ecoteer", Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        private int count = 1;
        private int currentColor;
        private Drawable oldBackground;
        private RelativeLayout TurtleProjectMenu, ExplorePerhentianMenu;
        private PagerSlidingTabStrip tabs;
        private ViewPager pager;
        private MyIconPagerAdapter adapter;

        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_mainMenu);

            pager = FindViewById<ViewPager>(Resource.Id.pagerMainMenu);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabsMainMenu);
            pager.PageMargin = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.CurrentItem = 0;
                        
            adapter = new MyIconPagerAdapter(SupportFragmentManager);
            pager.Adapter = adapter;
            tabs.SetViewPager(pager);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarMainMenu);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(false);
            ChangeColor(Resources.GetColor(Resource.Color.blue));
        }
        public class MyIconPagerAdapter : FragmentStatePagerAdapter, ICustomTabProvider
        {
            private readonly int[] titles =
         {
            Resource.Drawable.ic_home_white_48dp,
            Resource.Drawable.ic_map_white_48dp,
            Resource.Drawable.ic_explore_white_48dp
         };

            public MyIconPagerAdapter(FragmentManager fm) : base(fm) { }

            public override int Count
            {
                get { return titles.Length; }
            }


            public override Fragment GetItem(int position)
            {
                switch (position)
                {
                    case 0:
                        return new Fragment_MM_Home();
                    case 1:
                        return new Fragment_MM_Map();
                    case 2:
                        return new Fragment_MM_Explore();
                    case 3:
                    default:
                        return new Fragment_MM_Home();
                }
            }

            public View GetCustomTabView(ViewGroup parent, int position)
            {
                var tablayout =
                    (LinearLayout)
                        LayoutInflater.From(Application.Context).Inflate(Resource.Layout.tab_layout, parent, false);

                var tabImage = tablayout.FindViewById<ImageView>(Resource.Id.tabImage);

                tabImage.SetImageResource(titles[position]);

                return tablayout;
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            var inflater = MenuInflater;
            inflater.Inflate(Resource.Menu.main, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        #region colour
        private void ChangeColor(Color newColor)
        {
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


        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            outState.PutInt("currentColor", currentColor);
        }

        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);
            currentColor = savedInstanceState.GetInt("currentColor");
        }
        #endregion


    }


}