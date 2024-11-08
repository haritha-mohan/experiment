using Foundation;
using ObjCRuntime;
using UIKit;

namespace experiment;

public partial class ViewController : UIViewController
{
    protected ViewController(NativeHandle handle) : base(handle)
    {
        // This constructor is required if the view controller is loaded from a xib or a storyboard.
        // Do not put any initialization here, use ViewDidLoad instead.
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
    }

    partial void MauiButforEvent(NSObject sender)
    {
        // Change window background color
        View!.Window.BackgroundColor = UIColor.Red; //this is the part that's not getting executed at the moment
    }
}
