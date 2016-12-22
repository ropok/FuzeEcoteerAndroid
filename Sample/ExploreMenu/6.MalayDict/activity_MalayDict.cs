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
using Java.Lang;

namespace Sample
{
    [Activity(Label = "Malay Dictionary", ParentActivity = typeof(activity_FuzeEcoteer))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "activity_FuzeEcoteer")]
    public class activity_MalayDict : AppCompatActivity
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

        public class MyIconPagerAdapter : FragmentPagerAdapter
        {
            private readonly string[] titles =
         {
            "Daily",
            "Food",
            "Travel",
            "Basic Words",
            "Emergency"
         };

            public MyIconPagerAdapter (FragmentManager fm) : base(fm) { }
            public override ICharSequence GetPageTitleFormatted(int position)
            {
                return new Java.Lang.String(titles[position]);
            }
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
                        return new Fragment_MD_4();
                    case 4:
                        return new Fragment_MD_5();
                    case 5:
                    default:
                        return new Fragment_MD_1();
                }
            }
        }

    }
}