using Android.App;
using Android.OS;
using com.refractored;
using Android.Support.V4.View;
using Android.Util;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Sample
{
    [Activity(Label = "Malay Dictionary", ParentActivity = typeof(MainActivity))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "MainActivity")]
    public class activity_MalayDict : AppCompatActivity
    {
        private int count = 1;
        private PagerSlidingTabStrip tabs;
        private ViewPager pager;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_MalayDict);

            pager = FindViewById<ViewPager>(Resource.Id.pagerMD);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabsMD);
            pager.PageMargin = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.CurrentItem = 0;

            string[] titles = new string[]
            {
                "Daily",
                "Food",
                "Explore"
            };
            var adapter = new PagerAdapter_MD(SupportFragmentManager, titles);
            pager.Adapter = adapter;
            pager.OffscreenPageLimit = titles.Length;
            tabs.SetViewPager(pager);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarMD);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);

        }
    }
}