using System;
using System.Collections.Generic;
using System.Text;

namespace AccessibilityTesting.DeepLinkTest
{
    static public class StartTrip
    {
        const string StartTripnLink = "SeeingIGo://Notify_SIG_of_Start_Trip?rider_name={0}&&rider_id={1}";
        static public string getStartTripLink(string RiderID, string RiderName)
        {
            return string.Format(StartTripnLink, RiderName, RiderID);
        }
    }
}
