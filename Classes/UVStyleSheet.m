//
//  UVStyleSheet.m
//  UserVoice
//
//  Created by UserVoice on 10/28/09.
//  Copyright 2009 UserVoice Inc. All rights reserved.
//

#import "UVStyleSheet.h"

@implementation UVStyleSheet

static UVStyleSheet *instance;
static UVStyleSheet *customInstance;

+ (UVStyleSheet *)instance {
    if (instance == nil) {
        instance = [UVStyleSheet new];
        instance.loadingViewBackgroundColor = [UIColor colorWithRed:0.902f green:0.902f blue:0.902f alpha:1.0f];
        instance.preferredStatusBarStyle = UIStatusBarStyleDefault;
    }
    return instance;
}

+ (UVStyleSheet *)customInstance{
    return customInstance;
}

+(void)setCustomInstance:(UVStyleSheet*)style{
    customInstance = style;
    [[UIBarButtonItem appearance] setTitleTextAttributes:@{NSFontAttributeName:customInstance.navigationBarFont,
                                                           NSForegroundColorAttributeName:[UVStyleSheet customInstance].themeColorGray} forState:UIControlStateNormal];
}

+(UIFont*)styleSheetFontOfSize:(CGFloat)size{
    if (customInstance) {
        return [customInstance.navigationBarFont fontWithSize:size];
    }
    return [UIFont systemFontOfSize:size];
}

@end
