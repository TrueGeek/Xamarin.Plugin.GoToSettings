using Plugin.GoToSettings.Abstractions;
using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using Java.Security;
using Javax.Crypto;
using Android.Content;

namespace Plugin.GoToSettings
{
    
    public class GoToSettingsImplementation : GoToSettingsImplementationBase
    {

        public override void Go()
        {

            System.Diagnostics.Debug.WriteLine("Android - Go");

            Intent intent = new Intent(Android.Provider.Settings.ActionApplicationDetailsSettings);
            intent.SetData(Android.Net.Uri.Parse("package:" + Android.App.Application.Context.PackageName));

            System.Diagnostics.Debug.WriteLine("Android - Go | " + Android.App.Application.Context.PackageName);

            Android.App.Application.Context.StartActivity(intent);

        }

    }

}