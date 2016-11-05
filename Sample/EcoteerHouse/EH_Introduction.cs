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
    [Activity(Label = "Ecoteer House - Introduction", ParentActivity = typeof(activity_FuzeEcoteer))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "activity_FuzeEcoteer")]
    public class EH_Introduction : AppCompatActivity
    {
        private List<FD> items_EH;
        private ListView ListView_EH;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.EH_Introduction);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarEH_Introduction);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            ListView_EH = FindViewById<ListView>(Resource.Id.ListView_EH_Introduction);
            items_EH = new List<FD>();
            items_EH.Add(new FD()
            {
                Title = "“Inspired in Malaysia, Made in Malaysia!.”",
                Description = "Ecoteer Responsible Travel is a brand under Blue Forest Travel (travel license KPL4863) and  started in 2010 through the growing need for more support for the projects based in Asia associated with Ecoteer.com and the creation of the Turtle and Community project on the Perhentian Islands.  Some of the grass root projects on Ecoteer.com were unable either to financially support themselves or lacked the man power and sought Ecoteer’s help to continue or improve their work.  Ecoteer Responsible Travel was then formed to help concentrate resources to develop meaningful volunteer and ecotourism experiences which could help solve the specific issues for each project.\n\nEcoteer has since developed 4 project sites in Malaysia and Indonesia. Ecoteer establishes project sites working alongside local communities and/or NGO’s to create mutually beneficial outcomes. At each project site Ecoteer has offered education and alternative sources of income for the local communities whom are attached to a project site, with up to 35% of volunteer fees being given to them for services rendered. The Ecoteer programmes also provide donations and manpower to the NGO’s that they work with for example MYCAT and Save the Caves of Merapoh. The Ecoteer project sites are all run to the same business model – Self-sustainable projects funded by voluntourism, school groups and corporate programmes."
            });

            items_EH.Add(new FD()
            {
                Title = "Aim",
                Description = "To provide tourism experiences that bring the most possible benefits to the host communities and the environment which surrounds them."
            });

            items_EH.Add(new FD()
            {
                Title = "Principles",
                Description = "Humble but confident\nWe listen to everyone, most of our mini projects are from feedback and ideas we have received from volunteers and villagers, an example of this are the Malays Dinners which now run at all our project sites. Listening is vital to us and then we take action, however we are confident we are going in the right direction as we host ecotourism students from University Technology Malaysia who conduct annual external assessments of the impacts of our projects. We use external auditors because they will be neutral or even looking for negative aspects in our work. Negatives are what makes us stronger, positives are just for the ego.\n\nCaring\nWe care about the environment, the local communities we work with and of course our guests. We always strive to do our best and more.\n\nImpactful and with a bite\nAfter the success of our small scale projects Ecoteer has been asked to play a significant role in developing Perhentian into a top Ecotourism destination. This a huge honour and a sign of respect that we are gaining from decision makers in the Perhentian Islands."
            });

            items_EH.Add(new FD()
            {
                Title = "Responsible Tourism",
                Description = "As our name suggest we are a Responsible Travel Company, or at least a travel company that aspires to be as responsible as possible. Responsible Tourism to us means that we look after the environment, people, culture, our staff, our accounts and of course our tourists. In general being Responsible means we provide as many benefits as possible to all parties.\n\nWe know we are not the best in responsible tourism, at the moment, and we will never reach being 100% responsible as it doesn’t exist but if you reach for the stars and land on the moon the view is not so bad.\n\nWe have decided to adopt the United Nation’s World Tourism Organisation’s GLOBAL SUSTAINABLE TOURISM CRITERIA, which provides a holistic framework for responsible tourism (see http://www.sustainabletourismcriteria.org/). The checklists the UN have created will be used as the tool to help us measure our improvements, highlight areas where improvement is needed and to communicate our efforts to travellers and relevant communities."
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this, items_EH);

            ListView_EH.Adapter = adapter;
            
        }
    }
}