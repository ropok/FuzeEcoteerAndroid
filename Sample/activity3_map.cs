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
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

namespace Sample
{
    [Activity(Label = "activity3_map")]
    public class activity3_map : Activity, IOnMapReadyCallback
    {
        private GoogleMap GMap;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity3_map);
            SetUpMap();
        }

        private void SetUpMap()
        {
            if (GMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.googlemap).GetMapAsync(this);
            }
        }
        public void OnMapReady(GoogleMap googleMap)
        {
            this.GMap = googleMap;
            GMap.UiSettings.ZoomControlsEnabled = true;

            LatLng latlng = new LatLng(Convert.ToDouble(5.8984843), Convert.ToDouble(102.7295039));
            CameraUpdate camera = CameraUpdateFactory.NewLatLngZoom(latlng, 15);
            GMap.MoveCamera(camera);

            MarkerOptions options = new MarkerOptions()
                .SetPosition(latlng)
                .SetTitle("Chenanyang");

            GMap.AddMarker(options);
        }
    }
}