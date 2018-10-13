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

        [Outlet]
        UIKit.UIImageView photoImageView { get; set; }

        [Action ("Click:")]
        partial void Click (UIKit.UITapGestureRecognizer sender);

        [Action ("selectImageFromPhotoLibrary:")]
        partial void selectImageFromPhotoLibrary (UIKit.UITapGestureRecognizer sender);

        [Action ("SelectImageFromPhotoLibrary:")]
        partial void SelectImageFromPhotoLibrary (UIKit.UITapGestureRecognizer sender);

        [Action ("SetDefaultLabelText:")]
        partial void SetDefaultLabelText (UIKit.UIButton sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (mealNameLabel != null) {
                mealNameLabel.Dispose ();
                mealNameLabel = null;
            }

            if (nameTextField != null) {
                nameTextField.Dispose ();
                nameTextField = null;
            }

            if (photoImageView != null) {
                photoImageView.Dispose ();
                photoImageView = null;
            }
        }
    }
}
