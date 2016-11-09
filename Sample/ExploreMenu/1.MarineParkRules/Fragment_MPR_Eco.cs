using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MPR_Eco : Android.Support.V4.App.Fragment
    {
        private List<FD> items_MPR_Eco;
        private ListView ListView_MPR_Eco;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MPR_Eco, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_MPR_Eco = Activity.FindViewById<ListView>(Resource.Id.ListView_MPR_Eco);

            items_MPR_Eco = new List<FD>();


            items_MPR_Eco.Add(new FD()
            {
                //Image = Resource.Drawable.No_Touching_or_Chasing_Marine_Life,
                Title = "Be a Responsible Travel at Marine Park",
                Description = "We are based in the village and doing community and conservation.\n\nGet the best out of the snorkel tour by doing eco snorkel tour with trained guide from the chosen eco snorkel boatman below.",
                manyMore = ""
            });

            items_MPR_Eco.Add(new FD()
            {
                //Image = Resource.Drawable.No_Touching_or_Chasing_Marine_Life,
                Title = "",
                Description = "",
                manyMore = ""
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_MPR_Eco);

            ListView_MPR_Eco.Adapter = adapter;
        }
    }
}

//items_FD.Add(new FD() { Image = Resource.Drawable, Title = "", Description = "" });
//items_MPR_Eco.Add(new FD()
//{
//    //Image = Resource.Drawable.No_Touching_or_Chasing_Marine_Life,
//    Title = "",
//                Description = "",
//                manyMore = ""
//            });