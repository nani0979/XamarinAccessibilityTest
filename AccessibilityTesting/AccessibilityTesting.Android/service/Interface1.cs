using AccessibilityTesting.Interface;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Accessibility;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AccessibilityTesting.Droid.service;
[assembly: Xamarin.Forms.Dependency(typeof(AndroidAccessibilityManager))]
namespace AccessibilityTesting.Droid.service
{
    public class AndroidAccessibilityManager : IAccessibilityManager
    { 
        ///
      /// Announces the accessibility text passed based on the TalkBack or screen reader enabled. ///
      /// The text to speak/announce 
      /// 
        public AndroidAccessibilityManager() 
        {
            Console.WriteLine(">>Android AccessibilityManager");
        }

        private AccessibilityManager _manager = (AccessibilityManager)Application.Context.GetSystemService(Android.App.Application.AccessibilityService);
        public void AnnounceAccessibility(string speakText)
        {
            if (!(_manager.IsEnabled || _manager.IsTouchExplorationEnabled))
                return;

            // Sends the accessibility event to announce.
            AccessibilityEvent e = AccessibilityEvent.Obtain();
            e.EventType = EventTypes.Announcement;
            e.Text.Add(new Java.Lang.String(speakText));            
            _manager.SendAccessibilityEvent(e);
        }
    }
}