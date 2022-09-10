// WARNING
// This file has been generated automatically by Rider IDE to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface ViewController : NSViewController {
    
    NSTextField *label;
}
@property (assign) IBOutlet NSTextField *label;
@property (weak) IBOutlet NSTextField *textField;

- (IBAction)enterNumber:(NSTextField *)sender;
- (IBAction)Calculate:(NSButton *)sender;

@end
