using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MPR_Rules : Android.Support.V4.App.Fragment
    {
        private List<FD> items_MPR_Rules;
        private ListView ListView_MPR_Rules;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_MPR_Rules, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_MPR_Rules = Activity.FindViewById<ListView>(Resource.Id.ListView_MPR_Rules);

            items_MPR_Rules = new List<FD>();


            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_1,
                Title = "No Collecting of Live or Dead Marine Life",
                Description = "Using your hand, dive or muck sticks, knives or anything else to move or to come into contact with corals and other marine fauna can cause damage, kill it or may even be illegal.",
                manyMore = "\nJust let them wild and free"
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_2,
                Title = "No Fish Feeding",
                Description = "Feeding the fishes is not encouraged because it changes their behaviour.\n\nThat is the reason why when you go into the sea, fishes come around and try to nibble you because they start to associate humans with food.",
                manyMore = "\nBread is not natural food for the fish and feeding changes their behaviour."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_3,
                Title = "No Anchoring on Coral Reef",
                Description = "Anchors are heavy and often have a long chain attached. When dropped onto a fragile coral or even seagrass beds, it causes sigificant ecological damage.",
                manyMore = "\nCorals also extremely fragile."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_4,
                Title = "No Touching or Chasing Marine Life",
                Description = "Please do not harass the marine life, especially turtles but watch them from a distance so that you do not stress them out.\n\nTurtles are the majority of the time feeding on sea grass.\n\nTurtles need to surface to breathe every 3 hours but if disturbed or stressed they will surface within 20 minutes.\n\n",
                manyMore = "\nTurtles and fishes need to be live peacefully, give them space so you don’t stress them."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_5,
                Title = "No Stepping on Coral",
                Description = "Corals are actually living organisms. The hard corals take months/years to grow just a few centimeters.\n\nPlease keep your feet away from the corals so that you do not hurt yourself.\n\nThey are also extremely fragile and break very easily when you step on them.",
                manyMore = "\nThe hard corals take months/years to grow just a few centimeters.\nThey are also extremely fragile."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_6,
                Title = "No Fishing",
                Description = "It can harras the marine life, it may cause damage even kill them",
                manyMore = "\n"
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_7,
                Title = "No Littering",
                Description = "Please always bring your trash, such as water, plastic bags etc, with you.\n\nMarine life is not as smart as humans,a prime example of this is turtles with consume the plastic bag, assuming it is a jellyfish.If you swallow a plastic bag, you could get it removed but it is not the same for marine animals.",
                manyMore = "\nFish and turtles mistake trash for food and can die from eating it."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_8,
                Title = "Wear Life Jacket",
                Description = "You are encouraged to wear a life jacket when you snorkel as it is important for your safety and it keeps you afloat when you get tired.\n\nMore importantly by having a life jacket on your boatman or passing boats can see you from afar.\n\nThere have been cases of snorkelers being hit by a propeller as they have not been seen by the boat.\n\nIf you are a confident swimmer and do not want to wear a life jacket we recommend that you still take one just make sure you close it and tie it around you.",
                manyMore = "\nWearing a life jacket makes it easier for the boat drivers to see you."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_9,
                Title = "Water Activities in Designated Area",
                Description = "",
                manyMore = "\n"
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_10,
                Title = "Volunteer to Help Environment",
                Description = "",
                manyMore = "\n"
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.CE_11,
                Title = "Support Marine Parks by Paying Conservation fees",
                Description = "",
                manyMore = "\n"
            });
            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_MPR_Rules);

            ListView_MPR_Rules.Adapter = adapter;
        }
    }
}

//items_FD.Add(new FD() { Image = Resource.Drawable, Title = "", Description = "" });