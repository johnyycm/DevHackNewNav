﻿using System;

using UIKit;
using Foundation;

namespace Phoneword_iOS
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
			// Perform any additional setup after loading the view, typically from a nib.
			string translateNumber = "";
			TranslateButton.TouchUpInside += (object sender, EventArgs e) => {
				translateNumber = PhoneTranslator.ToNumber(PhoneNumberText.Text);
				PhoneNumberText.ResignFirstResponder();
				if (translateNumber == "")
				{
					CallButton.SetTitle("Call", UIControlState.Normal);
					CallButton.Enabled = false;
				}
				else
				{
					CallButton.SetTitle("Call " + translateNumber, UIControlState.Normal);
					CallButton.Enabled = true;
				}
			};

			CallButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				// Use URL handler with tel: prefix to invoke Apple's Phone app...
				var url = new NSUrl("tel:" + translateNumber);

				// ...otherwise show an alert dialog
				if (!UIApplication.SharedApplication.OpenUrl(url))
				{
					var alert = UIAlertController.Create("Not supported", "Scheme 'tel:' is not supported on this device", UIAlertControllerStyle.Alert);
					alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
					PresentViewController(alert, true, null);
				}
			};
			
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
