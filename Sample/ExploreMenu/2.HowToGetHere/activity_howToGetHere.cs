using Android.App;
using Android.OS;
using com.refractored;
using Android.Support.V4.View;
using Android.Util;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Sample
{
    [Activity(Label = "How to Get Here", ParentActivity = typeof(MainActivity))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "MainActivity")]
    public class activity_howToGetHere : AppCompatActivity
    {
        private int count = 1;
        private PagerSlidingTabStrip tabs;
        private ViewPager pager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_howToGetHere);

            pager = FindViewById<ViewPager>(Resource.Id.pagerHTGH);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabsHTGH);
            pager.PageMargin = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.CurrentItem = 0;

            string[] titles = new string[]
            {
                "Bus",
                "Flight",
                "Train",
                "Others"
            };
            var adapter = new PagerAdapter_HTGH(SupportFragmentManager, titles);
            pager.Adapter = adapter;
            pager.OffscreenPageLimit = titles.Length;
            tabs.SetViewPager(pager);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarHTGH);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);



        }
    }
}