//
//  UVSuggestionListViewController.m
//  UserVoice
//
//  Created by Mirko Froehlich on 10/22/09.
//  Copyright 2009 UserVoice Inc. All rights reserved.
//

#import <QuartzCore/QuartzCore.h>
#import "UVSuggestionListViewController.h"
#import "UVClientConfig.h"
#import "UVSession.h"
#import "UVSuggestion.h"
#import "UVSuggestionDetailsViewController.h"
#import "UVSearchResultsViewController.h"
#import "UVProfileViewController.h"
#import "UVInfoViewController.h"
#import "UVStyleSheet.h"
#import "UVUser.h"
#import "UVFooterView.h"
#import "Three20/Three20.h"

#define SUGGESTIONS_PAGE_SIZE 10

@implementation UVSuggestionListViewController

@synthesize forum;

- (id)initWithForum:(UVForum *)theForum {
	if (self = [super init]) {
		if (theForum.currentTopic.suggestions) {
			self = [self initWithForum:theForum andSuggestions:theForum.currentTopic.suggestions];
			
		} else {
			self.forum = theForum;
		}		
	}
	return self;
}

- (id)initWithForum:(UVForum *)theForum andSuggestions:(NSArray *)theSuggestions {
	if (self = [super init]) {
		self.suggestions = [NSMutableArray arrayWithArray:theSuggestions];
		self.forum = theForum;
	}
	return self;
}

- (NSString *)backButtonTitle {
	return @"Ideas";
}

- (BOOL)isLoading {
	return self.suggestions == nil || ([self.suggestions count] == 0 && !allSuggestionsRetrieved);
}

- (void)retrieveMoreSuggestions {
	NSInteger page = ([self.suggestions count] / SUGGESTIONS_PAGE_SIZE) + 1;
	[self showActivityIndicator];
	[UVSuggestion getWithForum:self.forum page:page delegate:self];
}

// Populates the suggestions. The default implementation retrieves the 10 most recent
// suggestions, but this can be overridden in subclasses (e.g. for profile idea view).
- (void)populateSuggestions {
	allSuggestionsRetrieved = NO;
	self.suggestions = [NSMutableArray arrayWithCapacity:10];
	[UVSession currentSession].clientConfig.forum.currentTopic.suggestions = [NSMutableArray arrayWithCapacity:10];
	[self retrieveMoreSuggestions];
}

- (void)didRetrieveSuggestions:(NSArray *)theSuggestions {
	[self hideActivityIndicator];
	if ([theSuggestions count] > 0) {
		[self.suggestions addObjectsFromArray:theSuggestions];
	}
	
	if ([theSuggestions count] < 10) {
		allSuggestionsRetrieved = YES;
	}
	[UVSession currentSession].clientConfig.forum.currentTopic.suggestions = self.suggestions;
	
	[(UITableView *)self.view reloadData];
}

- (BOOL)supportsSearch {
	return YES;
}

- (BOOL)supportsFooter {
	return YES;
}

#pragma mark ===== UITableViewDataSource Methods =====

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
	NSString *identifier;
	BOOL selectable = YES;
	UITableViewCellStyle style = UITableViewCellStyleDefault;
	
	if (indexPath.row < [self.suggestions count]) {
		identifier = @"Suggestion";
	} else {
		identifier = @"Load";
	}
	
	return [self createCellForIdentifier:identifier
							   tableView:tableView
							   indexPath:indexPath
								   style:style
							  selectable:selectable];
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
	if ([self isLoading]) {
		return 0;
	} else {
		// One cell per suggestion + "Load More"
		return [self.suggestions count] + (allSuggestionsRetrieved ? 0 : 1);
	}
}

#pragma mark ===== UITableViewDelegate Methods =====

- (CGFloat)tableView:(UITableView *)tableView heightForRowAtIndexPath:(NSIndexPath *)indexPath {
	// Both for suggestions and Load More
	return 71;
}

