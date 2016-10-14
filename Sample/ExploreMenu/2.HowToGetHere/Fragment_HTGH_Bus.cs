using Android.OS;
using Android.Views;
using Android.Widget;

namespace Sample
{
    public class Fragment_HTGH_Bus : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_HTGH_Bus, container, false);

            return view;
        }

    }
}