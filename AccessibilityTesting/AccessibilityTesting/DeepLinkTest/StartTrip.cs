using System;
using System.Collections.Generic;
using System.Text;

namespace AccessibilityTesting.DeepLinkTest
{
    static public class StartTrip
    {
        const string StartTripnLink = "seeingIGo://Notify_SIG_of_Start_Trip?rider_name={0}&&rider_id={1}";
        static public Uri getStartTripLink(string RiderID, string RiderName)
        {
            return new Uri(string.Format(StartTripnLink, RiderName, RiderID));
        }
    }
}
