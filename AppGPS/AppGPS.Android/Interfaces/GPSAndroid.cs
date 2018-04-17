using Android.Content;
using Android.Locations;
using AppGPS.Droid.Interfaces;
using AppGPS.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(GPSAndroid))]
namespace AppGPS.Droid.Interfaces
{
    public class GPSAndroid : IGPSAndroid
    {
        public void CheckGPSEnabled()
        {
            //Xamarin.Forms.Forms.Context.StartActivity(new Android.Content.Intent(Android.Provider.Settings.ActionLocationSourceSettings));

            LocationManager locManager = (LocationManager)Xamarin.Forms.Forms.Context.GetSystemService(Context.LocationService);
            var gpsEnabled = locManager.IsProviderEnabled(LocationManager.GpsProvider);

            if (!gpsEnabled)
            {
                Intent intentGps = new Intent(Android.Provider.Settings.ActionLocationSourceSettings);
                Xamarin.Forms.Forms.Context.StartActivity(intentGps);
            }
        }
    }
}