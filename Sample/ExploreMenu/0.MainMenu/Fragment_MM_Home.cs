using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Sample
{
    public class Fragment_MM_Home : Android.Support.V4.App.Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.Fragment_MM_Home, null);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            #region buttonMenu
            var menu_Intro = Activity.FindViewById<LinearLayout>(Resource.Id.MainMenu_Introduction);
            var menu_LW = Activity.FindViewById<LinearLayout>(Resource.Id.MainMenu_LocalWildlife);

            menu_Intro.Click += Menu_Intro_Click;
            menu_LW.Click += Menu_LW_Click;
            #endregion
        }

        private void Menu_LW_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(activity_LW)));
        }

        private void Menu_Intro_Click(object sender, System.EventArgs e)
        {
            //StartActivity(new Intent(this.Context, typeof(activity_LW)));
        }
    }
}