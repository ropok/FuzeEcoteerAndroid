using Android.OS;
using Android.Views;
using Android.Widget;

namespace Sample.ExploreMenu.MarineParkRules
{
    public class Fragment_MPR_Rules : Android.Support.V4.App.Fragment
    {
        //public override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    // Create your fragment here
        //}
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MPR_Rules, container, false);

            return view;
        }
    }
}