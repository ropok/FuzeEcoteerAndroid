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
    [Activity(Label = "Ecoteer House - Projects", ParentActivity = typeof(activity_FuzeEcoteer))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "activity_FuzeEcoteer")]
    public class EH_Projects : AppCompatActivity
    {
        private List<FD> items_EH;
        private ListView ListView_EH;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EH_Projects);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarEH_Projects);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            ListView_EH = FindViewById<ListView>(Resource.Id.ListView_EH_Projects);
            items_EH = new List<FD>();
            items_EH.Add(new FD()
            {   Image = Resource.Drawable.EH_Projects_0,
                Title = "Ecoteer House : Community & Conservation Project | Perhentian Islands",
                Description = "Volunteer at Ecoteer House in the tropical island paradise of the Perhentian Islands and you can get involved with the community and teach the children at the number one beach location in Malaysia, as named by CNN in 2013. Ranking 13th in the entire world, these beaches are well worth a visit and deserve to be maintained for future generations to enjoy. Through community tourism, environmental awareness and community interaction, the Ecoteer House aims to teach and support the islanders to care for their islands whilst offering volunteers first-hand experience of community life in a traditional Malaysian village surrounded by turquoise seas, white sands and vibrant marine life."
            });

            items_EH.Add(new FD()
            {   Image = Resource.Drawable.EH_Projects_1,
                Title = "Perhentian Dive Project",
                Description = "Through our Dive Research project you will join hands with researchers to help collect data on the seagrass beds, corals reefs and artificial reefs in the Perhentian Islands. You will be be based in the village allowing you to understand more about the local culture."
            });


            items_EH.Add(new FD()
            {
                Image = Resource.Drawable.EH_Projects_2,
                Title = "Charity Challenge – Cycle for Turtles",
                Description = "Cycle along the east coast of Peninsular Malaysia visiting different turtle projects along the way.\nThis adventure will see you waking up each morning to beautiful sunrise’s across the South China Sea.The East coast of Pensinsular Malaysia is almost all continuous beach,\nperfect for nesting season turtles.You will cycle from turtle project to turtle project sleeping under the stars watching turtles lay their eggs.This is an experience not to be missed by anyone!"
            });

            items_EH.Add(new FD()
            {
                Image = Resource.Drawable.EH_Projects_3,
                Title = "3D2N Sea turtle Conservation Holiday – Perhentian Islands",
                Description = "Sitting on the beach at night, under a star lit sky, whilst protecting sea turtles. Snorkel in turquoise waters, take photos of sea turtles and other marine creatures. And take some well-deserved relaxing time on one of the most beautiful beaches of Malaysia after doing a beach clean-up. This is a unique opportunity to actually get close to Malaysians endangered sea turtles and join hands with a local research team."
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this, items_EH);

            ListView_EH.Adapter = adapter;

            var EH_moreInfo = FindViewById<LinearLayout>(Resource.Id.EH_Projects_moreInfo);

            EH_moreInfo.Click += EH_moreInfo_Click;
            
        }

        private void EH_moreInfo_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://ecoteerresponsibletravel.com/responsible-travelvolunteerism/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
        
    }
}