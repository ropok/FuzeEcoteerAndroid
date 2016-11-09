using Android.App;
using Android.OS;
using com.refractored;
using Android.Support.V4.View;
using Android.Util;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Sample
{
    [Activity(Label = "Local Wildlife", ParentActivity = typeof(MainActivity))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "MainActivity")]
    public class activity_LW : AppCompatActivity
    {
        private int count = 1;
        private PagerSlidingTabStrip tabs;
        private ViewPager pager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_LW);

            pager = FindViewById<ViewPager>(Resource.Id.pagerLW);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabsLW);
            pager.PageMargin = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.CurrentItem = 0;

            string[] titles = new string[]
            {
                "Jungle Life",
                "Marine Life",
            };
            var adapter = new PagerAdapter_LW(SupportFragmentManager, titles);
            pager.Adapter = adapter;
            pager.OffscreenPageLimit = titles.Length;
            tabs.SetViewPager(pager);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarLW);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);



        }
    }
}