using System;
using System.Diagnostics;
using Foundation;
using UIKit;

namespace StoryboardPlayground
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            nameTextField.ShouldReturn += NameTextField_ShouldReturn;
            nameTextField.EditingDidEnd += (sender, e) => mealNameLabel.Text = nameTextField.Text;
        }

        bool NameTextField_ShouldReturn(UITextField textField)
        {
            textField.ResignFirstResponder();
            return true;
        }

        partial void SelectImageFromPhotoLibrary(UITapGestureRecognizer sender)
        {
            nameTextField.ResignFirstResponder();

            var imagePickerController = new UIImagePickerController();
            imagePickerController.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            imagePickerController.Canceled += (s, e) => (s as UIImagePickerController).DismissViewController(true, null);
            imagePickerController.FinishedPickingMedia += ImagePickerController_FinishedPickingMedia;

            PresentViewController(imagePickerController, true, null);
        }


        partial void SetDefaultLabelText(UIButton sender)
        {
            mealNameLabel.Text = "Default text";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void ImagePickerController_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {
            var originalImg = new NSString("UIImagePickerControllerOriginalImage");
            var selectedImage = e.Info[originalImg] as UIImage;
            if(selectedImage is null)
            {
                Debug.WriteLine($"Expected a dictionary containing an image, but was provided the following : {e.Info}");
            }
            else
            {
                photoImageView.Image = selectedImage;
            }

            DismissViewController(true, null);
        }

    }
}
