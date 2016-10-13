using Android.OS;
using Android.Views;

namespace Sample.ExploreMenu.MarineParkRules
{
    public class Fragment_MPR_Rules : Android.Support.V4.App.Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.Fragment_MPR_Rules, null);

            return view;
        }
    }
}