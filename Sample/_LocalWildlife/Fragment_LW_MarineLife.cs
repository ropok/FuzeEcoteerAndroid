using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_LW_MarineLife : Android.Support.V4.App.Fragment
    {
        private List<FD> items_LW;
        private ListView ListView_LW;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_LW_MarineLife, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_LW = Activity.FindViewById<ListView>(Resource.Id.ListView_LW_MarineLife);

            items_LW = new List<FD>();


            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_Turtle,
                Title = "Green Turtles",
                Description = "Are the most common turtle species around the islands. Their eggs and nests are protected here. "
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_TriggerFish,
                Title = "Trigger Fish",
                Description = "Are commonly seen while snorkelling, beware they can be aggressive when guarding eggs."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_Stingrays,
                Title = "Stingrays",
                Description = "Are a common sight, careful not to step on them, as their sting can be painful."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_HawksBillTurtle,
                Title = "Hawksbill turtles",
                Description = "Also live around these islands, however they are critically endangered and much rarer."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_BlackTipReefSharks,
                Title = "Black tip reef sharks",
                Description = "Are the most common sharks here. They are timid and skittish and not a danger to swimmers, as long as not provoked."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_PufferFish,
                Title = "Puffer fish",
                Description = "Are one of the stranger fish you will see near the islands."
            });
            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_LW);

            ListView_LW.Adapter = adapter;
        }
    }
}

//items_FD.Add(new FD() { Image = Resource.Drawable, Title = "", Description = "" });
//items_FD.Add(new FD() { manyMore = "Many More !" });