using Android.OS;
using Android.Views;
using Android.Widget;

namespace Sample
{
    public class Fragment_CW_2 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_CW_2, container, false);

            return view;
        }
    }
}