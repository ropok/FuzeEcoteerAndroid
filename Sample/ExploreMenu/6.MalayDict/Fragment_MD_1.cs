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

            items_MD1.Add(new MD() { English = "", Malay = "", Say = "Greetings" });
            items_MD1.Add(new MD() { English = "Good Morning", Malay = "Selamat Pagi", Say = "(SLAH-maht PAH-gee)" });
            items_MD1.Add(new MD() { English = "Good Afternoon", Malay = "Selamat Tengah hari", Say = "(SLAH-maht teng-ah-HAH-ree)" });
            items_MD1.Add(new MD() { English = "Good Evening", Malay = "Selamat Petang", Say = "(SLAH-maht puh-TAHNG)" });
            items_MD1.Add(new MD() { English = "Good Night", Malay = "Selamat Malam", Say = "(SLAH-maht MAH-lam)" });
            items_MD1.Add(new MD() { English = "How Are You?", Malay = "Apa Khabar?", Say = "(AH-puh KAH-bar?)" });
            items_MD1.Add(new MD() { English = "Fine", Malay = "Khabar baik", Say = "(KAH-bar BAEE)" });
            items_MD1.Add(new MD() { English = "What is your name?", Malay = "Siapa nama awak?", Say = "(SAH-puh NAH-muh AH-wah)" });
            items_MD1.Add(new MD() { English = "My name is __", Malay = "Nama saya __", Say = "(NAH-muh SAH-yuh __)" });
            items_MD1.Add(new MD() { English = "Please", Malay = "Sila", Say = "(SEE-luh)" });
            items_MD1.Add(new MD() { English = "Please (Request)", Malay = "Tolong", Say = "(TOH-long)" });
            items_MD1.Add(new MD() { English = "Thank you", Malay = "Terima Kasih", Say = "(TREE-muh KAH-seh)" });
            items_MD1.Add(new MD() { English = "You're welcome", Malay = "Sama sama", Say = "(SAH-muh SAH-muh)" });
            items_MD1.Add(new MD() { English = "Yes", Malay = "Ya", Say = "(YUH)" });
            items_MD1.Add(new MD() { English = "No", Malay = "Tidak / Tak", Say = "(TEE-dah) / (TAH)" });
            items_MD1.Add(new MD() { English = "Maybe", Malay = "Boleh jadi", Say = "(BO-leh JAH-dee)" });
            items_MD1.Add(new MD() { English = "Excuse Me", Malay = "Maaf", Say = "(mah'AHF)" });
            items_MD1.Add(new MD() { English = "I'm sorry", Malay = "Maafkan saya", Say = "(mah'AHF-kahn SAH-yuh)" });
            items_MD1.Add(new MD() { English = "Goodbye", Malay = "Selamat tinggal", Say = "(SLAH-maht tin-GAHL)" });
            items_MD1.Add(new MD() { English = "Safe trip", Malay = "Selamat jalan", Say = "(SLAH-maht JAH-lahn)" });

            items_MD1.Add(new MD() { English = "", Malay = "", Say = "Days" });
            items_MD1.Add(new MD() { English = "Monday", Malay = "Isnin", Say = "(EES-neen)" });
            items_MD1.Add(new MD() { English = "Tuesday", Malay = "Selasa", Say = "(SLAH-suh)" });
            items_MD1.Add(new MD() { English = "Wednesday", Malay = "Rabu", Say = "(RAH-boo)" });
            items_MD1.Add(new MD() { English = "Thursday", Malay = "Khamis", Say = "(KHAM-mees)" });
            items_MD1.Add(new MD() { English = "Friday", Malay = "Jumaat", Say = "(joom-MAH-aht)" });
            items_MD1.Add(new MD() { English = "Saturday", Malay = "Sabtu", Say = "(SAHB-too)" });
            items_MD1.Add(new MD() { English = "Sunday", Malay = "Ahad", Say = "(AH-hahd)" });
            items_MD1.Add(new MD() { English = "Tomorrow", Malay = "Esok", Say = "(Bay-SOH)" });
            items_MD1.Add(new MD() { English = "Yesterday", Malay = "Kelmarin", Say = "(kuh-MAR-reen)" });

            items_MD1.Add(new MD() { English = "", Malay = "", Say = "Numbers" });
            items_MD1.Add(new MD() { English = "Number", Malay = "Nombor", Say = "" });
            items_MD1.Add(new MD() { English = "Zero (0)", Malay = "Sifar / kosong", Say = "" });
            items_MD1.Add(new MD() { English = "One (1)", Malay = "Satu", Say = "" });
            items_MD1.Add(new MD() { English = "Two (2)", Malay = "Dua", Say = "" });
            items_MD1.Add(new MD() { English = "Three (3)", Malay = "Tiga", Say = "" });
            items_MD1.Add(new MD() { English = "Four (4)", Malay = "Empat", Say = "" });
            items_MD1.Add(new MD() { English = "Five (5)", Malay = "Lima", Say = "" });
            items_MD1.Add(new MD() { English = "Six (6)", Malay = "Enam", Say = "" });
            items_MD1.Add(new MD() { English = "Seven (7)", Malay = "Tujuh", Say = "" });
            items_MD1.Add(new MD() { English = "Eight (8)", Malay = "Lapan", Say = "" });
            items_MD1.Add(new MD() { English = "Nine (9)", Malay = "Sembilan", Say = "" });
            items_MD1.Add(new MD() { English = "Ten (10)", Malay = "Sepuluh", Say = "" });
            items_MD1.Add(new MD() { English = "Eleven (11)", Malay = "Sebelas", Say = "" });
            items_MD1.Add(new MD() { English = "Twelve (12)", Malay = "Dua belas", Say = "" });
            items_MD1.Add(new MD() { English = "Thirteen (13)", Malay = "Tiga belas", Say = "" });
            items_MD1.Add(new MD() { English = "Twenty (20)", Malay = "Dua puluh", Say = "" });
            items_MD1.Add(new MD() { English = "Thirty (30)", Malay = "Tiga puluh", Say = "" });
            items_MD1.Add(new MD() { English = "Thirty One (31)", Malay = "Tiga puluh Satu", Say = "" });
            items_MD1.Add(new MD() { English = "One Hundred (100)", Malay = "Seratus", Say = "" });
            items_MD1.Add(new MD() { English = "One Thousand (1000)", Malay = "Seribu", Say = "" });
            items_MD1.Add(new MD() { English = "Half", Malay = "Setengah", Say = "(SUH-tung-ah)" });
            items_MD1.Add(new MD() { English = "Quarter ", Malay = "Suku", Say = "(SOO-koo)" });
            items_MD1.Add(new MD() { English = "Three quarter ", Malay = "Tiga suku", Say = "(TEE-gah SOO-koo)" });
            items_MD1.Add(new MD() { English = "Less ", Malay = "Kurang ", Say = "(KOO-rahng)" });
            items_MD1.Add(new MD() { English = "More ", Malay = "Lebih  ", Say = "(LUH-bay)" });
            items_MD1.Add(new MD() { English = "Roughly (more or less) ", Malay = "Lebih kurang  ", Say = "(LUH-bay KOO-rahng)" });

            items_MD1.Add(new MD() { English = "", Malay = "", Say = "Time" });
            items_MD1.Add(new MD() { English = "What time is it?", Malay = "Pukul berapa sekarang?", Say = "" });
            items_MD1.Add(new MD() { English = "now", Malay = "sekarang", Say = "(suh-KAH-rahng)" });
            items_MD1.Add(new MD() { English = "later", Malay = "nanti", Say = "(NAN-tee)" });
            items_MD1.Add(new MD() { English = "before", Malay = "sebelum", Say = "(suh-BUH-lom)" });
            items_MD1.Add(new MD() { English = "after", Malay = "selepas", Say = "(suh-LUH-pas)" });
            items_MD1.Add(new MD() { English = "morning", Malay = "pagi", Say = "PAH-gee" });
            items_MD1.Add(new MD() { English = "afternoon", Malay = "tengah hari (10.30 – 15.00)", Say = "(TUH-ngah HA-ree)" });
            items_MD1.Add(new MD() { English = "evening", Malay = "petang (15.00 – 19.00)", Say = "(PUH-tahng)" });
            items_MD1.Add(new MD() { English = "night", Malay = "malam (19.00 – 00.00)", Say = "(MAH-lahm)" });
            items_MD1.Add(new MD() { English = "", Malay = "", Say = "" });
            items_MD1.Add(new MD() { English = "", Malay = "", Say = "" });
            items_MD1.Add(new MD() { English = "", Malay = "", Say = "" });
            items_MD1.Add(new MD() { English = "", Malay = "", Say = "" });


            items_MD1.Add(new MD() { English = "", Malay = "", Say = "Dates" });
            items_MD1.Add(new MD() { English = "Dates", Malay = "Tarikh", Say = "" });

            ListViewAdapter_MD adapter = new ListViewAdapter_MD(this.Context, items_MD1);

            ListView_MD1.Adapter = adapter;
        }
    }
}