// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace IntroductionToStoryboards
{
    [Register ("PinkViewController")]
    partial class PinkViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView PinkView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (PinkView != null) {
                PinkView.Dispose ();
                PinkView = null;
            }
        }
    }
}