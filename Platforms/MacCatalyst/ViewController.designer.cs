using Foundation;

namespace VisionAnalyzer
{

[Register("ViewController")]
partial class ViewController
{
    [Action("woohoobutton:")]
    partial void woohoobutton(Foundation.NSObject sender);

    void ReleaseDesignerOutlets()
    {
    }
}}