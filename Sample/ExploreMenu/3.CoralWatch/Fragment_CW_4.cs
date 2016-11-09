using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_CW_4 : Android.Support.V4.App.Fragment
    {
        private List<FD> items_CW;
        private ListView ListView_CW;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_CW_4, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_CW = Activity.FindViewById<ListView>(Resource.Id.ListView_CW4);

            items_CW = new List<FD>();

            items_CW.Add(new FD()
            {
                Title = "4 Types of Coral",
            }); 

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_type1
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_type2
            });

            items_CW.Add(new FD()
            {
                manyMore = "Examples"
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_Coral1_SoftCoral,
                Title = "Soft Coral (Sea Fan)"
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_Coral2_BranchingCoral,
                Title = "Branching Coral"
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_Coral3_BrainCoral,
                Title = "Brain Coral"
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_Coral4_PlateCoral,
                Title = "Plate Coral"
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_Coral5_BoulderCoral,
                Title = "Boulder Coral (Brain Coral)"
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_Coral6_BoulderCoral,
                Title = "Boulder Coral (Lobe Coral)"
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_Coral7_BoulderCoral,
                Title = "Boulder Coral (Lobe Coral)"
            });

            items_CW.Add(new FD()
            {
                Image = Resource.Drawable.CW4_Coral8_BranchingCoral,
                Title = "Branching Coral (Staghorn Coral)"
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_CW);

            ListView_CW.Adapter = adapter;
            

        }
    }
}