using Android.OS;
using Android.Views;

namespace Sample
{
    public class Fragment_MPR_JungleLife : Android.Support.V4.App.Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.Fragment_MPR_JungleLife, null);

            return view;
        }
    }
}