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

namespace Sample
{
    class ListViewAdapter_HTGH : BaseAdapter<HTGH>
    {
        public List<HTGH> mItems;
        private Context mContext;

        public ListViewAdapter_HTGH(Context context, List<HTGH> items)
        {
            mItems = items;
            mContext = context;
        }

        public override int Count
        {
            get { return mItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override HTGH this[int position]
        {
            get { return mItems[position];  }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListItem_HTGH, null, false);
            }


            TextView HTGH_Title = row.FindViewById<TextView>(Resource.Id.HTGH_Title);
            HTGH_Title.Text = mItems[position].Title;

            ImageView HTGH_Image1 = row.FindViewById<ImageView>(Resource.Id.HTGH_Image1);
            HTGH_Image1.SetImageResource(mItems[position].Image1);

            ImageView HTGH_Image2 = row.FindViewById<ImageView>(Resource.Id.HTGH_Image2);
            HTGH_Image2.SetImageResource(mItems[position].Image2);

            TextView HTGH_Description = row.FindViewById<TextView>(Resource.Id.HTGH_Description);
            HTGH_Description.Text = mItems[position].Description;

            TextView HTGH_Time = row.FindViewById<TextView>(Resource.Id.HTGH_Time);
            HTGH_Time.Text = mItems[position].Time;

            return row;
        }
    }
}