// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MacOSApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField label { get; set; }

		[Outlet]
		AppKit.NSTextField textField { get; set; }

		[Action ("Calculate:")]
		partial void Calculate (AppKit.NSButton sender);

		[Action ("enterNumber:")]
		partial void enterNumber (AppKit.NSTextField sender);

		[Action ("resetButton:")]
		partial void resetButton (AppKit.NSButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (label != null) {
				label.Dispose ();
				label = null;
			}

			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}

		}
	}
}
