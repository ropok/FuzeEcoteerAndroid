using System;
using Android.Support.V4.App;
using Java.Lang;

namespace Sample
{
    public class PagerAdapter_LW : FragmentPagerAdapter
    {
        private string[] Titles;

        public PagerAdapter_LW(FragmentManager fm, string[] titles) : base(fm)
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
                    return new Fragment_LW_JungleLife();
                case 1:
                    return new Fragment_LW_MarineLife();
                case 2:
                default:
                    return new Fragment_LW_JungleLife();
            }
        }

    }
}