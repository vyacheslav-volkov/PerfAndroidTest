#import <Foundation/Foundation.h>

@protocol HostAppProtocol <NSObject>

@required
- (void)onLoadMore:(UIView *)view;

@required
- (void)onTextChanged:(UIView *)view;

@end