using System;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Sample
{
    public class Fragment_FE_EH : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_FE_EH, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            #region buttonMenu
            var menuEH_Introduction = Activity.FindViewById<LinearLayout>(Resource.Id.FE_1);
            var menuEH_Projects = Activity.FindViewById<LinearLayout>(Resource.Id.FE_2);
            var menuEH_Activities = Activity.FindViewById<LinearLayout>(Resource.Id.FE_3);
            var menuEH_moreInfo = Activity.FindViewById<LinearLayout>(Resource.Id.FE_4);
            
            menuEH_Introduction.Click += MenuEH_Introduction_Click;
            menuEH_Projects.Click += MenuEH_Projects_Click;
            menuEH_Activities.Click += MenuEH_Activities_Click;
            menuEH_moreInfo.Click += MenuEH_moreInfo_Click;
            #endregion
        }

        private void MenuEH_Activities_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(EH_Activities)));
        }

        private void MenuEH_Projects_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(EH_Projects)));
        }

        // Opening Browser App
        private void MenuEH_moreInfo_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://ecoteerresponsibletravel.com/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
        private void MenuEH_Introduction_Click(object sender, EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(EH_Introduction)));
        }
    }
}