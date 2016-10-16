using Android.App;
using Android.OS;
using com.refractored;
using Android.Support.V4.View;
using Android.Util;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Sample
{
    [Activity(Label = "Fuze Ecoteer Projects", ParentActivity = typeof(MainActivity))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "MainActivity")]
    public class activity_FuzeEcoteer : AppCompatActivity
    {
        private int count = 1;
        private PagerSlidingTabStrip tabs;
        private ViewPager pager;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_FuzeEcoteer);

            pager = FindViewById<ViewPager>(Resource.Id.pagerFE);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabsFE);
            pager.PageMargin = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.CurrentItem = 0;

            string[] titles = new string[]
            {
                "Perhentian Turtle Project",
                "Ecoteer House",
                "Diving"
            };
            var adapter = new PagerAdapter_FE(SupportFragmentManager, titles);
            pager.Adapter = adapter;
            pager.OffscreenPageLimit = titles.Length;
            tabs.SetViewPager(pager);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarFE);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
        }
    }
}