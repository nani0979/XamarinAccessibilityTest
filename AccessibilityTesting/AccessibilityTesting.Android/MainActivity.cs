using Android;
using Android.App;
using Android.Content.PM;
using Android.Content;
using Android.OS;
using System;
using System.Linq;
using AndroidX.AppCompat.App;
using AndroidX.Core.Content;
using AndroidX.Core.App;
using Android.Runtime;

namespace AccessibilityTesting.Droid
{
    [IntentFilter(new[] { Intent.ActionView }, DataScheme = "WheresMyRide", DataHost = "Notify_WMR_no_Docking_Beacon", Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable })]
    [IntentFilter(new[] { Intent.ActionView }, DataScheme = "WheresMyRide", DataHost = "Notify_WMR_of_User_Onboard", Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable })]
    [IntentFilter(new[] { Intent.ActionView }, DataScheme = "WheresMyRide", DataHost = "Notify_WMR_of_SIG_Unavailable", Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable })]
    [Activity(Label = "AccessibilityTesting", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}