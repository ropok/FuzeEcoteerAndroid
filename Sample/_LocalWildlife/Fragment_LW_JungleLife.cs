using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_LW_JungleLife : Android.Support.V4.App.Fragment
    {
        private List<FD> items_LW;
        private ListView ListView_LW;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_LW_JungleLife, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_LW = Activity.FindViewById<ListView>(Resource.Id.ListView_LW_JungleLife);

            items_LW = new List<FD>();


            items_LW.Add(new FD() {
                Image = Resource.Drawable.WL_JL_Lizard,
                Title = "Moniter Lizards",
                Description = "Live all over both islands including the village."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_Python,
                Title = "Reticulated Pythons",
                Description = "Grow Up to 6.5m in length, these giants live deep in the forest of both islands."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_Eagle,
                Title = "White Bellied Eagles",
                Description = "Is distinguished by its white head and breast. These can sometimes be seen hunting fish in the sea surrounding the islands."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_DLMonkey,
                Title = "Dusky leaf monkeys",
                Description = "Live on the big island. Dwelling in tall trees deep in the forest, feeding on shoots and seedlings."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_Tokay,
                Title = "Tokay Gecko",
                Description = "Is a large Gecko (up to 35cms) whose call you will hear all over the islands."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_FlyLemur,
                Title = "Flying Lemurs",
                Description = "Are found on both islands, they can glide up to 120m."
            });
            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_LW);

            ListView_LW.Adapter = adapter;
        }
    }
}

//items_FD.Add(new FD() { Image = Resource.Drawable, Title = "", Description = "" });
//items_FD.Add(new FD() { manyMore = "Many More !" });