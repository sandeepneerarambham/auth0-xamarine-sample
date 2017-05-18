// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSSample
{
    [Register ("MyViewController")]
    partial class MyViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Auth0Badge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Auth0Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Auth0Badge != null) {
                Auth0Badge.Dispose ();
                Auth0Badge = null;
            }

            if (Auth0Label != null) {
                Auth0Label.Dispose ();
                Auth0Label = null;
            }

            if (LoginButton != null) {
                LoginButton.Dispose ();
                LoginButton = null;
            }
        }
    }
}