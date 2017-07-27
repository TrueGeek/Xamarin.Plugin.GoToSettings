using Plugin.GoToSettings.Abstractions;
using System;
using Security;
using Foundation;
using UIKit;

namespace Plugin.GoToSettings
{

    public class GoToSettingsImplementation : GoToSettingsImplementationBase
    {

        public GoToSettingsImplementation()
        {
        }

        public override void Go()
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
        }

    }

}