- (void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath {
	[tableView deselectRowAtIndexPath:indexPath animated:YES];

	if (indexPath.row < [self.suggestions count]) {
		UVSuggestion *suggestion = [suggestions objectAtIndex:indexPath.row];
		UVSuggestionDetailsViewController *next = [[UVSuggestionDetailsViewController alloc] init];
		next.suggestion = suggestion;
		[self.navigationController pushViewController:next animated:YES];
		[next release];
	} else {
		[self retrieveMoreSuggestions];
	}
}

#pragma mark ===== TTTextEditorDelegate Methods =====

- (BOOL)textEditorShouldBeginEditing:(TTTextEditor *)theTextEditor {
	UVSearchResultsViewController *next = [[UVSearchResultsViewController alloc] initWithForum:self.forum];
	UINavigationController *nav = [[UINavigationController alloc] initWithRootViewController:next];
	[self presentModalViewController:nav animated:NO];
	return NO;
}

#pragma mark ===== Basic View Methods =====

// Implement loadView to create a view hierarchy programmatically, without using a nib.
- (void)loadView {
	[super loadView];

	self.navigationItem.title = self.forum.currentTopic.prompt;
	
	// Note: Uncomment this if we end up going back to jumping straight into idea list.
	// Workaround: Since we're pushing two view controllers at once, the secone one
	// doesn't seem to be able to pick up the first controller's back button title.
	//self.navigationController.navigationBar.backItem.title = @"Forums";
	
	CGRect frame = [self contentFrame];
	UITableView *tableView = [[UITableView alloc] initWithFrame:frame style:UITableViewStylePlain];
	tableView.dataSource = self;
	tableView.delegate = self;
	tableView.backgroundColor = [UIColor groupTableViewBackgroundColor];
	[self addShadowSeparatorToTableView:tableView];

	if ([self supportsSearch]) {
		// Add text editor to table header
		// Note: We're actually not using this for text entry. Instead, tapping the
		//       editor brings up a modal search view.
		TTView *textBar = [[TTView alloc] initWithFrame:CGRectMake(0, 0, 320, 40)];
		textBar.style = TTSTYLE(commentTextBar);
		TTTextEditor *theTextEditor = [[TTTextEditor alloc] initWithFrame:CGRectMake(5, 0, 315, 40)];
		theTextEditor.delegate = self;
		theTextEditor.autocorrectionType = UITextAutocorrectionTypeYes;
		theTextEditor.minNumberOfLines = 1;
		theTextEditor.maxNumberOfLines = 1;
		theTextEditor.autoresizesToText = NO;
		theTextEditor.backgroundColor = [UIColor clearColor];
		theTextEditor.style = TTSTYLE(commentTextBarTextField);
		theTextEditor.placeholder = [self.forum example];
		[textBar addSubview:theTextEditor];
		[theTextEditor release];
		tableView.tableHeaderView = textBar;
		[textBar release];
	}
	
	if ([self supportsFooter]) {
		tableView.tableFooterView = [UVFooterView footerViewForController:self];
	} else {
		// Add empty footer, to suppress blank cells (with separators) after actual content
		UIView *footer = [[UIView alloc] initWithFrame:CGRectMake(0, 0, 320, 0)];
		tableView.tableFooterView = footer;
		[footer release];
	}
	
	self.view = tableView;
	[tableView release];
}

- (void)viewWillAppear:(BOOL)animated {
	[super viewWillAppear:animated];
	
	if (!self.suggestions) {
		[self populateSuggestions];
	}
	
	if ([self supportsFooter]) {
		// Reload footer view, in case the user has changed (logged in or unlinked)
		UVFooterView *footer = (UVFooterView *)((UITableView *)self.view).tableFooterView;
		[footer reloadFooter];
	}
}

- (void)didReceiveMemoryWarning {
	// Releases the view if it doesn't have a superview.
    [super didReceiveMemoryWarning];
	
	// Release any cached data, images, etc that aren't in use.
}

- (void)viewDidUnload {
	// Release any retained subviews of the main view.
	// e.g. self.myOutlet = nil;
}


- (void)dealloc {
    [super dealloc];
}


@end
