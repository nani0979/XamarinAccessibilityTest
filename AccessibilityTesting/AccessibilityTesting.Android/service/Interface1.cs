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

[assembly: Xamarin.Forms.Dependency(typeof(IAccessibilityManager))]
namespace AccessibilityTesting.Droid.service
{
    public class AndroidAccessibilityManager : IAccessibilityManager
    { ///
      /// Announces the accessibility text passed based on the TalkBack or screen reader enabled. ///
      /// The text to speak/announce 
        public void AnnounceAccessibility(string speakText)
        {
            AccessibilityManager manager = (AccessibilityManager)Android.App.Application.Context.GetSystemService(Android.App.Application.AccessibilityService);
            if (!(manager.IsEnabled || manager.IsTouchExplorationEnabled))
                return;

            // Sends the accessibility event to announce.
            AccessibilityEvent e = AccessibilityEvent.Obtain();
            e.EventType = EventTypes.Announcement;
            e.Text.Add(new Java.Lang.String(speakText));
            manager.SendAccessibilityEvent(e);
        }
    }
}