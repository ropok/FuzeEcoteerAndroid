using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_CW_3 : Android.Support.V4.App.Fragment
    {
        private List<FD> items_CW;
        private ListView ListView_CW;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_CW_3, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_CW = Activity.FindViewById<ListView>(Resource.Id.ListView_CW3);

            items_CW = new List<FD>();

            items_CW.Add(new FD()
            {
                Title = "1. Only survey 4 types – branching, plate/table, boulder and soft",
            });

            items_CW.Add(new FD()
            {
                Title = "2. The lightest and darkest colour of the corals must be from the same range",
            });

            items_CW.Add(new FD()
            {
                Title = "3. If the colour doesn’t match the chart, do not survey the coral",
            });

            items_CW.Add(new FD()
            {
                Title = "4. Keep it simple, simply choose the closest coral type",
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_CW);

            ListView_CW.Adapter = adapter;

        }
    }
}