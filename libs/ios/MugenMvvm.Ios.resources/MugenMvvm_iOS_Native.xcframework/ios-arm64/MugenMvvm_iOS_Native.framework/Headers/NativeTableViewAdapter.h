#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <MugenMvvm_iOS_Native/CollectionViewAdapter.h>

@interface NativeTableViewAdapter : NSObject <CollectionViewAdapter>

- (instancetype)initWithTableView:(UITableView *)tableView;

@property(nonatomic, weak) UITableView *tableView;

@property(nonatomic) UITableViewRowAnimation insertRowsAnimation;

@property(nonatomic) UITableViewRowAnimation deleteRowsAnimation;

@property(nonatomic) UITableViewRowAnimation reloadRowsAnimation;

@end