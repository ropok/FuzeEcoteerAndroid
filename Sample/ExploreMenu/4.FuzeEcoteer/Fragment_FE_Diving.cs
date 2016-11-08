using Android.Content;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace Sample
{
    public class Fragment_FE_Diving : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_FE_Diving, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            #region buttonMenu
            var menuDive_Introduction = Activity.FindViewById<LinearLayout>(Resource.Id.Dive_1);
            //var menuDive_Map = Activity.FindViewById<LinearLayout>(Resource.Id.Dive_2);
            var menuDive_Projects = Activity.FindViewById<LinearLayout>(Resource.Id.Dive_3);
            var menuDive_moreInfo = Activity.FindViewById<LinearLayout>(Resource.Id.Dive_4);

            menuDive_Introduction.Click += MenuDive_Introduction_Click;
            //menuDive_Map.Click += MenuDive_Map_Click;
            menuDive_Projects.Click += MenuDive_Projects_Click;
            menuDive_moreInfo.Click += MenuDive_moreInfo_Click;
            #endregion
        }

        private void MenuDive_moreInfo_Click(object sender, System.EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://www.bluetemple.co.uk/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void MenuDive_Projects_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(Dive_Projects)));
        }

        //private void MenuDive_Map_Click(object sender, System.EventArgs e)
        //{

        //    Fragment fragment = new Fragment_MM_Map();
            
        //}

        private void MenuDive_Introduction_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(Dive_Introduction)));
        }
    }
}