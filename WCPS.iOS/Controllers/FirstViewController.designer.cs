// WARNING
//
// This file has been generated automatically by Xamarin Studio Enterprise to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WCPS.iOS
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		UIKit.UIButton _calendarButton { get; set; }

		[Outlet]
		UIKit.UIImageView _imageView { get; set; }

		[Outlet]
		UIKit.UIButton _inifiniteCampusButton { get; set; }

		[Outlet]
		UIKit.UIButton _lunchMenuButton { get; set; }

		[Outlet]
		UIKit.UIButton _websiteButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_calendarButton != null) {
				_calendarButton.Dispose ();
				_calendarButton = null;
			}

			if (_imageView != null) {
				_imageView.Dispose ();
				_imageView = null;
			}

			if (_inifiniteCampusButton != null) {
				_inifiniteCampusButton.Dispose ();
				_inifiniteCampusButton = null;
			}

			if (_websiteButton != null) {
				_websiteButton.Dispose ();
				_websiteButton = null;
			}

			if (_lunchMenuButton != null) {
				_lunchMenuButton.Dispose ();
				_lunchMenuButton = null;
			}
		}
	}
}
