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
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		UIKit.UIButton _openButton { get; set; }

		[Outlet]
		UIKit.UIPickerView _pickerView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_pickerView != null) {
				_pickerView.Dispose ();
				_pickerView = null;
			}

			if (_openButton != null) {
				_openButton.Dispose ();
				_openButton = null;
			}
		}
	}
}
