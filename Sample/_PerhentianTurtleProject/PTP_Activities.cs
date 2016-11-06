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
    Using Listview HTGH
*/
namespace Sample
{
    [Activity(Label = "Ecoteer House - Projects", ParentActivity = typeof(activity_FuzeEcoteer))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "activity_FuzeEcoteer")]
    public class PTP_Activities : AppCompatActivity
    {
        private List<HTGH> items_PTP;
        private ListView ListView_PTP;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PTP_Activities);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarPTP_Act);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            ListView_PTP = FindViewById<ListView>(Resource.Id.ListView_PTP_Act);
            items_PTP = new List<HTGH>();

            items_PTP.Add(new HTGH() { Title = "Snorkel Photo ID Session",
                Image2 = Resource.Drawable.PTP_Act_2,
                Description = "The scutes (scales) on the flippers and the side of a green turtles face are unique to each individual. In collaboration with the Department of Fisheries and Cambridge University, UK, we collect photos of the sea turtles on nesting beaches and at sea whilst snorkelling. With each photo we also collect extra data such as location, time, date, male/female etc. We then use the software developed by Cambridge University to identify each photo against a database of previously identified individuals. If new turtles are discovered then you get to name your new turtle. The information that this research gathers is vital for conservation measures as we will be able to identify population numbers of male and female turtles, identify hotspots where conservation efforts need to be focused and also movement patterns of the turtles. The data will then be used by decision makers to design the Marine Park Zonation Plan."
            });

            items_PTP.Add(new HTGH()
            {
                Title = "Turtle watch",
                Image2 = Resource.Drawable.PTP_act_4,
                Description = "You will help to collect non-invasive photos of nesting sea turtles at beaches around the Perhentian Islands. The photos that you collect will help our researchers to establish nesting patterns of sea turtles in the Perhentian Islands. Additionally, unfortunately poachers still occasionally collect eggs from the beaches around the islands. The government staff travel around the islands but they are sometimes too late and poachers have already taken the eggs. Your role is to guard the beach and when a turtle comes to nest inform the government official who will then collect the eggs and safely protect them in their official hatchery. We established a similar programme at another turtle nesting beach in the islands and just the presence of people on the beaches often deterred poachers from landing on the beach. The initial project with Bubbles is still ongoing, so your presence will ensure more that 2 turtle nesting beaches are protected in the Perhentian islands."
            });

            ListViewAdapter_HTGH adapter = new ListViewAdapter_HTGH(this, items_PTP);

            ListView_PTP.Adapter = adapter;

            var PTP_moreInfo = FindViewById<LinearLayout>(Resource.Id.PTP_Act_moreInfo);
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