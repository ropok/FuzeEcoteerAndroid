using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_CW_2 : Android.Support.V4.App.Fragment
    {
        private List<FD> items_CW;
        private ListView ListView_CW;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_CW_2, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_CW = Activity.FindViewById<ListView>(Resource.Id.ListView_CW2);

            items_CW = new List<FD>();

            items_CW.Add(new FD()
            {
                Title = "Date",
                Description = "\n25 June 2014",
                manyMore = "Day-Month-Year"
            });

            items_CW.Add(new FD()
            {
                Title = "Start time of survey",
                Description = "\nTo the nearest quarter",
                manyMore = "e.g. 16:00, 16:15, 16:30 or 16:45"
            });

            items_CW.Add(new FD()
            {
                Title = "Temperature",
                Description = "\nIn degree celcius",
                manyMore = "�C"
            });

            items_CW.Add(new FD()
            {
                Title = "Max depth",
                Description = "\nIn meter",
                manyMore = "m"
            });

            items_CW.Add(new FD()
            {
                Title = "Location",
                Description = "\nCheck with boatman if you are not sure",
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_CW);

            ListView_CW.Adapter = adapter;
            

        }
    }
}