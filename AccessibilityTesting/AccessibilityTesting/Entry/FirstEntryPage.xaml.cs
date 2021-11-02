using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessibilityTesting.Entry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstEntryPage : ContentPage
    {
        public FirstEntryPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondEntryPage());
        }
    }
}