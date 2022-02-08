using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

using static AccessibilityTesting.DeepLinkTest.Navigation;
using static AccessibilityTesting.DeepLinkTest.StartTrip;

namespace AccessibilityTesting.DeepLinkTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeepLinkPage : ContentPage
    {
        public DeepLinkPage()
        {
            InitializeComponent();
        }

        async private void NavigationButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(">>NaivgaiontButton_Clicked");
            await Launcher.TryOpenAsync(getNavigationString(LatitudeEntry.Text, LongitudeEntry.Text));
        }

        async private void SelectTripButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(">>SelectTripButton_Clicked");
            await Launcher.TryOpenAsync(getStartTripLink(RiderIDEntry.Text, RiderNameEntry.Text));
        }
    }
}