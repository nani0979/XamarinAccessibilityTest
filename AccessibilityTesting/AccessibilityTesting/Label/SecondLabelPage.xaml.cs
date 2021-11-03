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
    public partial class SecondLabelPage : ContentPage
    {
        private string format = "";
        private bool _isStart;
        private int currentIndex = 0;
        public SecondLabelPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!_isStart)
                SetTimer();
        }

        private void SetTimer()
        {
            _isStart = true;
            Device.StartTimer(TimeSpan.FromSeconds(10), () =>
            {
                mLabel.Text = string.Format("Current index is : {0}", currentIndex);
                currentIndex++;
                return _isStart;
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _isStart = false;
        }
    }
}