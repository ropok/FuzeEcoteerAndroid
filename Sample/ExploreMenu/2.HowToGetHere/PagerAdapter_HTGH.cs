using System;
using Android.Support.V4.App;
using Java.Lang;

namespace Sample
{
    public class PagerAdapter_HTGH : FragmentPagerAdapter
    {
        private string[] Titles;

        public PagerAdapter_HTGH(FragmentManager fm, string[] titles) : base(fm)
        {
            Titles = titles;
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(Titles[position]);
        }

        public override int Count
        {
            get
            {
                return Titles.Length;
            }
        }
        public override Fragment GetItem(int position)
        {
            switch (position)
            {
                case 0:
                    return new Fragment_HTGH_Bus();
                case 1:
                    return new Fragment_HTGH_Flight();
                case 2:
                    return new Fragment_HTGH_Train();
                case 3:
                    return new Fragment_HTGH_Other();
                case 4:
                default:
                    return new Fragment_HTGH_Bus();
            }
        }

    }
}