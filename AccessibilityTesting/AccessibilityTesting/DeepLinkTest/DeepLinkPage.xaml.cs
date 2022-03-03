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
using AccessibilityTesting.Interface;

namespace AccessibilityTesting.DeepLinkTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeepLinkPage : ContentPage
    {
        ILauncher launcher;
        public DeepLinkPage()
        {
            InitializeComponent();
            launcher = DependencyService.Get<ILauncher>();
        }

        async private void NavigationButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(">>NaivgaiontButton_Clicked");
            Console.WriteLine(getNavigationString(LatitudeEntry.Text, LongitudeEntry.Text));
            await Launcher.TryOpenAsync(getNavigationString(LatitudeEntry.Text, LongitudeEntry.Text));
        }

        async private void SelectTripButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(">>SelectTripButton_Clicked");
            await Launcher.TryOpenAsync(getStartTripLink(RiderIDEntry.Text, RiderNameEntry.Text));
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(">>1");
            Console.WriteLine(">> " + getStartTripLink("22", "333").ToString());
            bool aa = await launcher.Launcher(getStartTripLink("22","333").ToString());
            Console.WriteLine(aa);
            Console.WriteLine(">>2");
        }
    }
}