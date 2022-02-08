using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AccessibilityTesting.ModelTest;
using AccessibilityTesting.DeepLinkTest;
namespace AccessibilityTesting
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DeepLinkPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
