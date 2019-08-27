using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Util;

namespace Week2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Log.Debug("Lab2", "Activity A - OnCreate");
        }
        protected override void OnDestroy()
        {
            Log.Debug("Lab2", "Activity A - OnDestroy");
            base.OnDestroy();
        }
        protected override void OnPause()
        {
            Log.Debug("Lab2", "Activity A - OnDestroy");
            base.OnPause();
        }
        protected override void OnRestart()
        {
            Log.Debug("Lab2", "Activity A - OnDestroy");
            base.OnRestart();
        }
        protected override void OnResume()
        {
            Log.Debug("Lab2", "Activity A - OnDestroy");
            base.OnResume();
        }
        protected override void OnStart()
        {
            Log.Debug("Lab2", "Activity A - OnDestroy");
            base.OnStart();
        }
        protected override void OnStop()
        {
            Log.Debug("Lab2", "Activity A - OnDestroy");
            base.OnStop();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        
    }
}