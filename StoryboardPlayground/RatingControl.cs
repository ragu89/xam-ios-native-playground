using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using UIKit;

namespace StoryboardPlayground
{
    [Register("RatingControl"), DesignTimeVisible(true)]
    public class RatingControl : UIStackView
    {
        public RatingControl(IntPtr p) : base(p) { }

        public RatingControl()
        {
            SetupButtons();
        }

        public override void AwakeFromNib()
        {
            SetupButtons();
        }

        void SetupButtons()
        {
            var button = new UIButton()
            {
                BackgroundColor = UIColor.Red,
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            button.HeightAnchor.ConstraintEqualTo(44.0f).Active = true;
            button.WidthAnchor.ConstraintEqualTo(44.0f).Active = true;

            AddArrangedSubview(button);
        }
    }
}
