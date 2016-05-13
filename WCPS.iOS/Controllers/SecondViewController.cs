using System;
using UIKit;
using System.Linq;
using System.Collections.Generic;
using Foundation;

namespace WCPS.iOS
{
    public partial class SecondViewController : UIViewController
    {
        //NOTE: Dictionary of Schools with Website Id number for that schools webpage
        public static Dictionary<int, string> Schools = new Dictionary<int, string> 
        { 
            {1, "Greenwood"},
            {2, "South Warren High"},
            {3, "Warren Central High"}, 
            {4, "Warren East High"},
            {5, "Drakes Creek Middle"}, 
            {6, "Henry F. Moss Middle"},
            {7, "South Warren Middle"},
            {8, "Warren East Middle"},
            {10, "Alvaton"},
            {11, "Briarwood"},
            {12, "Bristow"}, 
            {13, "Cumberland Trace"},
            {14, "Lost River"},
            {15, "Natcher"},
            {16, "North Warren"},
            {17, "Oakland"},
            {18, "Plano"},
            {19, "Richpond"},
            {20, "Richardsville"},
            {21, "Rockfield"},
            {22, "Warren"},
            {27, "Jody Richards"},
            {28, "212º Academy"},
        };

        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();	

            _pickerView.Model = new SchoolPickerModel();

            _openButton.TouchUpInside += (object sender, EventArgs e) => 
            {
                //Opens webpage
                UIApplication.SharedApplication.OpenUrl(new NSUrl("http://www.warrencountyschools.org/" + ((SchoolPickerModel)_pickerView.Model).SelectedSchool +"/Home"));
            };
        }

        public class SchoolPickerModel: UIPickerViewModel
        {
            public int SelectedSchool;

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 1;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                return Schools.Count;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                return Schools.ElementAt((int)row).Value;
            }

            public override void Selected(UIPickerView pickerView, nint row, nint component)
            {
                //Gets title of selected school
                var school = GetTitle(pickerView, row, component);
                //sets SelectedSchool to the int value of the school obtained from the dictionary
                SelectedSchool = Schools.FirstOrDefault(s => s.Value == school).Key;
            }
        }

        public override bool PrefersStatusBarHidden()
        {
            return true;
        }
    }
}

