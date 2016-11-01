using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MD_1 : Android.Support.V4.App.Fragment
    {
        private List<MD> items_MD1;
        private ListView ListView_MD1;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MD_1, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_MD1 = Activity.FindViewById<ListView>(Resource.Id.ListView_MD1);

            items_MD1 = new List<MD>();

            items_MD1.Add(new MD() { English = "Good Morning", Malay = "Selamat Pagi", Say = "/se-la-mat pa-gee/" });
            items_MD1.Add(new MD() { English = "Good Morning", Malay = "Selamat Pagi", Say = "/se-la-mat pa-gee/" });
            items_MD1.Add(new MD() { English = "Good Morning", Malay = "Selamat Pagi", Say = "/se-la-mat pa-gee/" });
            items_MD1.Add(new MD() { English = "Good Morning", Malay = "Selamat Pagi", Say = "/se-la-mat pa-gee/" });
            items_MD1.Add(new MD() { English = "Good Morning", Malay = "Selamat Pagi", Say = "/se-la-mat pa-gee/" });

            ListViewAdapter_MD adapter = new ListViewAdapter_MD(this.Context, items_MD1);

            ListView_MD1.Adapter = adapter;
        }
    }
}