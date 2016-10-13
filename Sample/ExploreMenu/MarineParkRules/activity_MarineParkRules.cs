using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using com.refractored;
using Java.Interop;
using Java.Lang;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;
using String = Java.Lang.String;
using Android.Support.V4.View;
using Android.Util;
using Android.Support.V4.App;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace Sample
{
    [Activity(Label = "Marine Park Rules")]
    public class activity_MarineParkRules : BaseActivity, IOnTabReselectedListener, ViewPager.IOnPageChangeListener
    {
        private MyPagerAdapter adapter;
        private int count = 1;
        private ViewPager pager;
        private int currentColor;
        private PagerSlidingTabStrip tabs;
        private Drawable oldBackground;

        protected override int LayoutResource
        {
            get
            {
                return Resource.Layout.activity_MarineParkRules;
            }
        }

        public void OnPageScrollStateChanged(int state)
        {
            Console.WriteLine("Page scroll state changed:: " + state);
        }

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
            Console.WriteLine("Page Scrolled");
        }

        public void OnPageSelected(int position)
        {
            Console.WriteLine("Page Selected:: " + position);
        }
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            adapter = new MyPagerAdapter(SupportFragmentManager);
            pager = FindViewById<ViewPager>(Resource.Id.pager1);
            tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs1);
            pager.Adapter = adapter;
            tabs.SetViewPager(pager);

            var pageMargin = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Resources.DisplayMetrics);
            pager.PageMargin = pageMargin;
            pager.CurrentItem = 0;
            tabs.OnTabReselectedListener = this;
            tabs.OnPageChangeListener = this;

            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            ChangeColor(Resources.GetColor(Resource.Color.blue));
        }
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
        #region IOnTabReselectedListener implementation
        public void OnTabReselected(int position)
        {
            Toast.MakeText(this, "Tab reselected: " + position, ToastLength.Short).Show();
        }
        #endregion

        public class MyPagerAdapter : FragmentPagerAdapter
        {
            private readonly string[] Titles =
            {
                "Rules", "Eco Snorkel Guide", "Marine Life", "Jungle life"
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
                get
                {
                    return Titles.Length;
                }
            }
            #endregion

            #region implemented abstract members of FragmentPagerAdapter
            public override Fragment GetItem(int position)
            {
                return Fragment_MarineParkRules.NewInstance(position);
            }
            #endregion
        }
    }
}