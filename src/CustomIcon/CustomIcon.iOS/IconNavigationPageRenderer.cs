using CoreGraphics;
using CustomIcon.iOS;
using CustomIcon.Views;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomIcon.Views.MainPage), typeof(IconNavigationPageRenderer))]
namespace CustomIcon.iOS
{
    public class IconNavigationPageRenderer : PhoneMasterDetailRenderer
    {
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            if (!(Element is MainPage mdp)) return;
            if (!(Platform.GetRenderer(mdp.Detail) is UINavigationController nc)) return;

            UIButton btn = new UIButton(UIButtonType.Custom);
            btn.Frame = new CGRect(0, 0, 50, 44);
            var img = UIImage.FromFile("newIcon.png");
            btn.SetTitle(string.Empty, UIControlState.Normal);
            btn.SetImage(img, UIControlState.Normal);
            btn.TouchUpInside += (sender, e) => mdp.IsPresented = true;
            nc.NavigationBar.TitleTextAttributes = new UIStringAttributes()
            {
                ForegroundColor = UIColor.White
            };

            nc.NavigationBar.BarTintColor = Color.FromHex("#52A7E0").ToUIColor();

            var lbbi = new UIBarButtonItem(btn);
            nc.NavigationBar.TopItem.LeftBarButtonItem = lbbi;
        }
    }
}
