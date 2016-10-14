
using Android.App;
using Android.OS;
using com.refractored;
using Android.Support.V4.View;
using Android.Util;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Sample
{
    [Activity(Label = "Marine Park Rules")]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "MainActivity")]
    public class activity_MarineParkRules : AppCompatActivity
    {
        private int count = 1;
        private PagerSlidingTabStrip tabs;
        private ViewPager pager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_MarineParkRules);

            pager = FindViewById<ViewPager>(Resource.Id.pager1);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs1);
            pager.PageMargin = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.CurrentItem = 0;

            string[] titles = new string[]
            {
                "Rules",
                "Eco Snorkel Guide",
                "Marine Life",
                "Jungle Life"
            };
            var adapter = new PagerAdapter_MPR(SupportFragmentManager, titles);
            pager.Adapter = adapter;
            pager.OffscreenPageLimit = titles.Length;
            tabs.SetViewPager(pager);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarMPR);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);
        }

    }
}