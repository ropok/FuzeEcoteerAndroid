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
    public class MM_Info : AppCompatActivity
    {
        private List<FD> items_MM;
        private ListView ListView_MM;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MM_Info);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarMM_Info);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            ListView_MM = FindViewById<ListView>(Resource.Id.ListView_MM_Info);
            items_MM = new List<FD>();
            items_MM.Add(new FD()
            {
                Title = "Developed by",
                Description = "Fuze Ecoteer Outdoor Adventures Sdn Bhd"
            });

            items_MM.Add(new FD()
            {
                Title = "Release Update",
                Description = "\n1.0.0\n\nFirst version",
            });
            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this, items_MM);

            ListView_MM.Adapter = adapter;
        }

    }
}