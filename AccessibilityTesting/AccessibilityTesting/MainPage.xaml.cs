using System;
using Xamarin.Forms;

using AccessibilityTesting.Button;
using AccessibilityTesting.Entry;
using AccessibilityTesting.Frame;
using AccessibilityTesting.Label;
using AccessibilityTesting.ListView;

namespace AccessibilityTesting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void ButtonPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstButtonPage());
        }

        async private void LabelPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstLabelPage());
        }

        async private void FramePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstFramePage());
        }

        async private void ListviewPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstListViewPage());
        }

        async private void EntryPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstEntryPage());
        }
    }
}
