using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MD_4 : Android.Support.V4.App.Fragment
    {
        private List<MD> items_MD;
        private ListView ListView_MD;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MD_4, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_MD = Activity.FindViewById<ListView>(Resource.Id.ListView_MD4);

            items_MD = new List<MD>();

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Common signs" });
            items_MD.Add(new MD() { English = "Open", Malay = "Buka", Say = "" });
            items_MD.Add(new MD() { English = "Closed", Malay = "Tutup", Say = "" });
            items_MD.Add(new MD() { English = "Entrance", Malay = "Masuk", Say = "" });
            items_MD.Add(new MD() { English = "Exit", Malay = "Keluar", Say = "" });
            items_MD.Add(new MD() { English = "Push", Malay = "Tolak", Say = "" });
            items_MD.Add(new MD() { English = "TARIK", Malay = "Pull", Say = "" });
            items_MD.Add(new MD() { English = "Toilet", Malay = "Tandas", Say = "" });
            items_MD.Add(new MD() { English = "Men", Malay = "Lelaki", Say = "" });
            items_MD.Add(new MD() { English = "Women", Malay = "Wanita", Say = "" });
            items_MD.Add(new MD() { English = "No Entry", Malay = "Dilarang Masuk", Say = "" });

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Tak nak?" });
            items_MD.Add(new MD() { English = "already", Malay = "sudah->dah", Say = "" });
            items_MD.Add(new MD() { English = "no", Malay = "tidak->tak", Say = "" });
            items_MD.Add(new MD() { English = "to want", Malay = "hendak->nak", Say = "" });
            items_MD.Add(new MD() { English = "I", Malay = "aku->ku", Say = "" });
            items_MD.Add(new MD() { English = "you", Malay = "kamu->mu", Say = "" });
            items_MD.Add(new MD() { English = "you", Malay = "engkau->kau", Say = "" });

            ListViewAdapter_MD adapter = new ListViewAdapter_MD(this.Context, items_MD);

            ListView_MD.Adapter = adapter;
        }
    }
}