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
    [Activity(Label = "Latest projects", ParentActivity = typeof(activity_FuzeEcoteer))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "activity_FuzeEcoteer")]
    public class Dive_Projects : AppCompatActivity
    {
        private List<FD> items_Dive;
        private ListView ListView_Dive;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Dive_Projects);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarDive_Projects);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            ListView_Dive = FindViewById<ListView>(Resource.Id.ListView_Dive_Projects);
            items_Dive = new List<FD>();
            

            items_Dive.Add(new FD()
            {
                Title = "Human Behaviour",
                Description = "How does human behaviour affect the marine environment? Perhentian diving, snorkelling, and tourism all affect it differently, but we want to see if pre-trip ‘awareness briefings’ can reduce tourists’ impact on the ocean. The aim is to increase awareness and improve our underwater behaviour."
            });

            items_Dive.Add(new FD()
            {
                Title = "Awareness and Behaviour",
                Description = "Another key focus are the local stakeholders. We want to provide an increased knowledge so that people can understand how to live in harmony with the environment. We have been working to reduce plastic use on the islands and a big part of that is researching what types of plastic are most common and where it is coming from. The aim is to collect relevant data that we can use to implement wide-scale reductions in plastic use and improved management of waste on the islands and includes research into current behaviours and practices."
            });

            items_Dive.Add(new FD()
            {
                Title = "Micro-Plastics",
                Description = "Plastic bottles, straws, polystyrene and other similar single use products are just one side of the problem facing our oceans. There is a growing concern about the presence of micro-plastic on our beaches, in our oceans and even in the fish we eat. As such, we have teamed up with experts from the University of Malaya in an attempt to begin research on the presence of micro-plastics on the island beaches and in the sea bed."
            });

            items_Dive.Add(new FD()
            {
                Title = "Coral Growth",
                Description = "Whilst it is important to understand how humans interact with the environment, it is also important to understand the environmental reaction to our actions. As such we have begun coral growth monitoring at intensively dived coral reefs and comparing them with non-intensively dived sites. This will allow us to gather some information based on the potential impact tourism and diving is having on reef resilience."
            });

            items_Dive.Add(new FD()
            {
                Title = "Pollution",
                Description = "Perhentian diving is famous, but as a consequence the tourist industry causes a lot of pollution. We want to complete seasonal studies of litter and water quality across the sites we work at. From this data we can recommend courses of action to counteract human influence on the environment."
            });

            items_Dive.Add(new FD()
            {
                Title = "Artificial Reefs",
                Description = "Opinions are split on artificial reefs. Some claim they are being successfully implemented to provide healthier coral reefs, but others claim they attract fish and species away from natural reefs. They are being trialled by the Marine Dept. to attract Perhentian divers away from natural reefs. We are attempting to aid and assist stakeholders as they attempt create an underwater playground for divers to enjoy."
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this, items_Dive);

            ListView_Dive.Adapter = adapter;

            var Dive_moreInfo = FindViewById<LinearLayout>(Resource.Id.Dive_Projects_moreInfo);

            Dive_moreInfo.Click += Dive_moreInfo_Click;
        }

        private void Dive_moreInfo_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://www.bluetemple.co.uk/index.php/research-1");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
    }
}