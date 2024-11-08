using Foundation;
using ObjCRuntime;
using UIKit;

namespace VisionAnalyzer;

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
}
