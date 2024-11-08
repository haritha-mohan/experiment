using Foundation;
using UIKit;

namespace experiment;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        var storyboard = UIStoryboard.FromName("Main", null);

        var initialViewController = storyboard.InstantiateInitialViewController() as ViewController;

        Window = new UIWindow(UIScreen.MainScreen.Bounds)
        {
            RootViewController = initialViewController
        };
        Window.MakeKeyAndVisible();
        return true; //don't call base otherwise default maui screen shows up
    }
}
