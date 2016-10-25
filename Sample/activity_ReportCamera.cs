using System;

using Android;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Util;
using Android.Support.V4.App;
using Java.Interop;
using Android.Provider;
using Android.Graphics;
using Android.Support.Design.Widget;

namespace Sample
{
    [Activity(Label = "activity_ReportCamera")]
    public class activity_ReportCamera : Activity, ActivityCompat.IOnRequestPermissionsResultCallback
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
        public void ShowCamera ()
        {
            if (ActivityCompat.CheckSelfPermission(this, Manifest.Permission.Camera) != (int)Permission.Granted)
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
            if (ActivityCompat.ShouldShowRequestPermissionRationale(this, Manifest.Permission.Camera))
            {
                Snackbar.Make(layout, Resource.String.permission_camera_rationale,
                    Snackbar.LengthIndefinite).SetAction(Resource.String.ok, new Action<View>(delegate (View obj)
                   {
                       ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.Camera }, REQUEST_CAMERA);
                   })).Show();
            }
            else
            {
                ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.Camera }, REQUEST_CAMERA);
            }
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_ReportCamera);

            // Create your application here
            imageView = FindViewById<ImageView>(Resource.Id.imageViewCam);
            ShowCamera();
        }
        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            Bitmap bitmap = (Bitmap)data.Extras.Get("data");
                if(imageView != null)
                {

                    imageView.SetImageBitmap(bitmap);
                }
        }
    }

}