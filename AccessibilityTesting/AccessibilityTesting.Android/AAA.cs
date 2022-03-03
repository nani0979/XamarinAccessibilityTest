using AccessibilityTesting.Droid;
using AccessibilityTesting.Interface;
using Android.Content;
using Android.Content.PM;

using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(AAA))]
namespace AccessibilityTesting.Droid
{
    public class AAA : ILauncher
    {
        public Task<bool> Launcher(string url)
        {
            var mContext = Android.App.Application.Context;
            Intent browserIntent2 = new Intent(Intent.ActionView, Android.Net.Uri.Parse(url));
            browserIntent2.SetFlags(ActivityFlags.NewTask);

            try
            {
                mContext.StartActivity(browserIntent2);
            }
            catch
            {
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }

        private bool IsAppInstalled(string packageName)
        {
            PackageManager pm = Android.App.Application.Context.PackageManager;
            bool installed = false;
            try
            {
                pm.GetPackageInfo(packageName, PackageInfoFlags.Activities);
                installed = true;
            }
            catch (PackageManager.NameNotFoundException e)
            {
                installed = false;
            }

            return installed;
        }
    }
}