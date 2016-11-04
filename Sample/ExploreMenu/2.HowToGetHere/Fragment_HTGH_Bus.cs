using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_HTGH_Bus : Android.Support.V4.App.Fragment
    {
        private List<HTGH> items_HTGH;
        private ListView ListView_HTGH;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_HTGH_Bus, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_HTGH = Activity.FindViewById<ListView>(Resource.Id.ListView_HTGH_Bus);

            items_HTGH = new List<HTGH>();
            items_HTGH.Add(new HTGH() { Title = "Route:\nKLIA/KLIA2 -> TBS -> Kuala Besut -> Pulau Perhentian" });
            items_HTGH.Add(new HTGH() { Title = "KLIA/KLIA2 -> TBS\n\nBy Bus", Image1 = Resource.Drawable.bus_jetbus_EN, Image2 = Resource.Drawable.bus_JetbusSchedule });
            items_HTGH.Add(new HTGH() { Title = "By Train", Image1 = Resource.Drawable.train_erl_fare_2016});
            items_HTGH.Add(new HTGH() { Title = "TBS -> Kuala Besut\n\nBy Bus", Description = "Departure Time (day and night):\n09.30\n09.45\n10.00\n10.30" });
            items_HTGH.Add(new HTGH() { Title = "Kuala Besut (Jetty) -> Pulau Perhentian\n\nBy Boat", Description = "Departure Time:\n08.00 am\n12.00 pm\n04.00 pm" });
            ListViewAdapter_HTGH adapter = new ListViewAdapter_HTGH(this.Context, items_HTGH);

            ListView_HTGH.Adapter = adapter;
        }
    }
}