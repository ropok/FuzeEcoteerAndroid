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


            items_MPR_Rules.Add(new FD() {
                Image = Resource.Drawable.No_Touching_or_Chasing_Marine_Life,
                Title = "No Touching or Harassing Turtles",
                Description = "Turtles are the majority of the time feeding on sea grass.\n\nTurtles need to surface to breathe every 3 hours but if disturbed or stressed they will surface within 20 minutes.\n\nPlease do not harass the turtles but watch them from a distance so that you do not stress them out.",
                manyMore = "\nImagine if you are having your lunch, would you like it if strangers touch or harass you?"
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.No_Littering,
                Title = "No Littering",
                Description = "Please always bring your trash, such as water, plastic bags etc, with you after snorkel tour. \n\nMarine life is not as smart as humans,a prime example of this is turtles with consume the plastic bag, assuming it is a jellyfish.If you swallow a plastic bag, you could get it removed but it is not the same for marine animals.",
                manyMore = "\nThat is the reason why you find trash inside of animal’s guts."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.No_Feeding_Fish,
                Title = "No Feeding",
                Description = "Feeding the fishes is not encouraged because it changes their behaviour.\n\nThat is the reason why when you go into the sea, fishes come around and try to nibble you because they start to associate humans with food.",
                manyMore = "\nIt is not necessary to feed fishes or sharks because they are capable of finding their own food."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.wear_lifeJacket,
                Title = "Wear a Life Jacket & Swim within Designated Area",
                Description = "You are encouraged to wear a life jacket when you snorkel as it is important for your safety and it keeps you afloat when you get tired.\n\nMore importantly by having a life jacket on your boatman or passing boats can see you from afar.\n\nThere have been cases of snorkelers being hit by a propeller as they have not been seen by the boat.\n\nIf you are a confident swimmer and do not want to wear a life jacket we recommend that you still take one just make sure you close it and tie it around you.",
                manyMore = "\nBy having a life jacket on your boatman or passing boats can see you from afar.\nTherefore always swim within the buoyline because the boat drive fast past and around the buoyline."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.Do_not_Anchor_on_Coral_Reefs,
                Title = "No Touching or Stepping on Corals",
                Description = "Corals are actually living organisms. The hard corals take months/years to grow just a few centimeters.\n\nPlease keep your feet away from the corals so that you do not hurt yourself.\n\nThey are also extremely fragile and break very easily when you step on them.",
                manyMore = "\nThe hard corals take months/years to grow just a few centimeters.\nThey are also extremely fragile."
            });

            items_MPR_Rules.Add(new FD()
            {
                Image = Resource.Drawable.No_Stepping_on_Coral,
                Title = "No using Fins during Snorkeling",
                Description = "Only snorkel guides are trained and allowed to use when swimming as they are used for emergency purposes to swim faster to casualty or to bring a tourist back to the boat quickly.",
                manyMore = "\nAt times the corals are really shallow and by having fins on, you might accidentally kick the corals, especially if you are floating vertically in the sea."
            });

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_MPR_Rules);

            ListView_MPR_Rules.Adapter = adapter;
        }
    }
}

//items_FD.Add(new FD() { Image = Resource.Drawable, Title = "", Description = "" });