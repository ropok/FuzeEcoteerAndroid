using Android.App;
using Android.OS;
using Android.Views;
using System;
using System.Threading.Tasks;
using Xamarin.Media;
using Android.Content;
using Android.Widget;
using Android.Provider;
using Android.Graphics;

namespace Sample
{
    public class Fragment_MM_Report : Android.Support.V4.App.Fragment
    {

        ImageView imageView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.Fragment_MM_Report, null);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            var btnCamera = Activity.FindViewById<Button>(Resource.Id.takePhotoButton);
            //imageView = Activity.FindViewById<ImageView>(Resource.Id.imageViewCam);

            btnCamera.Click += BtnCamera_Click;
        }
        private void BtnCamera_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(activity_ReportCamera)));
        }
    }
}



