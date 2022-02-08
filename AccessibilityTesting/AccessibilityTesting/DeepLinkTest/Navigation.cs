using System;
using System.Collections.Generic;
using System.Text;

namespace AccessibilityTesting.DeepLinkTest
{
    static public class Navigation
    {
        const string StartNavigationLink = "seeingIGo://Notify_SIG_of_Navigation?location_latitude={0}&location_longitude={1}";
        static public Uri getNavigationString(string latitude, string longitude)
        {
            return new Uri(string.Format(StartNavigationLink, longitude, latitude));
        }
    }
}
