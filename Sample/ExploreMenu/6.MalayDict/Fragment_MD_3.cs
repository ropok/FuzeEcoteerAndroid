using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MD_3 : Android.Support.V4.App.Fragment
    {
        private List<MD> items_MD;
        private ListView ListView_MD;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MD_3, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_MD = Activity.FindViewById<ListView>(Resource.Id.ListView_MD3);

            items_MD = new List<MD>();

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Talking" });
            items_MD.Add(new MD() { English = "Do you speak English?", Malay = "Bolehkah anda cakap Bahasa Inggeris?", Say = "(bo-LEH-kah ahn-DAH CHAH-kahp ba-HAH-suh ING-grees)" });
            items_MD.Add(new MD() { English = "I don't understand", Malay = "Saya tak faham", Say = "(SAH-yuh tah fah-HAHM)" });
            items_MD.Add(new MD() { English = "Where is the toilet?", Malay = "Di mana tandas?", Say = "(dee MAH-nuh TAHN-dahs)" });
            items_MD.Add(new MD() { English = "How much is a ticket to _____?", Malay = "Berapa harga tiket ke _____?", Say = "(buh-RAH-puh HAHR-guh TEE-ket kuh _____)" });
            items_MD.Add(new MD() { English = "I want to buy one ticket to _____", Malay = "Saya nak beli satu tiket ke _____", Say = "(SAH-yuh nah[glottal stop] blee SAH-too TEE-ket kuh _____)" });
            items_MD.Add(new MD() { English = "Where does this train/bus go?", Malay = "Tren/bas ini pergi ke mana?", Say = "(tren/bahs EE-nee puhr-GEE kuh MAH-nuh)" });
            items_MD.Add(new MD() { English = "Where is the train/bus to _____?", Malay = "Di manakah tren/bas ke _____?", Say = "(DEE mah-NUH-kah TREN/BAHS kuh _____)" });
            items_MD.Add(new MD() { English = "Will this train/bus stop in _____?", Malay = "Akankah tren/bas ini berhenti di _____?", Say = "(ah-KAHN-kah TREN/BAHS EE-NEE ber-HEN-tee dee _____)" });
            items_MD.Add(new MD() { English = "What time does the train/bus leave for _____?", Malay = "Bilakah tren/bas pergi ke _____?", Say = "(BEE-lah-kuh TREN/BAS PUH-gee kuh _____)" });
            items_MD.Add(new MD() { English = "When will this train/bus arrive in _____?", Malay = "Bilakah tren/bas ini akan sampai di _____?", Say = "(BEE-lah-kuh TREN/BAS EE-nee AH-kahn sahm-PAI dee _____)" });

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Directions" });
            items_MD.Add(new MD() { English = "How do I get to _____", Malay = "Bagaimanakah saya pergi ke _____", Say = "(BAH-gai-MAH-nuh-kah SAH-yuh PUH-gee kuh _____)" });
            items_MD.Add(new MD() { English = "...the train station?", Malay = "...stesyen kereta api?", Say = "(STAY-shun kuh-RAY-tah AH-pee)" });
            items_MD.Add(new MD() { English = "...the bus station?", Malay = "...terminal/stesyen bas?", Say = "(TUH-mee-nahl/STAY-shun BAHS)" });
            items_MD.Add(new MD() { English = "...the airport?", Malay = "...lapangan terbang?", Say = "(lah-PAHNG-an tuh-BAHNG)" });
            items_MD.Add(new MD() { English = "...downtown?", Malay = "...kota?", Say = "(KOH-tah)" });
            items_MD.Add(new MD() { English = "...the _____ hotel?", Malay = "... hotel _____?", Say = "(HOH-tehl _____)" });
            items_MD.Add(new MD() { English = "Please show me on the map", Malay = "Tolong tunjukkan saya di peta", Say = "(TOH-lohng TOON-jook-kahn SAH-yuh dee PUH-tuh)" });
            items_MD.Add(new MD() { English = "street", Malay = "jalan", Say = "(JAH-lahn)" });
            items_MD.Add(new MD() { English = "Turn left", Malay = "Pusing kiri", Say = "(POOH-singh KEE-ree)" });
            items_MD.Add(new MD() { English = "Turn right", Malay = "Pusing kanan", Say = "(POOH-singh KAH-nahn)" });
            items_MD.Add(new MD() { English = "left", Malay = "kiri", Say = "(KEE-ree)" });
            items_MD.Add(new MD() { English = "right", Malay = "kanan", Say = "(KAH-nahn)" });
            items_MD.Add(new MD() { English = "straight ahead", Malay = "lurus", Say = "(LOOH-roohs)" });
            items_MD.Add(new MD() { English = "towards the _____", Malay = "menuju _____", Say = "(>muh-NOO-JOO)" });
            items_MD.Add(new MD() { English = "past the _____", Malay = "selepas _____", Say = "(SUH-luh-pahs)" });
            items_MD.Add(new MD() { English = "before the _____", Malay = "sebelum _____ ", Say = "(SUH-buh-luhm)" });
            items_MD.Add(new MD() { English = "Watch for the _____", Malay = "Perhatikan _____", Say = "(puh-HAH-tee-kahn)" });
            items_MD.Add(new MD() { English = "intersection", Malay = "persilangan", Say = "(puh-SEE-lahng-an)" });

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Wind-Direction" });
            items_MD.Add(new MD() { English = "north", Malay = "utara", Say = "(ooh-TAH-rah)" });
            items_MD.Add(new MD() { English = "south", Malay = "selatan", Say = "(suh-LAH-tahn)" });
            items_MD.Add(new MD() { English = "east", Malay = "timur", Say = "(TEE-moor)" });
            items_MD.Add(new MD() { English = "west", Malay = "barat", Say = "(BAH-raht)" });
            items_MD.Add(new MD() { English = "north-east", Malay = "timur laut", Say = "(TEE-moor LAH-oot)" });
            items_MD.Add(new MD() { English = "north-west", Malay = "barat laut", Say = "(BAH-raht LAH-oot)" });
            items_MD.Add(new MD() { English = "south-east", Malay = "tenggara", Say = "(tuhng-GAH-rah)" });
            items_MD.Add(new MD() { English = "south-west", Malay = "barat daya", Say = "(BAH-raht DAH-yuh)" });

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Taxi" });
            items_MD.Add(new MD() { English = "Taxi!", Malay = "Teksi!", Say = "(TEH[glottal stop]-see)" });
            items_MD.Add(new MD() { English = "I want to go to _____", Malay = "Saya nak pergi ke _____", Say = "(SAH-yuh nahk puh-GEE kuh _____)" });
            items_MD.Add(new MD() { English = "How much does it cost to get to _____?", Malay = "Berapa harga untuk ke _____?", Say = "(buh-RAH-pah HAR-gah OON-took kuh _____)" });
            items_MD.Add(new MD() { English = "Take me there, please", Malay = "Tolong hantar saya ke sana", Say = "(TOH-lohng HAN-tahr SAH-yuh kuh SAH-nah)" });

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Lodging" });
            items_MD.Add(new MD() { English = "Do you have any rooms available?", Malay = "Adakah bilik kosong?", Say = "(AH-duh-kah BEE-leh[glottal stop] KOH-sohng?)" });
            items_MD.Add(new MD() { English = "How much is a room for one person/two people?", Malay = "Berapa harga bilik untuk satu/dua orang?", Say = "(buh-RAH-pah HAR-gah BEE-leh OON-took SAH-too/DOO-ah OH-rahng)" });
            items_MD.Add(new MD() { English = "Does the room come with...", Malay = "Adakah bilik termasuk...", Say = "(AH-dah-kah BEE-leh tuh-MAH-sook)" });
            items_MD.Add(new MD() { English = "...bedsheets?", Malay = "...alas/sarong tilam?", Say = "(AH-las/SAH-rohng TEE-lam)" });
            items_MD.Add(new MD() { English = "...a bathroom?", Malay = "...bilik mandi?", Say = "(BEE-leh MAHN-dee)" });
            items_MD.Add(new MD() { English = "...a telephone?", Malay = "...telefon?", Say = "(TEH-lee-phone)" });
            items_MD.Add(new MD() { English = "...a TV?", Malay = "...TV?", Say = "(tee-VEE)" });
            items_MD.Add(new MD() { English = "May I see the room first?", Malay = "Bolehkah saya lihat bilik dulu?", Say = "(BOH-lay-kah SAH-yuh LEE-hat BEE-leh DOO-loo)" });
            items_MD.Add(new MD() { English = "Do you have a room which is...", Malay = "Adakah bilik yang...", Say = "(AH-duh-kah BEE-leh YAHNG)" });
            items_MD.Add(new MD() { English = "...bigger?", Malay = "... lebih besar?", Say = "(LUH-beh BUH-sar)" });
            items_MD.Add(new MD() { English = "...cleaner?", Malay = "...lebih bersih?", Say = "(LUH-beh BUH-seh)" });
            items_MD.Add(new MD() { English = "...cheaper?", Malay = "...lebih murah?", Say = "(LUH-beh MOO-rah)" });
            items_MD.Add(new MD() { English = "Alright", Malay = "Baiklah", Say = "(BAH-eh-lah)" });
            items_MD.Add(new MD() { English = "I will stay for _____ night(s)", Malay = "Saya akan tinggal untuk _____ malam", Say = "(SAH-yuh AH-kahn TEENG-gahl OON-took _____ MAH-lahm)" });
            items_MD.Add(new MD() { English = "Do you have a safe?", Malay = "Adakah peti besi?", Say = "(AH-duh-kuh PUH-tee BUH-see)" });
            items_MD.Add(new MD() { English = "Do you have lockers?", Malay = "Adakah peti berkunci?", Say = "(AH-duh-kah PUH-tee BUH-koon-chee)" });
            items_MD.Add(new MD() { English = "Is breakfast/supper included?", Malay = "Sudahkah termasuk sarapan/makan malam?", Say = "(SOO-dah-kah TUH-mah-sohk sah-RAP-pahn/MAH-kahn MAH-lahm)" });
            items_MD.Add(new MD() { English = "What time is breakfast/supper?", Malay = "Pukul berapa sarapan/makan malam", Say = "(POOH-kool BUR-ah-pah sah-RAP-pahn/MAH-kahn MAH-lahm)" });
            items_MD.Add(new MD() { English = "Please clean my room", Malay = "Tolong bersihkan bilik saya", Say = "(TOH-long BUR-say-kahn BEE-leh SAH-yuh)" });
            items_MD.Add(new MD() { English = "Can you wake me at _____?", Malay = "Bolehkah tolong bangunkan saya pada pukul _____?", Say = "(BOH-leh-kah TOH-lohng BAHNG-oon-kahn SAH-yuh PAH-duh POOH-kool _____)" });
            items_MD.Add(new MD() { English = "I want to check out", Malay = "Saya nak check out", Say = "(SAH-yuh nahk check out)" });

            items_MD.Add(new MD() { English = "", Malay = "", Say = "Money" });
            items_MD.Add(new MD() { English = "Can I use a credit card?", Malay = "Bolehkah saya menggunakan kad kredit?", Say = "(BOH-lay-kuh SAH-yuh MUHNG-goo-nah-kahn kahd KREH-deet)" });
            items_MD.Add(new MD() { English = "Can I change money?", Malay = "Bolehkah saya bertukar wang?", Say = "(BOH-lay-kuh SAH-yuh BUR-tooh-kah WAHNG)" });
            items_MD.Add(new MD() { English = "Where is an automatic teller machine (ATM)?", Malay = "Di manakah ada ATM?", Say = "(dee MAH-nuh-kah AH-duh EY-TEE-EM)" });

            ListViewAdapter_MD adapter = new ListViewAdapter_MD(this.Context, items_MD);

            ListView_MD.Adapter = adapter;
        }
    }
}