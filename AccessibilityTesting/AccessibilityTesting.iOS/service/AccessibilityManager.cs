using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using AccessibilityTesting.iOS.service;
using AccessibilityTesting.Interface;

[assembly: Dependency(typeof(IOSAccessibilityManager))]
namespace AccessibilityTesting.iOS.service
{
    public class IOSAccessibilityManager : IAccessibilityManager
    {
        public IOSAccessibilityManager() { }

        public void AnnounceAccessibility(string speakText)
        {
            if (!UIAccessibility.IsVoiceOverRunning) return;
            // Post notification to announce the accessibility text.
            UIAccessibility.PostNotification(UIAccessibilityPostNotification.Announcement, new NSString(speakText));
        }
    }
}

///

/// iOS accessibility manager class. Handles the accessibility related /// operations in the iOS native. ///
public class IosAccessibilityManager : IAccessibilityManager
{ ///
  /// Announces the accessibility text passed based on the VoiceOver is enabled. ///
  /// The text to speak/announce 
  /// 
  /// 
  /// 
  /// 
  /// 
 public void AnnounceAccessibility(string speakText) { if (!UIAccessibility.IsVoiceOverRunning) return;
    // Post notification to announce the accessibility text.
    UIAccessibility.PostNotification(UIAccessibilityPostNotification.Announcement, new NSString(speakText));
    }
}
