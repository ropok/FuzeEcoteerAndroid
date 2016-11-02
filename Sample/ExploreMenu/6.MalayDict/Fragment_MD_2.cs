using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MD_2 : Android.Support.V4.App.Fragment
    {
        private List<MD> items_MD;
        private ListView ListView_MD;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MD_2, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_MD = Activity.FindViewById<ListView>(Resource.Id.ListView_MD2);

            items_MD = new List<MD>();
            items_MD.Add(new MD() { English = "", Malay = "", Say = "ORDER FOOD" });
            items_MD.Add(new MD() { English = "I want _____", Malay = "Saya nak _____", Say = "(SAH-yuh nak _____)" });
            items_MD.Add(new MD() { English = "May I look at the menu?", Malay = "Bolehkah saya melihat menu?", Say = "(BOH-lay-kah SAH-yuh muh-LEE-hat MEH-nu)" });
            items_MD.Add(new MD() { English = "Is there a house specialty?", Malay = " Adakah makanan yang istimewa di sini?", Say = "(AH-dah-kuh MAH-kah-nahn yahng EES-tee-meh-wah dee SEE-nee)" });
            items_MD.Add(new MD() { English = "I'm a vegetarian", Malay = "Saya seorang vegetarian", Say = "(SAH-yuh suh-OH-rahng veh-gee-TEH-ree-ahn)" });
            items_MD.Add(new MD() { English = "I want a dish containing _____", Malay = "Saya nak makanan yang mengandungi _____", Say = "(SAH-yuh nak MAH-kah-nahn yahng meng-ahn-dohng-ee)" });
            items_MD.Add(new MD() { English = "I don't eat ___", Malay = "Saya tidak makan ___", Say = "(SAH-yuh TEE-dahk MAH-kahn)" });
            items_MD.Add(new MD() { English = "I am allergic to _____", Malay = "Saya alah kepada _____", Say = "(SAH-yuh AH-lah kuh-PAH-dah)" });
            items_MD.Add(new MD() { English = "chicken", Malay = "ayam", Say = "(AH-yahm)" });
            items_MD.Add(new MD() { English = "beef", Malay = "daging lembu", Say = "(DAH-geeng LUHM-boo)" });
            items_MD.Add(new MD() { English = "fish", Malay = "ikan", Say = "(EE-kahn)" });
            items_MD.Add(new MD() { English = "ham", Malay = "ham", Say = "(hahm)" });
            items_MD.Add(new MD() { English = "sausage", Malay = "sosej", Say = "(SOH-seyj)" });
            items_MD.Add(new MD() { English = "cheese", Malay = "keju", Say = "(KUH-joo)" });
            items_MD.Add(new MD() { English = "eggs", Malay = "telur", Say = "(TUH-loh)" });
            items_MD.Add(new MD() { English = "salad", Malay = "salad", Say = "(SAH-lahd)" });
            items_MD.Add(new MD() { English = "vegetables", Malay = "sayur", Say = "(SAH-yoor)" });
            items_MD.Add(new MD() { English = "fruit", Malay = "buah", Say = "(BOO-ah)" });
            items_MD.Add(new MD() { English = "bread", Malay = "roti", Say = "(ROH-tee)" });
            items_MD.Add(new MD() { English = "toast", Malay = "roti bakar", Say = "(ROH-tee BAH-kahr)" });
            items_MD.Add(new MD() { English = "noodles", Malay = "mee", Say = "" });
            items_MD.Add(new MD() { English = "rice", Malay = "nasi (=cooked rice)/beras (=raw rice)", Say = "(NAH-see/BUH-rahs)" });
            items_MD.Add(new MD() { English = "I want a glass/cup/bottle of _____", Malay = "Saya nak segelas/secawan/sebotol _____", Say = "(SAH-yuh nak suh-GUH-lahs/suh-CHAH-wahn/suh-BOH-tohl)" });
            items_MD.Add(new MD() { English = "coffee", Malay = "kopi", Say = "(KOH-pee)" });
            items_MD.Add(new MD() { English = "tea", Malay = "teh", Say = "(teh)" });
            items_MD.Add(new MD() { English = "juice", Malay = "jus", Say = "(joos)" });
            items_MD.Add(new MD() { English = "soft drink", Malay = "minuman ringan", Say = "(mee-NOOH-mahn)" });
            items_MD.Add(new MD() { English = "water", Malay = "air", Say = "(AH-eh)" });
            items_MD.Add(new MD() { English = "May I have some _____?", Malay = "Bolehkah saya ada _____?", Say = "(BOH-leh-kah SAH-yuh AH-duh)" });
            items_MD.Add(new MD() { English = "Can you please add ____?", Malay = "Bolehkah tambah _____?", Say = "(BOH-leh-kah TAM-bah)" });
            items_MD.Add(new MD() { English = "salt", Malay = "garam", Say = "(GAH-rahm')" });
            items_MD.Add(new MD() { English = "sugar", Malay = "gula", Say = "(GOO-lah)" });
            items_MD.Add(new MD() { English = "black pepper", Malay = "lada hitam", Say = "(LAH-duh HEE-tum)" });
            items_MD.Add(new MD() { English = "butter", Malay = "mentega", Say = "(muhn-TEY-gah)" });
            items_MD.Add(new MD() { English = "I'm finished", Malay = "Saya sudah selesai", Say = "(SAH-yuh SOO-dah suh-LEH-sah-yi)" });
            items_MD.Add(new MD() { English = "I'm full", Malay = "Saya kenyang", Say = "(SAH-yuh KUHN-yahng)" });
            items_MD.Add(new MD() { English = "It was delicious", Malay = "Sedaplah", Say = "(SUH-dahp-lah)" });
            items_MD.Add(new MD() { English = "I liked it very much&", Malay = "Saya sangat suka", Say = "(SAH-yuh SAHNG-aht SOO-kah)" });
            items_MD.Add(new MD() { English = "It's too bitter", Malay = "Terlalu pahit", Say = "(TUH-lah-loo PAH-hit)" });
            items_MD.Add(new MD() { English = "It's too spicy", Malay = "Terlalu pedas", Say = "(TUH-lah-loo PUH-dahs)" });
            items_MD.Add(new MD() { English = "It's too hot", Malay = "Terlalu panas", Say = "(TUH-lah-loo PAH-nahs)" });
            items_MD.Add(new MD() { English = "That's enough", Malay = "Cukuplah", Say = "(CHOO-koop-lah)" });
            items_MD.Add(new MD() { English = "I would like to take away", Malay = "Saya nak bungkus", Say = "(SAH-yuh nahk BOONG-koos)" });

            ListViewAdapter_MD adapter = new ListViewAdapter_MD(this.Context, items_MD);

            ListView_MD.Adapter = adapter;
        }
    }
}