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
    
    [UserVoice presentUserVoiceInterfaceForParentViewController:self];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
