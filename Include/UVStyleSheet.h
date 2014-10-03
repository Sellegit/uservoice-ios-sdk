//
//  UVStyleSheet.h
//  UserVoice
//
//  Created by UserVoice on 10/28/09.
//  Copyright 2009 UserVoice Inc. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface UVStyleSheet : NSObject 

+ (UVStyleSheet *)instance;
+ (UVStyleSheet *)customInstance;
+(void)setCustomInstance:(UVStyleSheet*)style;
+(UIFont*)styleSheetFontOfSize:(CGFloat)size;

@property (nonatomic, retain) UIColor *tintColor;
@property (nonatomic, retain) UIColor *tableViewBackgroundColor;
@property (nonatomic, retain) UIColor *navigationBarBackgroundColor;
@property (nonatomic, retain) UIColor *navigationBarTextColor;
@property (nonatomic, retain) UIColor *navigationBarTextShadowColor;
@property (nonatomic, retain) UIImage *navigationBarBackgroundImage;
@property (nonatomic, retain) UIFont  *navigationBarFont;
@property (nonatomic, retain) UIColor *navigationBarTintColor;
@property (nonatomic, retain) UIColor *navigationBarActivityIndicatorColor;
@property (nonatomic, retain) UIColor *loadingViewBackgroundColor;
@property (nonatomic, assign) UIStatusBarStyle preferredStatusBarStyle;

@property (nonatomic) UIColor *themeColorRed, *themeColorGray;


@end
