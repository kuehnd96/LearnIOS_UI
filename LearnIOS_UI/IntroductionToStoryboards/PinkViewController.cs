using UIKit;
using Foundation;
using System;

namespace IntroductionToStoryboards
{
    public partial class PinkViewController : UIViewController
    {
        public PinkViewController(IntPtr handle) : base(handle)
        {

        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view
        }
    }
}