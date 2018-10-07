using System;

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


        partial void SetDefaultLabelText(UIButton sender)
        {
            mealNameLabel.Text = "Default text";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
