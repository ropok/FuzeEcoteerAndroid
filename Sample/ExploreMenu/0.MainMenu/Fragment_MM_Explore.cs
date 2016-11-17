using System;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Sample
{ 
        public class Fragment_MM_Explore : Android.Support.V4.App.Fragment
    {   

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.Fragment_MM_Explore, null);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            #region buttonMenu
            var menuE_MarineParkRules = Activity.FindViewById<LinearLayout>(Resource.Id.ExploreMarineParkRules);
            var menuE_HowToGetHere = Activity.FindViewById<LinearLayout>(Resource.Id.ExploreHowToGetHere);
            var menuE_CoralWatch = Activity.FindViewById<LinearLayout>(Resource.Id.ExploreCoralWatch);
            var menuE_FoodAndDrink = Activity.FindViewById<LinearLayout>(Resource.Id.ExploreFoodAndDrink);
            var menuE_MalayDictionary = Activity.FindViewById<LinearLayout>(Resource.Id.ExploreMalayDictionary);

            menuE_MarineParkRules.Click += MenuE_MarineParkRules_Click;
            menuE_HowToGetHere.Click += MenuE_HowToGetHere_Click;
            menuE_CoralWatch.Click += MenuE_CoralWatch_Click;
            menuE_FoodAndDrink.Click += MenuE_FoodAndDrink_Click;
            menuE_MalayDictionary.Click += MenuE_MalayDictionary_Click;
            #endregion
        }

        private void MenuE_MalayDictionary_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(activity_MalayDict)));
        }

        private void MenuE_FoodAndDrink_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(activity_FoodDrink)));
        }
        

        private void MenuE_CoralWatch_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(activity_CoralWatch)));
        }

        private void MenuE_HowToGetHere_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(activity_howToGetHere)));
        }

        private void MenuE_MarineParkRules_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(activity_MarineParkRules)));
        }
    }
}