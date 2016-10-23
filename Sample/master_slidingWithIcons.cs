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

namespace Sample
{
    [Activity(Label = "Malay Dictionary", ParentActivity = typeof(MainActivity))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "MainActivity")]
    public class master_slidingWithIcons : AppCompatActivity
    {
        private int count = 1;
        private PagerSlidingTabStrip tabs;
        private ViewPager pager;
        private MyIconPagerAdapter adapter;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_MalayDict);

            pager = FindViewById<ViewPager>(Resource.Id.pagerMD);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabsMD);
            pager.PageMargin = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.CurrentItem = 0;


            //var adapter = new PagerAdapter_MD(SupportFragmentManager, titles);
            adapter = new MyIconPagerAdapter(SupportFragmentManager);
            pager.Adapter = adapter;
            //pager.OffscreenPageLimit = titles.Length;
            tabs.SetViewPager(pager);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarMD);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);

        }

        public class MyIconPagerAdapter : FragmentStatePagerAdapter, ICustomTabProvider
        {
            private readonly int[] titles =
         {
            Resource.Drawable.ic_home_white_48dp,
            Resource.Drawable.ic_people_white_48dp, Resource.Drawable.ic_attach_money_white_48dp
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
                        return new Fragment_MD_1();
                    case 1:
                        return new Fragment_MD_2();
                    case 2:
                        return new Fragment_MD_3();
                    case 3:
                    default:
                        return new Fragment_FD_1();
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

    }
}