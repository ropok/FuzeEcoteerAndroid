using Android.App;
using Android.OS;
using com.refractored;
using Android.Support.V4.View;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;
using Android.Widget;
using System.Collections.Generic;
using System;
using Android.Content;


/*
    Using Listview FD
*/
namespace Sample
{
    [Activity(Label = "Blue Temple Conservation", ParentActivity = typeof(activity_FuzeEcoteer))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "activity_FuzeEcoteer")]
    public class Dive_Introduction : AppCompatActivity
    {
        private List<FD> items_Dive;
        private ListView ListView_Dive;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Dive_Introduction);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarDive_Intro);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            ListView_Dive = FindViewById<ListView>(Resource.Id.ListView_Dive_Intro);
            items_Dive = new List<FD>();

            items_Dive.Add(new FD()
            {   Image = Resource.Drawable.BTC_logo_intro,
               });

            items_Dive.Add(new FD()
            {
                Title = "The role model approach",
                Description = "Being successful in conservation begins at home. That is why at Blue Temple we want to be good role models for others, whether it is through reducing our plastic use by carrying refillable containers and cotton bags or reducing diving impacts by behaving responsibly and continuing to provide advice and help to both new and experienced divers."
            });

            items_Dive.Add(new FD()
            {
                Title = "Our research",
                Description = "One of the key concepts for our work is our research. We love the whole idea of collecting data and reading in an attempt to find out stuff that people haven't found out before. But it is more than that, we want to take our ability to conduct research and put it towards something practical. That is why since our beginning, we have been using our research to identify problem areas and to try to implement change at stakeholder and management level."
            });

            items_Dive.Add(new FD()
            {
                Title = "Campaigns",
                Description = "Research is only as useful as the people reading it, as such, we have taken the knowledge gained from our work and have focused our work to target what we feel are major players in ocean problems. First is our #FreeFromPlasic campaign where we are working towards a plastic free life, starting with eliminating pesky single use plastics like bags, bottles, straws and cups. Second is our #BlueTempleDiver campaign, where we target sustainable diving practices through awareness, training and evaluation of diver behaviour and work closely with dive centres to help them improve, whether through Green Fins or through our own support."
            });

            items_Dive.Add(new FD()
            {
                Title = "Working with local people",
                Description = "is an important part of the project:  we promote a symbiotic relationship between locals and their environment. We encourage local people to join us in our research and help to conduct surveys. Free of charge, we’ve been training them in monitoring and scuba-diving so they can understand the importance of maintaining the reefs and environment."
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this, items_Dive);

            ListView_Dive.Adapter = adapter;

            var Dive_moreInfo = FindViewById<LinearLayout>(Resource.Id.Dive_Intro_moreInfo);

            Dive_moreInfo.Click += Dive_moreInfo_Click;
        }

        private void Dive_moreInfo_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://www.bluetemple.co.uk/index.php/about-us-1");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

    }
}