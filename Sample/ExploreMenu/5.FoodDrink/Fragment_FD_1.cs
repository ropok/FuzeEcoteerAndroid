using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_FD_1 : Android.Support.V4.App.Fragment
    {
        private List<FD> items_FD;
        private ListView ListView_FD;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_FD_1, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_FD = Activity.FindViewById<ListView>(Resource.Id.ListView_FD1);

            items_FD = new List<FD>();


            items_FD.Add(new FD() { Image = Resource.Drawable.food_rotiCanai, Title = "Roti Canai", Description = "A dough of flour, egg, and ghee (clarified butter) is incredibly, almost unbelievably elastic.\n It's also served with curry.\n Other versions are cooked with egg, or onion, or sardines." });
            items_FD.Add(new FD() { Image = Resource.Drawable.food_chickenCurry, Title = "Chicken Curry", Description = "Malaysian versions tend to start with a rempah, a complex paste of spices and aromatics that's cooked together and forms the base of the curry" });
            items_FD.Add(new FD() { Image = Resource.Drawable.food_meeGoreng, Title = "Mee Goreng", Description = "Stir-fried noodles, which take many forms. You'll often see yellow noodles quickly wok'd up with soy, garlic, shallots, and chilies; along with them might be shrimp or chicken, beef or vegetables. " });
            items_FD.Add(new FD() { Image = Resource.Drawable.food_meeRebus, Title = "Mee Rebus", Description = "The yellow mee noodles are doused in a sauce of sweet potato and tomato, cooked (as are so many dishes) with a fried chili-based rempah. It's topped with fried egg, calamansi lime, fried tofu, fried shallots, and bean sprouts." });
            items_FD.Add(new FD() { Image = Resource.Drawable.food_nasiGoreng, Title = "Nasi Goreng", Description = "Rice stir-fried with chilis and garlic and kecap manis (sweet soy); like mee goreng, it might have chicken or shrimp for a little more substance. " });
            items_FD.Add(new FD() { manyMore = "Many More !" });



            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_FD);

            ListView_FD.Adapter = adapter;
        }
    }
}

//items_FD.Add(new FD() { Image = Resource.Drawable, Title = "", Description = "" });