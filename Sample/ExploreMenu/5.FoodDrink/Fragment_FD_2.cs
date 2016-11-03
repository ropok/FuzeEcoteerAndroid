using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_FD_2 : Android.Support.V4.App.Fragment
    {
        private List<FD> items_FD;
        private ListView ListView_FD;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_FD_2, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_FD = Activity.FindViewById<ListView>(Resource.Id.ListView_FD2);

            items_FD = new List<FD>();


            items_FD.Add(new FD() { Image = Resource.Drawable.RotiCanai, Title = "Roti Canai", Description = "Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap Make Pagi sangat sedap" });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_FD);

            ListView_FD.Adapter = adapter;
        }
    }
}