using System;
using Foundation;
using UIKit;

namespace WCPS.iOS
{
    public partial class FirstViewController : UIViewController
    {
        public FirstViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _websiteButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                UIApplication.SharedApplication.OpenUrl(new NSUrl("http://www.warrencountyschools.org/"));
            };

            _calendarButton.TouchUpInside += (object sender, EventArgs e) => 
            {
                UIApplication.SharedApplication.OpenUrl(new NSUrl("http://www.warrencountyschools.org/userfiles/13494/my%20files/2015-2016%20school%20use%20.pdf?id=595125"));
            };

            _inifiniteCampusButton.TouchUpInside += (object sender, EventArgs e) => 
            {
                UIApplication.SharedApplication.OpenUrl(new NSUrl("https://infinitecampus.warren.kyschools.us/campus/portal/warren.jsp?status=captcha"));
            };

            _lunchMenuButton.TouchUpInside += (object sender, EventArgs e) => 
            {
                UIApplication.SharedApplication.OpenUrl(new NSUrl("http://www.warrencountyschools.org/Content/760"));
            };
        }

        public override bool PrefersStatusBarHidden()
        {
            return true;
        }
    }
}

