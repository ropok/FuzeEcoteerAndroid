using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Sample
{
    public class Fragment_MM_LocalWildlife : Android.Support.V4.App.Fragment
    {
        private List<FD> items_LW;
        private ListView ListView_LW;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            View view = inflater.Inflate(Resource.Layout.Fragment_LW_JungleLife, container, false);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            ListView_LW = Activity.FindViewById<ListView>(Resource.Id.ListView_LW_JungleLife);

            items_LW = new List<FD>();

            #region Mammals
            items_LW.Add(new FD()
            {
                Title = "MAMMALS",
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_FlyLemur,
                Title = "Colugo",
                Description = "Colugos are also commonly called “flying lemurs” they are however not related to the iconic lemurs of Madagascar. The Malayan Colugo is found on Perhentian Besar (big island), and can be seen hanging out in the trees near the large resorts. Colugos have a thin membrane of skin stretching from the tip of their tail, connecting to each limb, which is how they glide between trees."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_DLMonkey,
                Title = "Dusky Leaf Monkeys",
                Description = "Endemic to Perhentian Besar (big island), is a unique subspecies of Dusky Leaf Monkey. It is because of this isolation that the Dusky Leaf Monkeys of the Perhentians are so vulnerable to rapid development. Identify them by their grey fur which is only broken by white circles around their eyes, mouths and stomachs."
            });
            
            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_LongTailMacaque,
                Title = "Long Tailed Macaque",
                Description = "Within the Perhentians, these primates are only found on Kecil (small island). All Long Tailed Macaque’s living within the vicinity of people are prone to causing human-wildlife conflict, this is unfortunately the case on Perhentian Kecil. They have been known to raid campsites and put on aggressive displays to tourists. Always exercise caution around these primates."
            });
            #endregion

            #region Bird Life
            items_LW.Add(new FD()
            {
                Title = "BIRD LIFE",
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_whiteEagle,
                Title = "White Bellied Sea Eagles",
                Description = "The White Bellied Sea Eagle, prefer coastal habitats where fish are in abundance. They are very territorial and you are just as likely to see them in a pair as you are to spot a solitary individual. At the Perhentians you will easily spot them soaring over the water. If you are lucky, you will sight them hunting, performing dramatic dives into the sea."
            });
            
            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_PacificReefEgret,
                Title = "Pacific Reef-Egret",
                Description = "The Pacific Reef-Egret has two colour forms, some are a charcoal grey, whereas others are white. Their relatively short legs give them a notable hunched appearance when standing. Across the Perhentian islands, you may spot them standing on low rocks searching for their main source of food, fish."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_wihteRumpedSharma,
                Title = "White Rumped Sharma",
                Description = "The White Rumped Sharma is a beautiful bird, with a melodious song to match, identified by its strikingly long tail. These birds are often kept as pets due to their desirability, and you may see some caged up throughout the fishing village on Perhentian Kecil (small island). "
            });
            #endregion  

            #region Snakes
            items_LW.Add(new FD()
            {
                Title = "SNAKES",
            });
            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_Python,
                Title = "Reticulated Pythons",
                Description = "The reticulated Python is the largest species of snake on the Perhentian Islands, and poses obvious danger if encountered. You are however very unlikely to see one, as these snakes prefer to steer clear of people, and are often amongst the dense forest."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_pitviper,
                Title = "Wagler’s Pit Viper",
                Description = "Two heat sensing “pits” on either side of the Wagler’s Pit Vipers triangular head, allow it to sense its prey at night. These are venomous snakes, but our not known to be aggressive, sometimes spending days at a time on a single branch."
            });
            #endregion

            #region Lizards
            items_LW.Add(new FD()
            {
                Title = "LIZARDS",
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_Lizard,
                Title = "Water Monitor Lizard",
                Description = "On both Islands (big and small) you will find an abundance of these large lizards. They roam the forests as well as developed areas. They are mostly unsettled by human presence, but will scurry to a nearby hole if approached. "
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_JL_Tokay,
                Title = "Tokay Gecko",
                Description = "The Tokay Gecko earnt its name by its distinctive “to-kay” like call, which is easily audible around the fishing village on the small island of the Perhentians. These lizards are nocturnal so you will often hear this call through the night, and may even find a particularly sneaky individual in your accommodation."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_CloudedLizard,
                Title = "Clouded Monitor Lizard",
                Description = "The Clouded Monitor Lizards differ from their cousins, because of their speckled skin. These seem to be found on Perhentian Besar (big island) only, and like the Water Monitor Lizard, will flee if approached. All monitor lizards possess small amounts of venom, for killing small animals."
            });
            #endregion

            #region Fish
            items_LW.Add(new FD()
            {
                Title = "FISH"
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_BlackTipReefSharks,
                Title = "Blacktip Reef Shark",
                Description = "The Blacktip Reef Shark is the most commonly sighted shark of the Perhentian Islands. These are easily identified by the black tips on the end of their fins. These sharks hunt small fish around the shallows. Blacktip Reef Sharks, are easily scared by humans, and are very unlikely to attack unless provoked."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_TriggerFish,
                Title = "Titan Triggerfish",
                Description = "The Titan Triggerfish is the largest of its family and is probably the most likely danger you will encounter in the Perhentian waters. Though usually docile, if a female is protecting her nest, she may turn aggressive, so try to maintain a large distance."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_BlueSpottedStingray,
                Title = "Blue-Spotted Stingray",
                Description = "The Blue-Spotted Stingray can be distinguished by its striking, bright blue dots across the flat of its body. These Rays can be found while snorkelling and diving around the Perhentian islands, although they tend to prefer flat sand to coral reefs. Be careful where you step, as they are very quick to react."
            });


            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_NeedleFish,
                Title = "Needlefish",
                Description = "Needlefish are a common sight around the Perhentian islands, even from land. They can often be found swimming below boat jetties, hunting large schools of smaller fish. When looking at them from above, their scales seem to reflect light through the water., it is quite beautiful."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_GiantMorayEel,
                Title = "Giant Moray Eel",
                Description = "Giant Moray Eels can grow to above two metres, and weigh over 25kg. When snorkeling around the Perhentians, these giants are easy to spot if you peer into small holes where they like to hide away. You will find it harder to spot one swimming freely."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_BumpheadParrotFish,
                Title = "Bumphead Parrot Fish",
                Description = "This magnificent fish is very formidable looking, with the ability to grow to above 40kg. The BumpHead Parrot fish eats coral, so they are easy to find when snorkeling amongst the abundant coral of the Perhentians."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_PufferFish,
                Title = "Giant Pufferfish",
                Description = "Pufferfish are named, due to their capacity to inflate their scaleless skin, and the giant pufferfish can be found relatively easily when snorkelling around the Perhentians. It may be Exciting to see these fish puffed up, but this means they are stressed and frightened, so it is best to enjoy them in their normal state."
            });


            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_Clownfish,
                Title = "Clownfish",
                Description = "I’m sure you do not need to be reminded of how iconic these small orange fish are. Even the local village kids of Perhentian Kecil (small island), simply know them as “Nemo”. When snorkelling the area, they can be seen in small family groups, swimming amongst anemones."
            });


            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_greatBarracuda,
                Title = "Great Barracuda",
                Description = "An intimidating array of unevenly sized teeth, contained by a large mouth, make these elongated fish very intimidating. Attacks however are only ever documented in murky waters, where mistakes can be made. Fisherman from the Village of Perhentian Kecil (small island) take great pride in catching the Great Barracuda."
            });


            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_Turtle,
                Title = "Green Turtle",
                Description = "The green turtle is the largest and most common of the two turtles found around the Perhentian islands. You can often see these feeding on seagrass off of Perhentian Besar (big island). We ask you not to touch the turtles while they feed, as it stresses them and causes them to run out of air quicker."
            });


            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_ML_HawksBillTurtle,
                Title = "Hawksbill Turtle",
                Description = "Notably smaller than the green turtle, the Hawksbill is also harder to find in the Perhentian area. It is preferred if you avoid all physical contact with these turtles, as it shortens their swim time below surface, due to stress."
            });
            #endregion

            #region Coral
            items_LW.Add(new FD()
            {
                Title = "CORAL"
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_HardCoral,
                Title = "Hard Coral",
                Description = "Hard coral is the most abundant, across malaysia, as well as the Perhentian islands. Hard corals are known as “Reef Building Corals”, due to their ability to create hard foundation skeletons out of calcium carbonate."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_rockCoral,
                Title = "Rock Coral",
                Description = "Rock coral is the second most common type of coral across the Perhentian islands. It is easily mistaken to be a literal piece of rock, however it is important not to get confused and stand on these, ask a local boatman for advice."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_SoftCoral,
                Title = "Soft Coral",
                Description = "Soft coral comprises a much small percentage of the local reefs, though it is probably considered a more appealing attraction to tourists. It’s beautiful colouring is a sight to behold when snorkelling around the Perhentian islands."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_SpongeCoral,
                Title = "Sponge Coral",
                Description = "Despite its name, Sponge Coral is not a Sponge, it is all Coral. This beautiful coral is often extracted from Asiatic reefs and imported to the western world, to be used in the crafting of jewellery."
            });

            items_LW.Add(new FD()
            {
                Image = Resource.Drawable.WL_TreeCoral,
                Title = "Tree Coral",
                Description = "As you may have guessed, Tree Coral is named after its tree like branching pattern. Some species can be mistaken for urchins when snorkelling, and keen attention must be paid to avoid breaking them with a stray flipper."
            });
            #endregion

            ListViewAdapter_FD adapter = new ListViewAdapter_FD(this.Context, items_LW);

            ListView_LW.Adapter = adapter;
        }
    }
}

//items_FD.Add(new FD() { Image = Resource.Drawable, Title = "", Description = "" });
//items_FD.Add(new FD() { manyMore = "Many More !" });
