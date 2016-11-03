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
    class ListViewAdapter_FD : BaseAdapter<FD>
    {
        public List<FD> mItems;
        private Context mContext;

        public ListViewAdapter_FD(Context context, List<FD> items)
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

        public override FD this[int position]
        {
            get { return mItems[position];  }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListItem_FD, null, false);
            }

            TextView inTitle = row.FindViewById<TextView>(Resource.Id.inTitle);
            inTitle.Text = mItems[position].Title;

            TextView inDescription = row.FindViewById<TextView>(Resource.Id.inDescription);
            inDescription.Text = mItems[position].Description;

            TextView inPrice = row.FindViewById<TextView>(Resource.Id.inPrice);
            inPrice.Text = mItems[position].Price;

            ImageView inImage = row.FindViewById<ImageView>(Resource.Id.inImage);
            inImage.SetImageResource(mItems[position].Image);

            return row;
        }
    }
}