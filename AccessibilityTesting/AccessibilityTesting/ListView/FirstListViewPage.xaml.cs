using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessibilityTesting.ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstListViewPage : ContentPage
    {
        public List<string> _items;
        public FirstListViewPage()
        {
            InitializeComponent();
            _items = new List<string>();
            _items.Add("項目一");
            _items.Add("項目二");
            lv1.ItemsSource = _items;
            lv2.ItemsSource = _items;
            lv3.ItemsSource = _items;
            lv4.ItemsSource = _items;
            lv5.ItemsSource = _items;
            lv6.ItemsSource = _items;
            lv7.ItemsSource = _items;
            lv8.ItemsSource = _items;
            lv1.ItemsSource = _items;
        }
    }
}