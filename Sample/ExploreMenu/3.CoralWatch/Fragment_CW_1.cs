using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_CW_1 : Android.Support.V4.App.Fragment
    {
        private List<FD> items_CW;
        private ListView ListView_CW;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_CW_1, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_CW = Activity.FindViewById<ListView>(Resource.Id.ListView_CW1);

            items_CW = new List<FD>();

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW1_whatIs,
                Title = "What is Coral Watch",
                Description = "CoralWatch helps non-scientists around the globe understand and support effective reef management by using engaging tools that provide people with accessible information and hands-on-experience collecting scientific data about the health of corals using the Coral Health Chart.",
                manyMore = "This chart standardises changes in coral colours, and provides a simple way for people to quantify coral health and contribute to the CoralWatch global database."
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_CW);

            ListView_CW.Adapter = adapter;

            var CW_moreInfo = Activity.FindViewById<LinearLayout>(Resource.Id.CW1_moreInfo);

            CW_moreInfo.Click += CW_moreInfo_Click;

        }

        private void CW_moreInfo_Click(object sender, System.EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://coralwatch.org/web/guest/home1");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
    }
}