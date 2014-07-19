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
	[Register("UVStyleSheet", true)]
	public unsafe partial class UVStyleSheet : NSObject {
		[CompilerGenerated]
		const string selInstance = "instance";
		static readonly IntPtr selInstanceHandle = Selector.GetHandle ("instance");
		[CompilerGenerated]
		const string selLoadingViewBackgroundColor = "loadingViewBackgroundColor";
		static readonly IntPtr selLoadingViewBackgroundColorHandle = Selector.GetHandle ("loadingViewBackgroundColor");
		[CompilerGenerated]
		const string selNavigationBarActivityIndicatorColor = "navigationBarActivityIndicatorColor";
		static readonly IntPtr selNavigationBarActivityIndicatorColorHandle = Selector.GetHandle ("navigationBarActivityIndicatorColor");
		[CompilerGenerated]
		const string selNavigationBarBackgroundColor = "navigationBarBackgroundColor";
		static readonly IntPtr selNavigationBarBackgroundColorHandle = Selector.GetHandle ("navigationBarBackgroundColor");
		[CompilerGenerated]
		const string selNavigationBarBackgroundImage = "navigationBarBackgroundImage";
		static readonly IntPtr selNavigationBarBackgroundImageHandle = Selector.GetHandle ("navigationBarBackgroundImage");
		[CompilerGenerated]
		const string selNavigationBarFont = "navigationBarFont";
		static readonly IntPtr selNavigationBarFontHandle = Selector.GetHandle ("navigationBarFont");
		[CompilerGenerated]
		const string selNavigationBarTextColor = "navigationBarTextColor";
		static readonly IntPtr selNavigationBarTextColorHandle = Selector.GetHandle ("navigationBarTextColor");
		[CompilerGenerated]
		const string selNavigationBarTextShadowColor = "navigationBarTextShadowColor";
		static readonly IntPtr selNavigationBarTextShadowColorHandle = Selector.GetHandle ("navigationBarTextShadowColor");
		[CompilerGenerated]
		const string selNavigationBarTintColor = "navigationBarTintColor";
		static readonly IntPtr selNavigationBarTintColorHandle = Selector.GetHandle ("navigationBarTintColor");
		[CompilerGenerated]
		const string selPreferredStatusBarStyle = "preferredStatusBarStyle";
		static readonly IntPtr selPreferredStatusBarStyleHandle = Selector.GetHandle ("preferredStatusBarStyle");
		[CompilerGenerated]
		const string selSetLoadingViewBackgroundColor_ = "setLoadingViewBackgroundColor:";
		static readonly IntPtr selSetLoadingViewBackgroundColor_Handle = Selector.GetHandle ("setLoadingViewBackgroundColor:");
		[CompilerGenerated]
		const string selSetNavigationBarActivityIndicatorColor_ = "setNavigationBarActivityIndicatorColor:";
		static readonly IntPtr selSetNavigationBarActivityIndicatorColor_Handle = Selector.GetHandle ("setNavigationBarActivityIndicatorColor:");
		[CompilerGenerated]
		const string selSetNavigationBarBackgroundColor_ = "setNavigationBarBackgroundColor:";
		static readonly IntPtr selSetNavigationBarBackgroundColor_Handle = Selector.GetHandle ("setNavigationBarBackgroundColor:");
		[CompilerGenerated]
		const string selSetNavigationBarBackgroundImage_ = "setNavigationBarBackgroundImage:";
		static readonly IntPtr selSetNavigationBarBackgroundImage_Handle = Selector.GetHandle ("setNavigationBarBackgroundImage:");
		[CompilerGenerated]
		const string selSetNavigationBarFont_ = "setNavigationBarFont:";
		static readonly IntPtr selSetNavigationBarFont_Handle = Selector.GetHandle ("setNavigationBarFont:");
		[CompilerGenerated]
		const string selSetNavigationBarTextColor_ = "setNavigationBarTextColor:";
		static readonly IntPtr selSetNavigationBarTextColor_Handle = Selector.GetHandle ("setNavigationBarTextColor:");
		[CompilerGenerated]
		const string selSetNavigationBarTextShadowColor_ = "setNavigationBarTextShadowColor:";
		static readonly IntPtr selSetNavigationBarTextShadowColor_Handle = Selector.GetHandle ("setNavigationBarTextShadowColor:");
		[CompilerGenerated]
		const string selSetNavigationBarTintColor_ = "setNavigationBarTintColor:";
		static readonly IntPtr selSetNavigationBarTintColor_Handle = Selector.GetHandle ("setNavigationBarTintColor:");
		[CompilerGenerated]
		const string selSetPreferredStatusBarStyle_ = "setPreferredStatusBarStyle:";
		static readonly IntPtr selSetPreferredStatusBarStyle_Handle = Selector.GetHandle ("setPreferredStatusBarStyle:");
		[CompilerGenerated]
		const string selSetTableViewBackgroundColor_ = "setTableViewBackgroundColor:";
		static readonly IntPtr selSetTableViewBackgroundColor_Handle = Selector.GetHandle ("setTableViewBackgroundColor:");
		[CompilerGenerated]
		const string selSetTintColor_ = "setTintColor:";
		static readonly IntPtr selSetTintColor_Handle = Selector.GetHandle ("setTintColor:");
		[CompilerGenerated]
		const string selTableViewBackgroundColor = "tableViewBackgroundColor";
		static readonly IntPtr selTableViewBackgroundColorHandle = Selector.GetHandle ("tableViewBackgroundColor");
		[CompilerGenerated]
		const string selTintColor = "tintColor";
		static readonly IntPtr selTintColorHandle = Selector.GetHandle ("tintColor");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UVStyleSheet");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UVStyleSheet () : base (NSObjectFlag.Empty)
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
		public UVStyleSheet (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public UVStyleSheet (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public UVStyleSheet (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_Instance_var_static;
		[CompilerGenerated]
		public static UVStyleSheet Instance {
			[Export ("instance")]
			get {
				UVStyleSheet ret;
				ret =  Runtime.GetNSObject<UVStyleSheet> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selInstanceHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Instance_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_LoadingViewBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor LoadingViewBackgroundColor {
			[Export ("loadingViewBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLoadingViewBackgroundColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLoadingViewBackgroundColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LoadingViewBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setLoadingViewBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLoadingViewBackgroundColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLoadingViewBackgroundColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LoadingViewBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_NavigationBarActivityIndicatorColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor NavigationBarActivityIndicatorColor {
			[Export ("navigationBarActivityIndicatorColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNavigationBarActivityIndicatorColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNavigationBarActivityIndicatorColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarActivityIndicatorColor_var = ret;
				return ret;
			}
			
			[Export ("setNavigationBarActivityIndicatorColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNavigationBarActivityIndicatorColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNavigationBarActivityIndicatorColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarActivityIndicatorColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_NavigationBarBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor NavigationBarBackgroundColor {
			[Export ("navigationBarBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNavigationBarBackgroundColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNavigationBarBackgroundColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setNavigationBarBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNavigationBarBackgroundColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNavigationBarBackgroundColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_NavigationBarBackgroundImage_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage NavigationBarBackgroundImage {
			[Export ("navigationBarBackgroundImage", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNavigationBarBackgroundImageHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNavigationBarBackgroundImageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarBackgroundImage_var = ret;
				return ret;
			}
			
			[Export ("setNavigationBarBackgroundImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNavigationBarBackgroundImage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNavigationBarBackgroundImage_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarBackgroundImage_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_NavigationBarFont_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIFont NavigationBarFont {
			[Export ("navigationBarFont", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIFont> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNavigationBarFontHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIFont> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNavigationBarFontHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarFont_var = ret;
				return ret;
			}
			
			[Export ("setNavigationBarFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNavigationBarFont_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNavigationBarFont_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarFont_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_NavigationBarTextColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor NavigationBarTextColor {
			[Export ("navigationBarTextColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNavigationBarTextColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNavigationBarTextColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarTextColor_var = ret;
				return ret;
			}
			
			[Export ("setNavigationBarTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNavigationBarTextColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNavigationBarTextColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarTextColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_NavigationBarTextShadowColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor NavigationBarTextShadowColor {
			[Export ("navigationBarTextShadowColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNavigationBarTextShadowColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNavigationBarTextShadowColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarTextShadowColor_var = ret;
				return ret;
			}
			
			[Export ("setNavigationBarTextShadowColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNavigationBarTextShadowColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNavigationBarTextShadowColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarTextShadowColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_NavigationBarTintColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor NavigationBarTintColor {
			[Export ("navigationBarTintColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNavigationBarTintColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNavigationBarTintColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarTintColor_var = ret;
				return ret;
			}
			
			[Export ("setNavigationBarTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNavigationBarTintColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNavigationBarTintColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_NavigationBarTintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIStatusBarStyle PreferredStatusBarStyle {
			[Export ("preferredStatusBarStyle")]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selPreferredStatusBarStyleHandle);
				} else {
					return (global::MonoTouch.UIKit.UIStatusBarStyle) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selPreferredStatusBarStyleHandle);
				}
			}
			
			[Export ("setPreferredStatusBarStyle:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetPreferredStatusBarStyle_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetPreferredStatusBarStyle_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TableViewBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor TableViewBackgroundColor {
			[Export ("tableViewBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTableViewBackgroundColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTableViewBackgroundColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TableViewBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setTableViewBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTableViewBackgroundColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTableViewBackgroundColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TableViewBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TintColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor TintColor {
			[Export ("tintColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTintColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTintColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TintColor_var = ret;
				return ret;
			}
			
			[Export ("setTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTintColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTintColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LoadingViewBackgroundColor_var = null;
				__mt_NavigationBarActivityIndicatorColor_var = null;
				__mt_NavigationBarBackgroundColor_var = null;
				__mt_NavigationBarBackgroundImage_var = null;
				__mt_NavigationBarFont_var = null;
				__mt_NavigationBarTextColor_var = null;
				__mt_NavigationBarTextShadowColor_var = null;
				__mt_NavigationBarTintColor_var = null;
				__mt_TableViewBackgroundColor_var = null;
				__mt_TintColor_var = null;
			}
		}
	} /* class UVStyleSheet */
}
