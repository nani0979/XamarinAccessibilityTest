using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessibilityTesting.Label
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstLabelPage : ContentPage
    {
        public FirstLabelPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondLabelPage());
        }
    }
}