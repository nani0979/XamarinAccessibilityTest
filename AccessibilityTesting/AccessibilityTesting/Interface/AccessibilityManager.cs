using System;
using System.Collections.Generic;
using System.Text;

namespace AccessibilityTesting.Interface
{
    public interface IAccessibilityManager
    { /// <summary> /// Announces/speaks the text passed in the method when the Screen reader /// or VoiceOver features are enabled. /// </summary> /// <param name="speakText">The text to speak/announce</param> 
        void AnnounceAccessibility(string speakText);
    }
}
