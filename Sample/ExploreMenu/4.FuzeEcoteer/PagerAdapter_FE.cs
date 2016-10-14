using System;
using Android.Support.V4.App;
using Java.Lang;

namespace Sample
{
    public class PagerAdapter_FE : FragmentPagerAdapter
    {
        private string[] Titles;

        public PagerAdapter_FE(FragmentManager fm, string[] titles) : base(fm)
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
                    return new Fragment_FE_PTP();
                case 1:
                    return new Fragment_FE_EH();
                case 2:
                    return new Fragment_FE_Diving();
                case 3:
                default:
                    return new Fragment_FE_PTP();
            }
        }
    }
}