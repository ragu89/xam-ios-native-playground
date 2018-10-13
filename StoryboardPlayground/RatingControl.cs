using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using CoreGraphics;
using Foundation;
using UIKit;

namespace StoryboardPlayground
{
    [Register("RatingControl"), DesignTimeVisible(true)]
    public class RatingControl : UIStackView
    {
        Dictionary<UIButton, int> ratingButtons = new Dictionary<UIButton, int>();
        int ratingSeletected;

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
            ClearRatingButtons();

            var emptyStar = UIImage.FromBundle("emptyStar");
            var filledStar = UIImage.FromBundle("filledStar");
            var highlightedStar = UIImage.FromBundle("highlightedStar");

            for (var i = 1; i <= 5; i++)
            {
                var button = new UIButton()
                {
                    BackgroundColor = UIColor.Red,
                    TranslatesAutoresizingMaskIntoConstraints = false
                };

                button.HeightAnchor.ConstraintEqualTo(44.0f).Active = true;
                button.WidthAnchor.ConstraintEqualTo(44.0f).Active = true;

                button.SetImage(emptyStar, UIControlState.Normal);
                button.SetImage(filledStar, UIControlState.Selected);
                button.SetImage(highlightedStar, UIControlState.Highlighted);

                button.TouchUpInside += Button_TouchUpInside;

                AddArrangedSubview(button);

                ratingButtons[button] = i;
            }
        }

        void ClearRatingButtons()
        {
            foreach(var button in ratingButtons)
            {
                RemoveArrangedSubview(button.Key);
                button.Key.RemoveFromSuperview();
            }
            ratingButtons.Clear();
        }

        void Button_TouchUpInside(object sender, EventArgs e)
        {
            var button = sender as UIButton;
            ratingButtons.TryGetValue(button, out int rating);
            Debug.WriteLine($"Star {rating} selected");

            if (ratingSeletected == rating)
            {
                DeselectAllStars();
                ratingSeletected = 0;
            }
            else
            {
                ratingSeletected = rating;
                SelectButtonsUntil(rating);
            }
        }

        void SelectButtonsUntil(int rating)
        {
            int i = 1;
            foreach (var button in ratingButtons.Keys)
            {
                if (i > rating) button.Selected = false;
                else button.Selected = true;
                i++;
            }
        }

        void DeselectAllStars()
        {
            foreach (var button in ratingButtons.Keys) button.Selected = false;
        }
    }
}
