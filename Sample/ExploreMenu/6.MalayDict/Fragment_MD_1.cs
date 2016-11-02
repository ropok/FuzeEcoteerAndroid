using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MD_1 : Android.Support.V4.App.Fragment
    {
        private List<MD> items_MD;
        private ListView ListView_MD;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MD_1, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_MD = Activity.FindViewById<ListView>(Resource.Id.ListView_MD1);

            items_MD = new List<MD>();

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Greetings" });
            items_MD.Add(new MD() { English = "Good Morning", Malay = "Selamat Pagi", Say = "(SLAH-maht PAH-gee)" });
            items_MD.Add(new MD() { English = "Good Afternoon", Malay = "Selamat Tengah hari", Say = "(SLAH-maht teng-ah-HAH-ree)" });
            items_MD.Add(new MD() { English = "Good Evening", Malay = "Selamat Petang", Say = "(SLAH-maht puh-TAHNG)" });
            items_MD.Add(new MD() { English = "Good Night", Malay = "Selamat Malam", Say = "(SLAH-maht MAH-lam)" });
            items_MD.Add(new MD() { English = "How Are You?", Malay = "Apa Khabar?", Say = "(AH-puh KAH-bar?)" });
            items_MD.Add(new MD() { English = "Fine", Malay = "Khabar baik", Say = "(KAH-bar BAEE)" });
            items_MD.Add(new MD() { English = "What is your name?", Malay = "Siapa nama awak?", Say = "(SAH-puh NAH-muh AH-wah)" });
            items_MD.Add(new MD() { English = "My name is __", Malay = "Nama saya __", Say = "(NAH-muh SAH-yuh __)" });
            items_MD.Add(new MD() { English = "Please", Malay = "Sila", Say = "(SEE-luh)" });
            items_MD.Add(new MD() { English = "Please (Request)", Malay = "Tolong", Say = "(TOH-long)" });
            items_MD.Add(new MD() { English = "Thank you", Malay = "Terima Kasih", Say = "(TREE-muh KAH-seh)" });
            items_MD.Add(new MD() { English = "You're welcome", Malay = "Sama sama", Say = "(SAH-muh SAH-muh)" });
            items_MD.Add(new MD() { English = "Yes", Malay = "Ya", Say = "(YUH)" });
            items_MD.Add(new MD() { English = "No", Malay = "Tidak / Tak", Say = "(TEE-dah) / (TAH)" });
            items_MD.Add(new MD() { English = "Maybe", Malay = "Boleh jadi", Say = "(BO-leh JAH-dee)" });
            items_MD.Add(new MD() { English = "Excuse Me", Malay = "Maaf", Say = "(mah'AHF)" });
            items_MD.Add(new MD() { English = "I'm sorry", Malay = "Maafkan saya", Say = "(mah'AHF-kahn SAH-yuh)" });
            items_MD.Add(new MD() { English = "Goodbye", Malay = "Selamat tinggal", Say = "(SLAH-maht tin-GAHL)" });
            items_MD.Add(new MD() { English = "Safe trip", Malay = "Selamat jalan", Say = "(SLAH-maht JAH-lahn)" });

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Days" });
            items_MD.Add(new MD() { English = "Monday", Malay = "Isnin", Say = "(EES-neen)" });
            items_MD.Add(new MD() { English = "Tuesday", Malay = "Selasa", Say = "(SLAH-suh)" });
            items_MD.Add(new MD() { English = "Wednesday", Malay = "Rabu", Say = "(RAH-boo)" });
            items_MD.Add(new MD() { English = "Thursday", Malay = "Khamis", Say = "(KHAM-mees)" });
            items_MD.Add(new MD() { English = "Friday", Malay = "Jumaat", Say = "(joom-MAH-aht)" });
            items_MD.Add(new MD() { English = "Saturday", Malay = "Sabtu", Say = "(SAHB-too)" });
            items_MD.Add(new MD() { English = "Sunday", Malay = "Ahad", Say = "(AH-hahd)" });
            items_MD.Add(new MD() { English = "Tomorrow", Malay = "Esok", Say = "(Bay-SOH)" });
            items_MD.Add(new MD() { English = "Yesterday", Malay = "Kelmarin", Say = "(kuh-MAR-reen)" });

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Numbers" });
            items_MD.Add(new MD() { English = "Number", Malay = "Nombor", Say = "" });
            items_MD.Add(new MD() { English = "Zero (0)", Malay = "Sifar / kosong", Say = "" });
            items_MD.Add(new MD() { English = "One (1)", Malay = "Satu", Say = "" });
            items_MD.Add(new MD() { English = "Two (2)", Malay = "Dua", Say = "" });
            items_MD.Add(new MD() { English = "Three (3)", Malay = "Tiga", Say = "" });
            items_MD.Add(new MD() { English = "Four (4)", Malay = "Empat", Say = "" });
            items_MD.Add(new MD() { English = "Five (5)", Malay = "Lima", Say = "" });
            items_MD.Add(new MD() { English = "Six (6)", Malay = "Enam", Say = "" });
            items_MD.Add(new MD() { English = "Seven (7)", Malay = "Tujuh", Say = "" });
            items_MD.Add(new MD() { English = "Eight (8)", Malay = "Lapan", Say = "" });
            items_MD.Add(new MD() { English = "Nine (9)", Malay = "Sembilan", Say = "" });
            items_MD.Add(new MD() { English = "Ten (10)", Malay = "Sepuluh", Say = "" });
            items_MD.Add(new MD() { English = "Eleven (11)", Malay = "Sebelas", Say = "" });
            items_MD.Add(new MD() { English = "Twelve (12)", Malay = "Dua belas", Say = "" });
            items_MD.Add(new MD() { English = "Thirteen (13)", Malay = "Tiga belas", Say = "" });
            items_MD.Add(new MD() { English = "Twenty (20)", Malay = "Dua puluh", Say = "" });
            items_MD.Add(new MD() { English = "Thirty (30)", Malay = "Tiga puluh", Say = "" });
            items_MD.Add(new MD() { English = "Thirty One (31)", Malay = "Tiga puluh Satu", Say = "" });
            items_MD.Add(new MD() { English = "One Hundred (100)", Malay = "Seratus", Say = "" });
            items_MD.Add(new MD() { English = "One Thousand (1000)", Malay = "Seribu", Say = "" });
            items_MD.Add(new MD() { English = "Half", Malay = "Setengah", Say = "(SUH-tung-ah)" });
            items_MD.Add(new MD() { English = "Quarter ", Malay = "Suku", Say = "(SOO-koo)" });
            items_MD.Add(new MD() { English = "Three quarter ", Malay = "Tiga suku", Say = "(TEE-gah SOO-koo)" });
            items_MD.Add(new MD() { English = "Less ", Malay = "Kurang ", Say = "(KOO-rahng)" });
            items_MD.Add(new MD() { English = "More ", Malay = "Lebih  ", Say = "(LUH-bay)" });
            items_MD.Add(new MD() { English = "Roughly (more or less) ", Malay = "Lebih kurang  ", Say = "(LUH-bay KOO-rahng)" });

            items_MD.Add(new MD() { Say = "Time" });
            items_MD.Add(new MD() { English = "What time is it?", Malay = "Pukul berapa sekarang?", Say = "" });
            items_MD.Add(new MD() { English = "now", Malay = "sekarang", Say = "(suh-KAH-rahng)" });
            items_MD.Add(new MD() { English = "later", Malay = "nanti", Say = "(NAN-tee)" });
            items_MD.Add(new MD() { English = "before", Malay = "sebelum", Say = "(suh-BUH-lom)" });
            items_MD.Add(new MD() { English = "after", Malay = "selepas", Say = "(suh-LUH-pas)" });
            items_MD.Add(new MD() { English = "morning", Malay = "pagi", Say = "PAH-gee" });
            items_MD.Add(new MD() { English = "afternoon", Malay = "tengah hari (10.30 – 15.00)", Say = "(TUH-ngah HA-ree)" });
            items_MD.Add(new MD() { English = "evening", Malay = "petang (15.00 – 19.00)", Say = "(PUH-tahng)" });
            items_MD.Add(new MD() { English = "night", Malay = "malam (19.00 – 00.00)", Say = "(MAH-lahm)" });
            items_MD.Add(new MD() { English = "1am", Malay = "pukul satu pagi", Say = "(POOH-kool SAH-tu PAH-gee)" });
            items_MD.Add(new MD() { English = "2am", Malay = "pukul dua pagi", Say = "(POOH-kool DOO-ah PAH-gee)" });
            items_MD.Add(new MD() { English = "noon", Malay = "tengah hari", Say = "(TUH-ngah HA-ree)" });
            items_MD.Add(new MD() { English = "1pm", Malay = "pukul satu petang", Say = "(POOH-kool SAH-tu PUH-tahng)" });
            items_MD.Add(new MD() { English = "2pm", Malay = "pukul dua petang", Say = "(POOH-kool DOO-ah PUH-tahng)" });
            items_MD.Add(new MD() { English = "midnight", Malay = "tengah malam", Say = "(TUH-ngah MAH-lahm)" });
            items_MD.Add(new MD() { English = "second(s)", Malay = "saat", Say = "(SAH-aht)" });
            items_MD.Add(new MD() { English = "minute(s)", Malay = "minit", Say = "(MI-nit)" });
            items_MD.Add(new MD() { English = "hour(s)", Malay = "jam", Say = "(jahm)" });
            items_MD.Add(new MD() { English = "day(s)", Malay = "hari", Say = "(HAH-ree)" });
            items_MD.Add(new MD() { English = "week(s)", Malay = "minggu", Say = "(MEENG-goo)" });
            items_MD.Add(new MD() { English = "month(s)", Malay = "bulan", Say = "(BOO-lahn)" });
            items_MD.Add(new MD() { English = "year(s)", Malay = "tahun", Say = "(tah-HOON)" });
            items_MD.Add(new MD() { English = "this week", Malay = "minggu ini", Say = "(MEENG-goo EE-nee)" });
            items_MD.Add(new MD() { English = "last week", Malay = "minggu lepas", Say = "(MEENG-goo luh-PAHS)" });
            items_MD.Add(new MD() { English = "next week", Malay = "minggu depan", Say = "(MEENG-goo deh-PAHN)" });


            items_MD.Add(new MD() { English = "", Malay = "", Say = "Dates" });
            items_MD.Add(new MD() { English = "Dates", Malay = "Tarikh", Say = "" });
            items_MD.Add(new MD() { English = "January", Malay = "Januari", Say = "(JAH-noo-ah-ree)" });
            items_MD.Add(new MD() { English = "February", Malay = "Februari", Say = "(FE-bru-ah-ree)" });
            items_MD.Add(new MD() { English = "March", Malay = "Mac", Say = "(MAHCH)" });
            items_MD.Add(new MD() { English = "April", Malay = "April", Say = "(AH-preel)" });
            items_MD.Add(new MD() { English = "May", Malay = "Mei", Say = "(MAY)" });
            items_MD.Add(new MD() { English = "June", Malay = "Jun", Say = "(JOON)" });
            items_MD.Add(new MD() { English = "July", Malay = "Julai", Say = "(JOOL-ly)" });
            items_MD.Add(new MD() { English = "August", Malay = "Ogos", Say = "(oh-GOHS)" });
            items_MD.Add(new MD() { English = "September", Malay = "September", Say = "(SEP-tem-ber)" });
            items_MD.Add(new MD() { English = "October", Malay = "Oktober", Say = "(OKH-toh-ber)" });
            items_MD.Add(new MD() { English = "November", Malay = "November", Say = "(noh-vem-ber)" });
            items_MD.Add(new MD() { English = "December", Malay = "Disember", Say = "(dee-SEM-burr)" });

            ListViewAdapter_MD adapter = new ListViewAdapter_MD(this.Context, items_MD);

            ListView_MD.Adapter = adapter;
        }
    }
}