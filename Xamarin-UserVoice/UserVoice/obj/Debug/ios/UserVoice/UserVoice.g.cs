//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace UserVoice {
	[Register("UserVoice", true)]
	public unsafe partial class UserVoice : NSObject {
		[CompilerGenerated]
		const string selBundle = "bundle";
		static readonly IntPtr selBundleHandle = Selector.GetHandle ("bundle");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selGetUserVoiceContactUsFormForModalDisplay = "getUserVoiceContactUsFormForModalDisplay";
		static readonly IntPtr selGetUserVoiceContactUsFormForModalDisplayHandle = Selector.GetHandle ("getUserVoiceContactUsFormForModalDisplay");
		[CompilerGenerated]
		const string selInitialize_ = "initialize:";
		static readonly IntPtr selInitialize_Handle = Selector.GetHandle ("initialize:");
		[CompilerGenerated]
		const string selPresentUserVoiceContactUsFormForParentViewController_ = "presentUserVoiceContactUsFormForParentViewController:";
		static readonly IntPtr selPresentUserVoiceContactUsFormForParentViewController_Handle = Selector.GetHandle ("presentUserVoiceContactUsFormForParentViewController:");
		[CompilerGenerated]
		const string selPresentUserVoiceContactUsFormForParentViewControllerAndConfig_ = "presentUserVoiceContactUsFormForParentViewController:andConfig:";
		static readonly IntPtr selPresentUserVoiceContactUsFormForParentViewControllerAndConfig_Handle = Selector.GetHandle ("presentUserVoiceContactUsFormForParentViewController:andConfig:");
		[CompilerGenerated]
		const string selPresentUserVoiceForumForParentViewController_ = "presentUserVoiceForumForParentViewController:";
		static readonly IntPtr selPresentUserVoiceForumForParentViewController_Handle = Selector.GetHandle ("presentUserVoiceForumForParentViewController:");
		[CompilerGenerated]
		const string selPresentUserVoiceForumForParentViewControllerAndConfig_ = "presentUserVoiceForumForParentViewController:andConfig:";
		static readonly IntPtr selPresentUserVoiceForumForParentViewControllerAndConfig_Handle = Selector.GetHandle ("presentUserVoiceForumForParentViewController:andConfig:");
		[CompilerGenerated]
		const string selPresentUserVoiceInterfaceForParentViewController_ = "presentUserVoiceInterfaceForParentViewController:";
		static readonly IntPtr selPresentUserVoiceInterfaceForParentViewController_Handle = Selector.GetHandle ("presentUserVoiceInterfaceForParentViewController:");
		[CompilerGenerated]
		const string selPresentUserVoiceInterfaceForParentViewControllerAndConfig_ = "presentUserVoiceInterfaceForParentViewController:andConfig:";
		static readonly IntPtr selPresentUserVoiceInterfaceForParentViewControllerAndConfig_Handle = Selector.GetHandle ("presentUserVoiceInterfaceForParentViewController:andConfig:");
		[CompilerGenerated]
		const string selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecret_ = "presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:";
		static readonly IntPtr selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecret_Handle = Selector.GetHandle ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:");
		[CompilerGenerated]
		const string selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecretAndEmailAndDisplayNameAndGUID_ = "presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andEmail:andDisplayName:andGUID:";
		static readonly IntPtr selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecretAndEmailAndDisplayNameAndGUID_Handle = Selector.GetHandle ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andEmail:andDisplayName:andGUID:");
		[CompilerGenerated]
		const string selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecretAndSsoToken_ = "presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andSsoToken:";
		static readonly IntPtr selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecretAndSsoToken_Handle = Selector.GetHandle ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andSsoToken:");
		[CompilerGenerated]
		const string selPresentUserVoiceNewIdeaFormForParentViewController_ = "presentUserVoiceNewIdeaFormForParentViewController:";
		static readonly IntPtr selPresentUserVoiceNewIdeaFormForParentViewController_Handle = Selector.GetHandle ("presentUserVoiceNewIdeaFormForParentViewController:");
		[CompilerGenerated]
		const string selPresentUserVoiceNewIdeaFormForParentViewControllerAndConfig_ = "presentUserVoiceNewIdeaFormForParentViewController:andConfig:";
		static readonly IntPtr selPresentUserVoiceNewIdeaFormForParentViewControllerAndConfig_Handle = Selector.GetHandle ("presentUserVoiceNewIdeaFormForParentViewController:andConfig:");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSetExternalIdForScope_ = "setExternalId:forScope:";
		static readonly IntPtr selSetExternalIdForScope_Handle = Selector.GetHandle ("setExternalId:forScope:");
		[CompilerGenerated]
		const string selTrack_ = "track:";
		static readonly IntPtr selTrack_Handle = Selector.GetHandle ("track:");
		[CompilerGenerated]
		const string selTrackProperties_ = "track:properties:";
		static readonly IntPtr selTrackProperties_Handle = Selector.GetHandle ("track:properties:");
		[CompilerGenerated]
		const string selVersion = "version";
		static readonly IntPtr selVersionHandle = Selector.GetHandle ("version");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UserVoice");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UserVoice () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init), "init");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public UserVoice (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public UserVoice (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public UserVoice (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initialize:")]
		[CompilerGenerated]
		public static void Initialize (UVConfig config)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selInitialize_Handle, config.Handle);
		}
		
		[Export ("presentUserVoiceContactUsFormForParentViewController:")]
		[CompilerGenerated]
		public static void PresentUserVoiceContactUsFormForParentViewController (global::MonoTouch.UIKit.UIViewController parentViewController)
		{
			if (parentViewController == null)
				throw new ArgumentNullException ("parentViewController");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selPresentUserVoiceContactUsFormForParentViewController_Handle, parentViewController.Handle);
		}
		
		[Export ("presentUserVoiceContactUsFormForParentViewController:andConfig:")]
		[CompilerGenerated]
		public static void PresentUserVoiceContactUsFormForParentViewController (global::MonoTouch.UIKit.UIViewController parentViewController, UVConfig config)
		{
			if (parentViewController == null)
				throw new ArgumentNullException ("parentViewController");
			if (config == null)
				throw new ArgumentNullException ("config");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selPresentUserVoiceContactUsFormForParentViewControllerAndConfig_Handle, parentViewController.Handle, config.Handle);
		}
		
		[Export ("presentUserVoiceForumForParentViewController:")]
		[CompilerGenerated]
		public static void PresentUserVoiceForumForParentViewController (global::MonoTouch.UIKit.UIViewController parentViewController)
		{
			if (parentViewController == null)
				throw new ArgumentNullException ("parentViewController");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selPresentUserVoiceForumForParentViewController_Handle, parentViewController.Handle);
		}
		
		[Export ("presentUserVoiceForumForParentViewController:andConfig:")]
		[CompilerGenerated]
		public static void PresentUserVoiceForumForParentViewController (global::MonoTouch.UIKit.UIViewController parentViewController, UVConfig config)
		{
			if (parentViewController == null)
				throw new ArgumentNullException ("parentViewController");
			if (config == null)
				throw new ArgumentNullException ("config");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selPresentUserVoiceForumForParentViewControllerAndConfig_Handle, parentViewController.Handle, config.Handle);
		}
		
		[Export ("presentUserVoiceInterfaceForParentViewController:")]
		[CompilerGenerated]
		public static void PresentUserVoiceInterfaceForParentViewController (global::MonoTouch.UIKit.UIViewController parentViewController)
		{
			if (parentViewController == null)
				throw new ArgumentNullException ("parentViewController");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selPresentUserVoiceInterfaceForParentViewController_Handle, parentViewController.Handle);
		}
		
		[Export ("presentUserVoiceInterfaceForParentViewController:andConfig:")]
		[CompilerGenerated]
		public static void PresentUserVoiceInterfaceForParentViewController (global::MonoTouch.UIKit.UIViewController parentViewController, UVConfig config)
		{
			if (parentViewController == null)
				throw new ArgumentNullException ("parentViewController");
			if (config == null)
				throw new ArgumentNullException ("config");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selPresentUserVoiceInterfaceForParentViewControllerAndConfig_Handle, parentViewController.Handle, config.Handle);
		}
		
		[Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:")]
		[CompilerGenerated]
		public static void PresentUserVoiceModalViewControllerForParent (global::MonoTouch.UIKit.UIViewController viewController, string site, string key, string secret)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (site == null)
				throw new ArgumentNullException ("site");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (secret == null)
				throw new ArgumentNullException ("secret");
			var nssite = NSString.CreateNative (site);
			var nskey = NSString.CreateNative (key);
			var nssecret = NSString.CreateNative (secret);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecret_Handle, viewController.Handle, nssite, nskey, nssecret);
			NSString.ReleaseNative (nssite);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nssecret);
			
		}
		
		[Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andSsoToken:")]
		[CompilerGenerated]
		public static void PresentUserVoiceModalViewControllerForParent (global::MonoTouch.UIKit.UIViewController viewController, string site, string key, string secret, string token)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (site == null)
				throw new ArgumentNullException ("site");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (secret == null)
				throw new ArgumentNullException ("secret");
			if (token == null)
				throw new ArgumentNullException ("token");
			var nssite = NSString.CreateNative (site);
			var nskey = NSString.CreateNative (key);
			var nssecret = NSString.CreateNative (secret);
			var nstoken = NSString.CreateNative (token);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecretAndSsoToken_Handle, viewController.Handle, nssite, nskey, nssecret, nstoken);
			NSString.ReleaseNative (nssite);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nssecret);
			NSString.ReleaseNative (nstoken);
			
		}
		
		[Export ("presentUserVoiceModalViewControllerForParent:andSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		[CompilerGenerated]
		public static void PresentUserVoiceModalViewControllerForParent (global::MonoTouch.UIKit.UIViewController viewController, string site, string key, string secret, string email, string displayName, string guid)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (site == null)
				throw new ArgumentNullException ("site");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (secret == null)
				throw new ArgumentNullException ("secret");
			if (email == null)
				throw new ArgumentNullException ("email");
			if (displayName == null)
				throw new ArgumentNullException ("displayName");
			if (guid == null)
				throw new ArgumentNullException ("guid");
			var nssite = NSString.CreateNative (site);
			var nskey = NSString.CreateNative (key);
			var nssecret = NSString.CreateNative (secret);
			var nsemail = NSString.CreateNative (email);
			var nsdisplayName = NSString.CreateNative (displayName);
			var nsguid = NSString.CreateNative (guid);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selPresentUserVoiceModalViewControllerForParentAndSiteAndKeyAndSecretAndEmailAndDisplayNameAndGUID_Handle, viewController.Handle, nssite, nskey, nssecret, nsemail, nsdisplayName, nsguid);
			NSString.ReleaseNative (nssite);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nssecret);
			NSString.ReleaseNative (nsemail);
			NSString.ReleaseNative (nsdisplayName);
			NSString.ReleaseNative (nsguid);
			
		}
		
		[Export ("presentUserVoiceNewIdeaFormForParentViewController:")]
		[CompilerGenerated]
		public static void PresentUserVoiceNewIdeaFormForParentViewController (global::MonoTouch.UIKit.UIViewController parentViewController)
		{
			if (parentViewController == null)
				throw new ArgumentNullException ("parentViewController");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selPresentUserVoiceNewIdeaFormForParentViewController_Handle, parentViewController.Handle);
		}
		
		[Export ("presentUserVoiceNewIdeaFormForParentViewController:andConfig:")]
		[CompilerGenerated]
		public static void PresentUserVoiceNewIdeaFormForParentViewController (global::MonoTouch.UIKit.UIViewController parentViewController, UVConfig config)
		{
			if (parentViewController == null)
				throw new ArgumentNullException ("parentViewController");
			if (config == null)
				throw new ArgumentNullException ("config");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selPresentUserVoiceNewIdeaFormForParentViewControllerAndConfig_Handle, parentViewController.Handle, config.Handle);
		}
		
		[Export ("setExternalId:forScope:")]
		[CompilerGenerated]
		public static void SetExternalId (string identifier, string scope)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (scope == null)
				throw new ArgumentNullException ("scope");
			var nsidentifier = NSString.CreateNative (identifier);
			var nsscope = NSString.CreateNative (scope);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selSetExternalIdForScope_Handle, nsidentifier, nsscope);
			NSString.ReleaseNative (nsidentifier);
			NSString.ReleaseNative (nsscope);
			
		}
		
		[Export ("track:")]
		[CompilerGenerated]
		public static void Track (string e)
		{
			if (e == null)
				throw new ArgumentNullException ("e");
			var nse = NSString.CreateNative (e);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selTrack_Handle, nse);
			NSString.ReleaseNative (nse);
			
		}
		
		[Export ("track:properties:")]
		[CompilerGenerated]
		public static void Track (string e, NSDictionary properties)
		{
			if (e == null)
				throw new ArgumentNullException ("e");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nse = NSString.CreateNative (e);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selTrackProperties_Handle, nse, properties.Handle);
			NSString.ReleaseNative (nse);
			
		}
		
		[CompilerGenerated]
		static object __mt_Bundle_var_static;
		[CompilerGenerated]
		public static NSBundle Bundle {
			[Export ("bundle")]
			get {
				NSBundle ret;
				ret =  Runtime.GetNSObject<NSBundle> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selBundleHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Bundle_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_Delegate_var_static;
		[CompilerGenerated]
		public static UVDelegate Delegate {
			[Export ("delegate")]
			get {
				UVDelegate ret;
				ret =  Runtime.GetNSObject<UVDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDelegateHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Delegate_var_static = ret;
				return ret;
			}
			
			[Export ("setDelegate:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetDelegate_Handle, value.Handle);
			}
		}
		
		[CompilerGenerated]
		static object __mt_GetUserVoiceContactUsFormForModalDisplay_var_static;
		[CompilerGenerated]
		public static global::MonoTouch.UIKit.UIViewController GetUserVoiceContactUsFormForModalDisplay {
			[Export ("getUserVoiceContactUsFormForModalDisplay")]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGetUserVoiceContactUsFormForModalDisplayHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_GetUserVoiceContactUsFormForModalDisplay_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static string Version {
			[Export ("version")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selVersionHandle));
			}
			
		}
		
	} /* class UserVoice */
}
