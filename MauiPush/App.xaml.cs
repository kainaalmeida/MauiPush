using OneSignalSDK.DotNet;
using OneSignalSDK.DotNet.Core.Debug;

namespace MauiPush;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        OneSignal.Debug.LogLevel = LogLevel.VERBOSE;

        // OneSignal Initialization
        OneSignal.Initialize("3f070635-a09b-4c90-9d8f-1a632b9ec2d6");

        // RequestPermissionAsync will show the notification permission prompt.
        // We recommend removing the following code and instead using an In-App Message to prompt for notification permission (See step 5)
        OneSignal.Notifications.RequestPermissionAsync(true);

        MainPage = new AppShell();
	}
}
