using Foundation;

namespace experiment;

[Register("ViewController")]
partial class ViewController
{
    [Action("MauiButforEvent:")]
    partial void MauiButforEvent(Foundation.NSObject sender);

    void ReleaseDesignerOutlets()
    {
    }
}