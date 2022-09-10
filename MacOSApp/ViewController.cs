using System;
using System.Reflection.Emit;
using AppKit;
using Foundation;
using MediaPlayer;

namespace MacOSApp
{
    public partial class ViewController : NSViewController
    {
        private string result = "0";
        private string textFieldValue = "0";
        private string textFieldDataLink = "/Users/malinatrash/Desktop/MacOSApp/UserData/textField.txt";
        private string resultDataLink = "/Users/malinatrash/Desktop/MacOSApp/UserData/result.txt";
        
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            result = StorageManager.LoadData(resultDataLink);
            textFieldValue = StorageManager.LoadData(textFieldDataLink);
            
            label.StringValue = result;
            textField.StringValue = textFieldValue;
        }

        public override NSObject RepresentedObject
        {
            get { return base.RepresentedObject; }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void Calculate(NSButton sender)
        {
            textFieldValue = textField.StringValue;
            StorageManager.SaveData(textFieldValue, textFieldDataLink);
            StorageManager.SaveData(textFieldValue, textFieldDataLink);
            
            result = Logic.Calculate(textFieldValue);
            StorageManager.SaveData(result, resultDataLink);
            
            label.StringValue = $"{result}";
        }
        
        
    }
}