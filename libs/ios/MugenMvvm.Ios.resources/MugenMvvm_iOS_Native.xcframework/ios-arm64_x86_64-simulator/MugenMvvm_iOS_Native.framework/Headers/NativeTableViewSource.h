#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@protocol CollectionViewSource;

@interface NativeTableViewSource : NSObject <UITableViewDelegate, UITableViewDataSource>

- (instancetype)initWithSource:(NSObject <CollectionViewSource> *)source;

@property(nonatomic, weak) NSObject <CollectionViewSource> *source;

@end