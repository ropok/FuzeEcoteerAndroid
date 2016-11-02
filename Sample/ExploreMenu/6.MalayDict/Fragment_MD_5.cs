using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MD_5 : Android.Support.V4.App.Fragment
    {
        private List<MD> items_MD;
        private ListView ListView_MD;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MD_5, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_MD = Activity.FindViewById<ListView>(Resource.Id.ListView_MD5);

            items_MD = new List<MD>();

            items_MD.Add(new MD() { English = "Police!", Malay = "Polis!", Say = "(po-LIS)" });
            items_MD.Add(new MD() { English = "Help!", Malay = "Tolong!", Say = "(TOH-long)" });
            items_MD.Add(new MD() { English = "Stop! Thief!", Malay = "Berhenti! Pencuri!", Say = "(ber-HEN-ti! pen-CHU-ri!)" });
            items_MD.Add(new MD() { English = "Please help me", Malay = "Sila tolonglah saya", Say = "(si-LUH toh-lohng-lah SAH-yuh)" });
            items_MD.Add(new MD() { English = "It's an emergency", Malay = "Ini kecemasan", Say = "(i-NEE ke-CHE-mas-an)" });
            items_MD.Add(new MD() { English = "I'm lost", Malay = "Saya tersesat", Say = "(SAH-yuh TUH-say-saht)" });
            items_MD.Add(new MD() { English = "I lost my bag", Malay = "Saya hilang beg saya", Say = "(SAH-yuh HEE-lang behg SAH-yuh)" });
            items_MD.Add(new MD() { English = "I lost my wallet", Malay = "Saya hilang dompet saya", Say = "(SAH-yuh HEE-lang DOM-pet SAH-yuh)" });
            items_MD.Add(new MD() { English = "I'm sick", Malay = "Saya sakit", Say = "(SAH-yuh SAH-keet)" });
            items_MD.Add(new MD() { English = "I feel dizzy", Malay = "Saya rasa pening kepala", Say = "(SAH-yuh RAH-suh PUH-ning ke-PAH-lah)" });
            items_MD.Add(new MD() { English = "I've been injured", Malay = "Saya terluka", Say = "(SAH-yuh ter-LOO-kah)" });
            items_MD.Add(new MD() { English = "I'm bleeding", Malay = "Saya berdarah", Say = "(SAH-yuh ber-DAH-rah)" });
            items_MD.Add(new MD() { English = "I need a doctor", Malay = "Saya perlu doktor", Say = "(SAH-yuh per-LOO DOHK-tor)" });
            items_MD.Add(new MD() { English = "Can I use your phone?", Malay = "Bolehkah saya guna telefon awak?", Say = "(BO-leh-kah SAH-yuh GOO-nuh TE-le-phone AH-wah?)" });

            ListViewAdapter_MD adapter = new ListViewAdapter_MD(this.Context, items_MD);

            ListView_MD.Adapter = adapter;
        }
    }
}