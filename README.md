## Go To Settings Plugin for Xamarin (iOS, Android)

Provides a way to take users to the settings page for your application for iOS and Android. This can be useful if users have declined permissions and now need to go to the settings page to manually enable these permissions.

### Setup

Grab from NuGet and install into the PCL, Android, and iOS projects
[![NuGet](https://img.shields.io/nuget/v/TrueGeek.Plugin.GoToSettings.svg?label=NuGet)](https://www.nuget.org/packages/TrueGeek.Plugin.GoToSettings/)
https://www.nuget.org/packages/TrueGeek.Plugin.GoToSettings

### Build Status
[![Build status](https://ci.appveyor.com/api/projects/status/edhcn03nasyfw97k?svg=true)](https://ci.appveyor.com/project/TrueGeek/xamarin-plugin-gotosettings)

### Usage

There is only one method:

```
Plugin.GoToSettings.GoToSettings.Go();
```

This will open the App Settings page in iOS and the App Info page in Android.

| iOS App Settings Page  | Android App Info Page |
| ------------- | ------------- |
| <img src="https://github.com/TrueGeek/Xamarin.Plugin.GoToSettings/blob/master/ScreenShots/settings_ios.png" width="25%">  | <img src="https://github.com/TrueGeek/Xamarin.Plugin.GoToSettings/blob/master/ScreenShots/appinfo_droid.png" width="25%">

#### License

Licensed under MIT, see license file.