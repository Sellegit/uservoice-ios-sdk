//
//  UVSuccessViewController.m
//  UserVoice
//
//  Created by Austin Taylor on 10/23/13.
//  Copyright (c) 2013 UserVoice Inc. All rights reserved.
//

#import "UVSuccessViewController.h"
#import "UVSession.h"
#import "UVClientConfig.h"

@implementation UVSuccessViewController

- (void)loadView {
    [super loadView];
    [self.navigationController setNavigationBarHidden:YES animated:YES];
    self.view = [UIView new];
    self.view.frame = [self contentFrame];
    self.view.backgroundColor = [UIColor blackColor];
    UILabel *title = [UILabel new];
    title.text = _titleText;
    title.textColor = [UVStyleSheet customInstance].themeColorRed;
    title.font = [UVStyleSheet styleSheetFontOfSize:28];
    title.textAlignment = NSTextAlignmentCenter;
    title.backgroundColor = [UIColor clearColor];
    UILabel *text = [UILabel new];
    text.text = _text;
    text.textColor = [UVStyleSheet customInstance].themeColorRed;
    text.font = [UVStyleSheet styleSheetFontOfSize:17];
    text.numberOfLines = 0;
    text.textAlignment = NSTextAlignmentCenter;
    text.backgroundColor = [UIColor clearColor];
    UIButton *button = [UIButton new];
    button.layer.borderWidth = 1.5f;
    button.layer.borderColor = [UVStyleSheet customInstance].themeColorRed.CGColor;
    button.layer.backgroundColor = [UIColor clearColor].CGColor;
    button.layer.cornerRadius = 3.0;
    button.titleLabel.font = [UVStyleSheet styleSheetFontOfSize:14];
    [button setTitle:NSLocalizedStringFromTableInBundle(@"Close", @"UserVoice", [UserVoice bundle], nil) forState:UIControlStateNormal];
    [button setTitleColor:[UVStyleSheet customInstance].themeColorRed forState:UIControlStateNormal];
    [button addTarget:self action:@selector(dismiss) forControlEvents:UIControlEventTouchUpInside];
    UILabel *power = [UILabel new];
    power.text = NSLocalizedStringFromTableInBundle(@"Powered by UserVoice", @"UserVoice", [UserVoice bundle], nil).uppercaseString;
    power.textColor = [UIColor grayColor];
    power.font = [UVStyleSheet styleSheetFontOfSize:13];
    power.textAlignment = NSTextAlignmentCenter;
    power.backgroundColor = [UIColor clearColor];
    if ([UVSession currentSession].clientConfig.whiteLabel) {
        power.hidden = YES;
    }
    [self configureView:self.view
               subviews:NSDictionaryOfVariableBindings(title, text, button, power)
            constraints:@[@"|-[title]-|", @"|-40-[text]-40-|", @"[button(>=90)]", @"|-[power]-|", @"V:|-(>=20)-[title]-16-[text]-40-[button(==28)]-(>=40)-[power]-20-|"]];
    NSLayoutConstraint *constraint = [NSLayoutConstraint constraintWithItem:title attribute:NSLayoutAttributeTop relatedBy:NSLayoutRelationEqual toItem:self.view attribute:NSLayoutAttributeTop multiplier:1.0 constant:160];
    constraint.priority = UILayoutPriorityDefaultLow;
    [self.view addConstraint:constraint];
    [self.view addConstraint:[NSLayoutConstraint constraintWithItem:button attribute:NSLayoutAttributeCenterX relatedBy:NSLayoutRelationEqual toItem:self.view attribute:NSLayoutAttributeCenterX multiplier:1.0 constant:0]];
}

- (UIStatusBarStyle)preferredStatusBarStyle {
    return UIStatusBarStyleLightContent;
}

@end
