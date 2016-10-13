using System;
using Android.Support.V4.App;
using Java.Lang;
using Sample.ExploreMenu.MarineParkRules;

namespace Sample
{
    public class PagerAdapter_MPR : FragmentPagerAdapter
    {
        private string[] Titles;
        
        public PagerAdapter_MPR(FragmentManager fm, string[] titles) : base(fm)
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
                    return new Fragment_MPR_Rules();
                case 1:
                    return new Fragment_MPR_Eco();
                case 2:
                    return new Fragment_MPR_MarineLife();
                case 3:
                    return new Fragment_MPR_JungleLife();
                case 4:
                default:
                    return new Fragment_MPR_Rules();
            }
        }
    }
}