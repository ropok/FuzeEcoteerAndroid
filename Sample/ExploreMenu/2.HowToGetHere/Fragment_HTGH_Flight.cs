using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_HTGH_Flight : Android.Support.V4.App.Fragment
    {
        private List<HTGH> items_HTGH;
        private ListView ListView_HTGH;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_HTGH_Flight, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_HTGH = Activity.FindViewById<ListView>(Resource.Id.ListView_HTGH_Flight);

            items_HTGH = new List<HTGH>();
            items_HTGH.Add(new HTGH() { Title = "Route:\nKLIA/KLIA2 -> Sultan Ismail Petra Airport (Kota Bharu) -> Kuala Besut (jetty) -> Pulau Perhentian" });
            items_HTGH.Add(new HTGH() { Title = "KLIA/KLIA2 -> Sultan Ismail Petra Airport (Kota Bharu)\n\nBy Plane", Time = "\nestimated : 1 hour 5 minutes" });
            items_HTGH.Add(new HTGH() { Title = "Sultan Ismail Petra Airport (Kota Bharu) -> Kuala Besut (jetty)\n\nBy Taxi", Time = "\nestimated : 1 hour" });
            items_HTGH.Add(new HTGH() { Title = "Kuala Besut (jetty) -> Pulau Perhentian\n\nBy Boat", Description = "Departure Time:\n08.00 am\n12.00 pm\n04.00 pm", Time = "\nestimated : 1 hour" });
            ListViewAdapter_HTGH adapter = new ListViewAdapter_HTGH(this.Context, items_HTGH);

            ListView_HTGH.Adapter = adapter;
        }
    }
}