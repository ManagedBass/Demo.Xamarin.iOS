// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Xamarin.iOS.Player
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PlayButton { get; set; }
        [Action ("ButtonTouched:")]
        partial void ButtonTouched (Foundation.NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (PlayButton != null) {
                PlayButton.Dispose ();
                PlayButton = null;
            }
        }
    }
}