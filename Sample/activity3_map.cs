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

            LatLng latlng = new LatLng(5.8984843, 102.7295039);
            CameraUpdate camera = CameraUpdateFactory.NewLatLngZoom(latlng, 15);
            GMap.MoveCamera(camera);

            MarkerOptions KermaLaut = new MarkerOptions()
                .SetPosition(new LatLng(5.936024, 102.727884))
                .SetTitle("Kerma Laut")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));

            MarkerOptions DLagoon = new MarkerOptions()
                .SetPosition(new LatLng(5.933502, 102.723344))
                .SetTitle("D'Lagoon")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));

            MarkerOptions VietnameseWreck = new MarkerOptions()
                .SetPosition(new LatLng(5.894785, 102.706959))
                .SetTitle("Vietnamese Wreck")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));

            MarkerOptions SeaBell = new MarkerOptions()
                .SetPosition(new LatLng(5.915101, 102.709627))
                .SetTitle("Sea Bell")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));

            MarkerOptions TokongLaut = new MarkerOptions()
                .SetPosition(new LatLng(5.961193, 102.659695))
                .SetTitle("Tokong Laut")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));

            MarkerOptions RawaIsland = new MarkerOptions()
                .SetPosition(new LatLng(5.958342, 102.678229))
                .SetTitle("Rawa Island")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));

            MarkerOptions BatuNisan = new MarkerOptions()
                .SetPosition(new LatLng(5.922904, 102.728974))
                .SetTitle("Batu Nisan")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));

            MarkerOptions BatuLayar = new MarkerOptions()
                .SetPosition(new LatLng(5.911266, 102.743233))
                .SetTitle("Batu Layar")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));

            MarkerOptions PolisWreck = new MarkerOptions()
                .SetPosition(new LatLng(5.913216, 102.750569))
                .SetTitle("Polis Wreck")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));
            
            MarkerOptions TanjungBasi= new MarkerOptions()
                .SetPosition(new LatLng(5.928740, 102.759821))
                .SetTitle("TanjungBasi")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));
            
            MarkerOptions T3 = new MarkerOptions()
                .SetPosition(new LatLng(5.902527, 102.771217))
                .SetTitle("T3")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));
            
            MarkerOptions Bubbles = new MarkerOptions()
                .SetPosition(new LatLng(5.883549, 102.765599))
                .SetTitle("Bubbles")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));
            
            MarkerOptions SharkPoint = new MarkerOptions()
                .SetPosition(new LatLng(5.881629, 102.746220))
                .SetTitle("SharkPoint")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));
            
            MarkerOptions TelukKeke = new MarkerOptions()
                .SetPosition(new LatLng(5.885498, 102.737559))
                .SetTitle("Teluk Keke")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag)); 

            MarkerOptions SugarWreck = new MarkerOptions()
                .SetPosition(new LatLng(5.891, 102.6))
                .SetTitle("Sugar Wreck")
                .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.diving_flag));


            GMap.AddMarker(KermaLaut);
            GMap.AddMarker(DLagoon);
            GMap.AddMarker(VietnameseWreck);
            GMap.AddMarker(SeaBell);
            GMap.AddMarker(TokongLaut);
            GMap.AddMarker(RawaIsland);
            GMap.AddMarker(BatuNisan);
            GMap.AddMarker(BatuLayar);
            GMap.AddMarker(PolisWreck);
            GMap.AddMarker(TanjungBasi);
            GMap.AddMarker(T3);
            GMap.AddMarker(Bubbles);
            GMap.AddMarker(SharkPoint);
            GMap.AddMarker(TelukKeke);
            GMap.AddMarker(SugarWreck);

        }
    }
}