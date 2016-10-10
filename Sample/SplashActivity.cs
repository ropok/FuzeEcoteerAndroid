using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using Android.Util;
using System.Threading.Tasks;

namespace Sample
{
    [Activity(Label = "Fuze Ecoteer", Icon = "@drawable/splash_FuzeEcoteer", Theme = "@style/AppTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);

            // Create your application here
        }

        protected override void OnResume()
        {
            base.OnResume();

            Task startupWork = new Task(() =>
                                        {
                                            Task.Delay(5000);

                                        });
            startupWork.ContinueWith(t =>
                                        {
                                            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
                                        }, TaskScheduler.FromCurrentSynchronizationContext());

            startupWork.Start();
        }

    }
}