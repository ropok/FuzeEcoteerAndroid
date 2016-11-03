using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_FD_2 : Android.Support.V4.App.Fragment
    {
        private List<FD> items_FD;
        private ListView ListView_FD;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_FD_2, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_FD = Activity.FindViewById<ListView>(Resource.Id.ListView_FD2);

            items_FD = new List<FD>();
            items_FD.Add(new FD() { Image = Resource.Drawable.drink_miloAis, Title = "Milo Ais", Description = "This drink is basically made using a mixture of Milo and sweetened condensed milk. Milo Ais tastes like hot chocolate served with ice cubes." });
            items_FD.Add(new FD() { Image = Resource.Drawable.drink_Neslo, Title = "Neslo", Description = "This cold drink is a mixture of Nescafé and Milo (similar to Nesquik chocolate mix for Americans), and tastes like a watered-down iced mocha." });
            items_FD.Add(new FD() { Image = Resource.Drawable.drink_tehTarik, Title = "Teh Tarik", Description = "A good cup of teh tarik is strong, brisk, and creamy so when you drink it, your mouth registers a full-bodied feel with a potent kick of sweetness. Teh tarik is more than just a cup of tea mixed with condensed milk; it is almost revered as a culture." });
            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_FD);

            ListView_FD.Adapter = adapter;
        }
    }
}