
using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Widget;
using Java.IO;
using Environment = Android.OS.Environment;
using Uri = Android.Net.Uri;

namespace Sample
{
    public static class App
    {
        public static File _file;
        public static File _dir;
        public static Bitmap bitmap;
    }
    [Activity(Label = "activity_Report")]
    public class activity_Report : Activity
    {
        private ImageView _imageView;
        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            // Make it available in the galerry

            Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
            Uri contentUri = Uri.FromFile(App._file);
            mediaScanIntent.SetData(contentUri);
            SendBroadcast(mediaScanIntent);

            // Display in ImageView. We will resize the bitmap to fit the display
            // Loading the full sized image will consume to much memory 
            // and cause the application to crash.
            int height = Resources.DisplayMetrics.HeightPixels;
            int width = _imageView.Height;
            App.bitmap = App._file.Path.LoadAndResizeBitmap(width, height);
            if (App.bitmap != null)
            {
                _imageView.SetImageBitmap(App.bitmap);
                App.bitmap = null;
            }
            GC.Collect();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_ReportCamera);   
            // Create your application here
            if (IsThereAnAppToTakePictures())
            {
                CreateDirectoryForPictures();
                Button button = FindViewById<Button>(Resource.Id.takePhotoButton);
                _imageView = FindViewById<ImageView>(Resource.Id.imageViewCam);
                button.Click += TakeAPicture;
            }

        }

        private void CreateDirectoryForPictures()
        {
            App._dir = new File(Environment.GetExternalStoragePublicDirectory(Environment.DirectoryPictures), "CameraFuzeEcoteer");
            if (!App._dir.Exists())
            {
                App._dir.Mkdirs();
            }
        }

        private bool IsThereAnAppToTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null & availableActivities.Count > 0;
        }

        private void TakeAPicture (object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);

            App._file = new File(App._dir, String.Format("Photo_{0}.jpg", Guid.NewGuid()));

            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(App._file));

            StartActivityForResult(intent, 0);
        }
    }
}