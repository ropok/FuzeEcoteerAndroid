using Android.Support.V4.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Widget;

namespace Sample
{
    public class Fragment_MarineParkRules : Fragment
    {
        private int position;
        public static Fragment_MarineParkRules NewInstance(int position)
        {
            var f = new Fragment_MarineParkRules();
            var b = new Bundle();
            b.PutInt("position", position);
            f.Arguments = b;
            return f;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            position = Arguments.GetInt("position");
            // Create your fragment here
        }

        public override Android.Views.View OnCreateView (Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState)
        {
            var root = inflater.Inflate(Resource.Layout.MarineParkRules_fragment_card, container, false);
            //var text = root.FindViewById<TextView>(Resource.Id.textView);
            //text.Text = "kartu: " + position;
            ViewCompat.SetElevation(root, 50);
            return root;
        }
        //public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        //{
        //    // Use this to return your custom view for this Fragment
        //    // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

        //    return base.OnCreateView(inflater, container, savedInstanceState);
        //}
    }
}