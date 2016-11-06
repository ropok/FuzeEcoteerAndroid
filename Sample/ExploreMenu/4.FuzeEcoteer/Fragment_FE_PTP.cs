using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Sample
{
    public class Fragment_FE_PTP : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_FE_PTP, container, false);

            return view;
        }
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            #region buttonMenu
            var PTP_SubmiTurtlePhotos = Activity.FindViewById<LinearLayout>(Resource.Id.PTP_1);
            var PTP_Intro = Activity.FindViewById<LinearLayout>(Resource.Id.PTP_2);
            var PTP_Act = Activity.FindViewById<LinearLayout>(Resource.Id.PTP_3);
            var PTP_moreInfo = Activity.FindViewById<LinearLayout>(Resource.Id.PTP_4);

            PTP_SubmiTurtlePhotos.Click += PTP_SubmiTurtlePhotos_Click;
            PTP_Intro.Click += PTP_Intro_Click;
            PTP_Act.Click += PTP_Act_Click;
            PTP_moreInfo.Click += PTP_moreInfo_Click;
            #endregion
        }

        private void PTP_moreInfo_Click(object sender, System.EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://ecoteerresponsibletravel.com/portfolio/turtleconservationperhentianisland/");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void PTP_Act_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(PTP_Activities)));
        }

        private void PTP_Intro_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(PTP_Introduction)));
        }

        private void PTP_SubmiTurtlePhotos_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(PTP_SubmitTurtlePhotos)));
        }

    }
}