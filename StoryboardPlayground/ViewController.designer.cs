// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace StoryboardPlayground
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UILabel mealNameLabel { get; set; }

        [Outlet]
        UIKit.UITextField nameTextField { get; set; }

        [Action ("SetDefaultLabelText:")]
        partial void SetDefaultLabelText (UIKit.UIButton sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (nameTextField != null) {
                nameTextField.Dispose ();
                nameTextField = null;
            }

            if (mealNameLabel != null) {
                mealNameLabel.Dispose ();
                mealNameLabel = null;
            }
        }
    }
}
