//
//  ViewController.m
//  UVTest
//
//  Created by Rocky Duan on 9/22/14.
//  Copyright (c) 2014 UserVoice Inc. All rights reserved.
//

#import "ViewController.h"
#import "UserVoice.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    UVConfig *config = [UVConfig configWithSite:@"peachnow.uservoice.com"];
    [UserVoice initialize:config];
    
    // Do any additional setup after loading the view, typically from a nib.
}
- (IBAction)touched:(id)sender {
    UVStyleSheet *style = [UVStyleSheet new];
    style.navigationBarFont = [UIFont systemFontOfSize:10];
    style.themeColorRed = [UIColor colorWithRed:(float)242/255 green:(float)46/255 blue:(float)89/255 alpha:1];
    style.themeColorGray = [UIColor colorWithRed:118/255 green:118/255 blue:118/255 alpha:1];
    style.themeColorCloseToBlack = [UIColor colorWithRed:4/255 green:4/255 blue:4/255 alpha:1];

    style.navigationBarTintColor = style.themeColorCloseToBlack;
    [UserVoice setStyleSheet:style];
    [[UINavigationBar appearance] setTintColor:style.themeColorCloseToBlack];
    [UserVoice presentUserVoiceInterfaceForParentViewController:self];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
