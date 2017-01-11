using UIKit;
using Foundation;
using System;

namespace IntroductionToStoryboards
{
    public partial class MainViewController : UIViewController
    {
        UIViewController _pinkViewController;

        public MainViewController(IntPtr handle) : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            //Instatiating View Controller with Storyboard ID 'PinkViewController'
            _pinkViewController = Storyboard.InstantiateViewController("PinkViewController") as PinkViewController;
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

            //When we push the button, we will push the pinkViewController onto our current Navigation Stack
            //PinkButton.TouchUpInside += (o, e) =>
            //{
            //    this.NavigationController.PushViewController(_pinkViewController, true);
            //};
        }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            if (segueIdentifier == "SegueToPink")
            {
                if (PasswordTextField.Text.Trim() == "sweetpea")
                {
                    PasswordTextField.ResignFirstResponder();
                    return true;
                }
                else
                {
                    ErrorLabel.Hidden = false;
                    return false;
                }
            }

            return base.ShouldPerformSegue(segueIdentifier, sender);
        }
    }
}