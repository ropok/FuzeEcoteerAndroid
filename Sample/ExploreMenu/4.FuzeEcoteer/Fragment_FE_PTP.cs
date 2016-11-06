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

            PTP_SubmiTurtlePhotos.Click += PTP_SubmiTurtlePhotos_Click;
            #endregion
        }

        private void PTP_SubmiTurtlePhotos_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Intent(this.Context, typeof(PTP_SubmitTurtlePhotos)));
        }

    }
}