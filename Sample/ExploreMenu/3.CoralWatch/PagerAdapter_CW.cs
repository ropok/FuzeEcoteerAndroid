using System;
using Android.Support.V4.App;
using Java.Lang;

namespace Sample
{
    public class PagerAdapter_CW : FragmentPagerAdapter
    {
        private string[] Titles;

        public PagerAdapter_CW(FragmentManager fm, string[] titles) : base(fm)
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
                    return new Fragment_CW_1();
                case 1:
                    return new Fragment_CW_2();
                case 2:
                    return new Fragment_CW_3();
                case 3:
                    return new Fragment_CW_4();
                case 4:
                default:
                    return new Fragment_CW_1();
            }
        }
    }
}