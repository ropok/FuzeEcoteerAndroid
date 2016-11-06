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
    public class PTP_Introduction : AppCompatActivity
    {
        private List<FD> items_PTP;
        private ListView ListView_PTP;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PTP_Introduction);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarPTP_Intro);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            ListView_PTP = FindViewById<ListView>(Resource.Id.ListView_PTP_Intro);
            items_PTP = new List<FD>();

            items_PTP.Add(new FD()
            {   Image = Resource.Drawable.PTP_intro_1,
                Title = "Turtle Conservation Project | Perhentian Island",
                Description = "Help us conserve Sea Turtles on the tropical island paradise, the Perhentian Islands. You too can play your part to help preserve the number one beach location in Malaysia, as named by CNN in 2013. These beaches are well worth a visit and deserve to be maintained for future generations to enjoy. Through our Turtle and Island project you will join hands with researchers and the local government to help conserve sea turtles in the Perhentian Islands. Your time will be split into two, the village and the turtle beach. When you are in the village you will help our researchers to collect scientific data by literally snorkelling and snapping photos of turtles. The photos will be used to identify individual turtle’s and their movements around the islands which will help decision makers to develop a sea turtle management plan for the islands. You will also get a chance to experience the Malaysian hospitality and enjoy village life. When you are based at the Turtle Beach you will enjoy the rustic beach life, chilling in hammocks in the morning, afternoon snorkel surveys and night patrols under the stars and moon helping mother sea turtles lay their eggs and sending off hatchlings on their lifetime voyage. And of course, you will have time off to enjoy these beautiful, paradise islands.\n\nIf you are looking to do a meaningful conservation project in a paradise beach location then this project is for you."
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this, items_PTP);

            ListView_PTP.Adapter = adapter;

            var PTP_moreInfo = FindViewById<LinearLayout>(Resource.Id.PTP_Intro_moreInfo);

            PTP_moreInfo.Click += PTP_moreInfo_Click;
            
        }

        private void PTP_moreInfo_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://ecoteerresponsibletravel.com/portfolio/turtleconservationperhentianisland/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

    }
}