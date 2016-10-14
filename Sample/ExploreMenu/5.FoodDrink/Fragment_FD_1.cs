using Android.OS;
using Android.Views;
using Android.Widget;

namespace Sample
{
    public class Fragment_FD_1 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_FD_1, container, false);

            return view;
        }
    }
}