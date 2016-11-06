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
    [Activity(Label = "PTP - Submit Turtle Photos", ParentActivity = typeof(activity_FuzeEcoteer))]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "activity_FuzeEcoteer")]
    public class PTP_SubmitTurtlePhotos : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PTP_SubmitTurtlePhotos);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbarPTP_Submit);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);



            var PTP_facebook = FindViewById<LinearLayout>(Resource.Id.PTP_submitFacebook);
            var PTP_instagram = FindViewById<LinearLayout>(Resource.Id.PTP_submitInstagram);

            PTP_facebook.Click += PTP_facebook_Click;
            PTP_instagram.Click += PTP_instagram_Click;
            
        }

        private void PTP_instagram_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://www.instagram.com/perhentianturtleproject/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void PTP_facebook_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://www.facebook.com/perhentianturtleproject/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
    }
}