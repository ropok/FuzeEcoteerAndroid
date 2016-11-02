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
    class ListViewAdapter_MD : BaseAdapter<MD>
    {
        public List<MD> mItems;
        private Context mContext;

        public ListViewAdapter_MD(Context context, List<MD> items)
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

        public override MD this[int position]
        {
            get { return mItems[position];  }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListItem_MD, null, false);
            }

            TextView inEnglish = row.FindViewById<TextView>(Resource.Id.inEnglish);
            inEnglish.Text = mItems[position].English;

            TextView inMalay = row.FindViewById<TextView>(Resource.Id.inMalay);
            inMalay.Text = mItems[position].Malay;

            TextView inSay = row.FindViewById<TextView>(Resource.Id.inSay);
            inSay.Text = mItems[position].Say;

            return row;
        }
    }
}