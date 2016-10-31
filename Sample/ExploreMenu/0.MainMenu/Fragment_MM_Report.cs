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
using Android;
using Android.Runtime;
using Android.Content.PM;
using Android.Util;
using Android.Support.V4.App;
using Java.Interop;
using Android.Support.Design.Widget;
using System.IO;

namespace Sample
{
    public class Fragment_MM_Report : Android.Support.V4.App.Fragment
    {

        /**
     	* Id to identify a camera permission request.
     	*/
        static readonly int REQUEST_CAMERA = 0;
        /**
     	* Root of the layout of this Activity.
     	*/
        View layout;
        ImageView imageView;
        /**
        * Called when the 'show camera' button is clicked.
        * Callback is defined in resource layout definition.
        */
        [Export]
        public void ShowCamera()
        {
            if (ActivityCompat.CheckSelfPermission(this.Context, Manifest.Permission.Camera) != (int)Permission.Granted)
            {
                RequestCameraPermission();
            }
            else
            {
                // Camera start here
                Intent intent = new Intent(MediaStore.ActionImageCapture);
                StartActivityForResult(intent, 0);
            }
        }

        void RequestCameraPermission()
        {
            if (ActivityCompat.ShouldShowRequestPermissionRationale(this.Activity, Manifest.Permission.Camera))
            {
                Snackbar.Make(layout, Resource.String.permission_camera_rationale,
                    Snackbar.LengthIndefinite).SetAction(Resource.String.ok, new Action<View>(delegate (View obj)
                    {
                        ActivityCompat.RequestPermissions(this.Activity, new String[] { Manifest.Permission.Camera }, REQUEST_CAMERA);
                    })).Show();
            }
            else
            {
                ActivityCompat.RequestPermissions(this.Activity, new String[] { Manifest.Permission.Camera }, REQUEST_CAMERA);
            }
        }

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
            imageView = Activity.FindViewById<ImageView>(Resource.Id.imageViewCam);

            btnCamera.Click += BtnCamera_Click;
        }
        private void BtnCamera_Click(object sender, EventArgs e)
        {
            //ShowCamera();

            StartActivity(new Intent(this.Context, typeof(activity_Report)));
        }
        
        public override void OnActivityResult(int requestCode, int resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            Bitmap bitmap = (Bitmap)data.Extras.Get("data");
            if (imageView != null)
            {
                imageView.SetImageBitmap(bitmap);
            }
        }


    }
}



