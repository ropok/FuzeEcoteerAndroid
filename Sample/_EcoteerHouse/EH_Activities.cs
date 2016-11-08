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
    [Activity(Label = "Ecoteer House - Activiies", ParentActivity = typeof(activity_FuzeEcoteer))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "activity_FuzeEcoteer")]
    public class EH_Activities : AppCompatActivity
    {
        private List<FD> items_EH;
        private ListView ListView_EH;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EH_Activities);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarEH_Activities);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            ListView_EH = FindViewById<ListView>(Resource.Id.ListView_EH_Activities);
            items_EH = new List<FD>();
            items_EH.Add(new FD()
            {   Image = Resource.Drawable.EH_Act_1,
                Title = "School Clubs",
                Description = "We conduct English and Roots and shoots clubs each week for the children on the islands and are based at our house or other open spaces, we believe in classroom without walls. Help to prepare fun, educational activities and deliver these exciting sessions alongside our Fuze Ecoteer staff. The village kids are full of energy and enthusiasm and always excited to meet new volunteers!"
            });

            items_EH.Add(new FD()
            {   Image = Resource.Drawable.EH_Act_2,
                Title = "PILA",
                Description = "In 2012 Ecoteer initiated the Perhentian Islands Ladies Association (PILA) to engage local women in environmental issues whilst offering them a chance to increase their income. You can support these ladies by giving talks around the resorts and encouraging more tourists to attend the weekly ‘kuih’ making sessions to sample their delicious home-made snacks and cakes."
            });


            items_EH.Add(new FD()
            {
                Image = Resource.Drawable.EH_Act_3,
                Title = "Snorkeling",
                Description = "Each week you will go on a snorkel tour where you will see turtles, sharks numerous fish and beautiful coral reef. What better way to end a hard days work than by snorkeling in turquoise waters searching for Nemo and his friends!"
            });

            items_EH.Add(new FD()
            {
                Image = Resource.Drawable.EH_Act_4,
                Title = "Snorkel Breifings & Awareness",
                Description = "Damages to corals and harassment of marine life is highest for large groups of snorkellers. We have collaborated with the local snorkel guides and gather their snorkellers for a thorough interactive eco snorkel briefing before they go on the tours. The briefings are a great way to educate people about the damage they can cause and most people listen and learn to what we say. Sometimes we have 100 people we brief at once. We then conduct beach cleans and talk to tourists about how they can reduce their environmental impact."
            });

            items_EH.Add(new FD()
            {
                Image = Resource.Drawable.EH_Act_5,
                Title = "Malay Dinner",
                Description = "Prepare your taste-buds for a treat!. The village ladies will welcome you into their homes to share a traditional Malay dinner with their families – the perfect way to truly experience their way of life."
            });

            items_EH.Add(new FD()
            {
                Image = Resource.Drawable.EH_Act_6,
                Title = "Group Activities",
                Description = "During weeks with large groups of volunteers (20 or more) you may be involved in small construction projects such as mural painting, creating recycling bins, redecorating the school etc."
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this, items_EH);

            ListView_EH.Adapter = adapter;

            var EH_moreInfo = FindViewById<LinearLayout>(Resource.Id.EH_Activities_moreInfo);

            EH_moreInfo.Click += EH_moreInfo_Click;
            
        }

        private void EH_moreInfo_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://ecoteerresponsibletravel.com/portfolio/volunteermalaysia/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }


        //protected override void OnStop()
        //{
        //    base.OnStop();
        //}
    }
}