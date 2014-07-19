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
	[Register("UVConfig", true)]
	public unsafe partial class UVConfig : NSObject {
		[CompilerGenerated]
		const string selAddAttachmentNamedContentTypeBase64EncodedData_ = "addAttachmentNamed:contentType:base64EncodedData:";
		static readonly IntPtr selAddAttachmentNamedContentTypeBase64EncodedData_Handle = Selector.GetHandle ("addAttachmentNamed:contentType:base64EncodedData:");
		[CompilerGenerated]
		const string selAttachments = "attachments";
		static readonly IntPtr selAttachmentsHandle = Selector.GetHandle ("attachments");
		[CompilerGenerated]
		const string selConfigWithSite_ = "configWithSite:";
		static readonly IntPtr selConfigWithSite_Handle = Selector.GetHandle ("configWithSite:");
		[CompilerGenerated]
		const string selConfigWithSiteAndKeyAndSecret_ = "configWithSite:andKey:andSecret:";
		static readonly IntPtr selConfigWithSiteAndKeyAndSecret_Handle = Selector.GetHandle ("configWithSite:andKey:andSecret:");
		[CompilerGenerated]
		const string selConfigWithSiteAndKeyAndSecretAndEmailAndDisplayNameAndGUID_ = "configWithSite:andKey:andSecret:andEmail:andDisplayName:andGUID:";
		static readonly IntPtr selConfigWithSiteAndKeyAndSecretAndEmailAndDisplayNameAndGUID_Handle = Selector.GetHandle ("configWithSite:andKey:andSecret:andEmail:andDisplayName:andGUID:");
		[CompilerGenerated]
		const string selConfigWithSiteAndKeyAndSecretAndSSOToken_ = "configWithSite:andKey:andSecret:andSSOToken:";
		static readonly IntPtr selConfigWithSiteAndKeyAndSecretAndSSOToken_Handle = Selector.GetHandle ("configWithSite:andKey:andSecret:andSSOToken:");
		[CompilerGenerated]
		const string selCustomFields = "customFields";
		static readonly IntPtr selCustomFieldsHandle = Selector.GetHandle ("customFields");
		[CompilerGenerated]
		const string selDisplayName = "displayName";
		static readonly IntPtr selDisplayNameHandle = Selector.GetHandle ("displayName");
		[CompilerGenerated]
		const string selEmail = "email";
		static readonly IntPtr selEmailHandle = Selector.GetHandle ("email");
		[CompilerGenerated]
		const string selExtraTicketInfo = "extraTicketInfo";
		static readonly IntPtr selExtraTicketInfoHandle = Selector.GetHandle ("extraTicketInfo");
		[CompilerGenerated]
		const string selForumId = "forumId";
		static readonly IntPtr selForumIdHandle = Selector.GetHandle ("forumId");
		[CompilerGenerated]
		const string selGuid = "guid";
		static readonly IntPtr selGuidHandle = Selector.GetHandle ("guid");
		[CompilerGenerated]
		const string selIdentifyUserWithEmailNameGuid_ = "identifyUserWithEmail:name:guid:";
		static readonly IntPtr selIdentifyUserWithEmailNameGuid_Handle = Selector.GetHandle ("identifyUserWithEmail:name:guid:");
		[CompilerGenerated]
		const string selKey = "key";
		static readonly IntPtr selKeyHandle = Selector.GetHandle ("key");
		[CompilerGenerated]
		const string selSecret = "secret";
		static readonly IntPtr selSecretHandle = Selector.GetHandle ("secret");
		[CompilerGenerated]
		const string selSetCustomFields_ = "setCustomFields:";
		static readonly IntPtr selSetCustomFields_Handle = Selector.GetHandle ("setCustomFields:");
		[CompilerGenerated]
		const string selSetDisplayName_ = "setDisplayName:";
		static readonly IntPtr selSetDisplayName_Handle = Selector.GetHandle ("setDisplayName:");
		[CompilerGenerated]
		const string selSetEmail_ = "setEmail:";
		static readonly IntPtr selSetEmail_Handle = Selector.GetHandle ("setEmail:");
		[CompilerGenerated]
		const string selSetExtraTicketInfo_ = "setExtraTicketInfo:";
		static readonly IntPtr selSetExtraTicketInfo_Handle = Selector.GetHandle ("setExtraTicketInfo:");
		[CompilerGenerated]
		const string selSetForumId_ = "setForumId:";
		static readonly IntPtr selSetForumId_Handle = Selector.GetHandle ("setForumId:");
		[CompilerGenerated]
		const string selSetGuid_ = "setGuid:";
		static readonly IntPtr selSetGuid_Handle = Selector.GetHandle ("setGuid:");
		[CompilerGenerated]
		const string selSetKey_ = "setKey:";
		static readonly IntPtr selSetKey_Handle = Selector.GetHandle ("setKey:");
		[CompilerGenerated]
		const string selSetSecret_ = "setSecret:";
		static readonly IntPtr selSetSecret_Handle = Selector.GetHandle ("setSecret:");
		[CompilerGenerated]
		const string selSetShowContactUs_ = "setShowContactUs:";
		static readonly IntPtr selSetShowContactUs_Handle = Selector.GetHandle ("setShowContactUs:");
		[CompilerGenerated]
		const string selSetShowForum_ = "setShowForum:";
		static readonly IntPtr selSetShowForum_Handle = Selector.GetHandle ("setShowForum:");
		[CompilerGenerated]
		const string selSetShowKnowledgeBase_ = "setShowKnowledgeBase:";
		static readonly IntPtr selSetShowKnowledgeBase_Handle = Selector.GetHandle ("setShowKnowledgeBase:");
		[CompilerGenerated]
		const string selSetShowPostIdea_ = "setShowPostIdea:";
		static readonly IntPtr selSetShowPostIdea_Handle = Selector.GetHandle ("setShowPostIdea:");
		[CompilerGenerated]
		const string selSetSite_ = "setSite:";
		static readonly IntPtr selSetSite_Handle = Selector.GetHandle ("setSite:");
		[CompilerGenerated]
		const string selSetSsoToken_ = "setSsoToken:";
		static readonly IntPtr selSetSsoToken_Handle = Selector.GetHandle ("setSsoToken:");
		[CompilerGenerated]
		const string selSetTopicId_ = "setTopicId:";
		static readonly IntPtr selSetTopicId_Handle = Selector.GetHandle ("setTopicId:");
		[CompilerGenerated]
		const string selSetUserTraits_ = "setUserTraits:";
		static readonly IntPtr selSetUserTraits_Handle = Selector.GetHandle ("setUserTraits:");
		[CompilerGenerated]
		const string selShowContactUs = "showContactUs";
		static readonly IntPtr selShowContactUsHandle = Selector.GetHandle ("showContactUs");
		[CompilerGenerated]
		const string selShowForum = "showForum";
		static readonly IntPtr selShowForumHandle = Selector.GetHandle ("showForum");
		[CompilerGenerated]
		const string selShowKnowledgeBase = "showKnowledgeBase";
		static readonly IntPtr selShowKnowledgeBaseHandle = Selector.GetHandle ("showKnowledgeBase");
		[CompilerGenerated]
		const string selShowPostIdea = "showPostIdea";
		static readonly IntPtr selShowPostIdeaHandle = Selector.GetHandle ("showPostIdea");
		[CompilerGenerated]
		const string selSite = "site";
		static readonly IntPtr selSiteHandle = Selector.GetHandle ("site");
		[CompilerGenerated]
		const string selSsoToken = "ssoToken";
		static readonly IntPtr selSsoTokenHandle = Selector.GetHandle ("ssoToken");
		[CompilerGenerated]
		const string selTopicId = "topicId";
		static readonly IntPtr selTopicIdHandle = Selector.GetHandle ("topicId");
		[CompilerGenerated]
		const string selTraits = "traits";
		static readonly IntPtr selTraitsHandle = Selector.GetHandle ("traits");
		[CompilerGenerated]
		const string selUserTraits = "userTraits";
		static readonly IntPtr selUserTraitsHandle = Selector.GetHandle ("userTraits");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UVConfig");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UVConfig () : base (NSObjectFlag.Empty)
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
		public UVConfig (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public UVConfig (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public UVConfig (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addAttachmentNamed:contentType:base64EncodedData:")]
		[CompilerGenerated]
		public virtual void AddAttachmentNamed (string fileName, string contentType, string data)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			if (contentType == null)
				throw new ArgumentNullException ("contentType");
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsfileName = NSString.CreateNative (fileName);
			var nscontentType = NSString.CreateNative (contentType);
			var nsdata = NSString.CreateNative (data);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selAddAttachmentNamedContentTypeBase64EncodedData_Handle, nsfileName, nscontentType, nsdata);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selAddAttachmentNamedContentTypeBase64EncodedData_Handle, nsfileName, nscontentType, nsdata);
			}
			NSString.ReleaseNative (nsfileName);
			NSString.ReleaseNative (nscontentType);
			NSString.ReleaseNative (nsdata);
			
		}
		
		[Export ("configWithSite:")]
		[CompilerGenerated]
		public static UVConfig ConfigWithSite (string site)
		{
			if (site == null)
				throw new ArgumentNullException ("site");
			var nssite = NSString.CreateNative (site);
			
			UVConfig ret;
			ret =  Runtime.GetNSObject<UVConfig> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selConfigWithSite_Handle, nssite));
			NSString.ReleaseNative (nssite);
			
			return ret;
		}
		
		[Export ("configWithSite:andKey:andSecret:")]
		[CompilerGenerated]
		public static UVConfig ConfigWithSite (string site, string key, string secret)
		{
			if (site == null)
				throw new ArgumentNullException ("site");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (secret == null)
				throw new ArgumentNullException ("secret");
			var nssite = NSString.CreateNative (site);
			var nskey = NSString.CreateNative (key);
			var nssecret = NSString.CreateNative (secret);
			
			UVConfig ret;
			ret =  Runtime.GetNSObject<UVConfig> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selConfigWithSiteAndKeyAndSecret_Handle, nssite, nskey, nssecret));
			NSString.ReleaseNative (nssite);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nssecret);
			
			return ret;
		}
		
		[Export ("configWithSite:andKey:andSecret:andSSOToken:")]
		[CompilerGenerated]
		public static UVConfig ConfigWithSite (string site, string key, string secret, string token)
		{
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
			
			UVConfig ret;
			ret =  Runtime.GetNSObject<UVConfig> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selConfigWithSiteAndKeyAndSecretAndSSOToken_Handle, nssite, nskey, nssecret, nstoken));
			NSString.ReleaseNative (nssite);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nssecret);
			NSString.ReleaseNative (nstoken);
			
			return ret;
		}
		
		[Export ("configWithSite:andKey:andSecret:andEmail:andDisplayName:andGUID:")]
		[CompilerGenerated]
		public static UVConfig ConfigWithSite (string site, string key, string secret, string email, string displayName, string guid)
		{
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
			
			UVConfig ret;
			ret =  Runtime.GetNSObject<UVConfig> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selConfigWithSiteAndKeyAndSecretAndEmailAndDisplayNameAndGUID_Handle, nssite, nskey, nssecret, nsemail, nsdisplayName, nsguid));
			NSString.ReleaseNative (nssite);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nssecret);
			NSString.ReleaseNative (nsemail);
			NSString.ReleaseNative (nsdisplayName);
			NSString.ReleaseNative (nsguid);
			
			return ret;
		}
		
		[Export ("identifyUserWithEmail:name:guid:")]
		[CompilerGenerated]
		public virtual void IdentifyUserWithEmail (string email, string name, string guid)
		{
			if (email == null)
				throw new ArgumentNullException ("email");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (guid == null)
				throw new ArgumentNullException ("guid");
			var nsemail = NSString.CreateNative (email);
			var nsname = NSString.CreateNative (name);
			var nsguid = NSString.CreateNative (guid);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selIdentifyUserWithEmailNameGuid_Handle, nsemail, nsname, nsguid);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selIdentifyUserWithEmailNameGuid_Handle, nsemail, nsname, nsguid);
			}
			NSString.ReleaseNative (nsemail);
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsguid);
			
		}
		
		[CompilerGenerated]
		object __mt_Attachments_var;
		[CompilerGenerated]
		public virtual NSObject[] Attachments {
			[Export ("attachments")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAttachmentsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAttachmentsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Attachments_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_CustomFields_var;
		[CompilerGenerated]
		public virtual NSDictionary CustomFields {
			[Export ("customFields", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomFieldsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomFieldsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomFields_var = ret;
				return ret;
			}
			
			[Export ("setCustomFields:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCustomFields_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCustomFields_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_CustomFields_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string DisplayName {
			[Export ("displayName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDisplayNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDisplayNameHandle));
				}
			}
			
			[Export ("setDisplayName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDisplayName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDisplayName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Email {
			[Export ("email", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEmailHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selEmailHandle));
				}
			}
			
			[Export ("setEmail:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetEmail_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetEmail_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ExtraTicketInfo {
			[Export ("extraTicketInfo", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selExtraTicketInfoHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selExtraTicketInfoHandle));
				}
			}
			
			[Export ("setExtraTicketInfo:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetExtraTicketInfo_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetExtraTicketInfo_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int ForumId {
			[Export ("forumId")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selForumIdHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selForumIdHandle);
				}
			}
			
			[Export ("setForumId:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetForumId_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetForumId_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Guid {
			[Export ("guid", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGuidHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGuidHandle));
				}
			}
			
			[Export ("setGuid:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetGuid_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetGuid_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Key {
			[Export ("key", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKeyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKeyHandle));
				}
			}
			
			[Export ("setKey:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetKey_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetKey_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Secret {
			[Export ("secret", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSecretHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSecretHandle));
				}
			}
			
			[Export ("setSecret:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSecret_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSecret_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowContactUs {
			[Export ("showContactUs")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowContactUsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowContactUsHandle);
				}
			}
			
			[Export ("setShowContactUs:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowContactUs_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowContactUs_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowForum {
			[Export ("showForum")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowForumHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowForumHandle);
				}
			}
			
			[Export ("setShowForum:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowForum_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowForum_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowKnowledgeBase {
			[Export ("showKnowledgeBase")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowKnowledgeBaseHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowKnowledgeBaseHandle);
				}
			}
			
			[Export ("setShowKnowledgeBase:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowKnowledgeBase_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowKnowledgeBase_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowPostIdea {
			[Export ("showPostIdea")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowPostIdeaHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowPostIdeaHandle);
				}
			}
			
			[Export ("setShowPostIdea:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowPostIdea_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowPostIdea_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Site {
			[Export ("site", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSiteHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSiteHandle));
				}
			}
			
			[Export ("setSite:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSite_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSite_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string SsoToken {
			[Export ("ssoToken", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSsoTokenHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSsoTokenHandle));
				}
			}
			
			[Export ("setSsoToken:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSsoToken_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSsoToken_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int TopicId {
			[Export ("topicId")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTopicIdHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTopicIdHandle);
				}
			}
			
			[Export ("setTopicId:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetTopicId_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetTopicId_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Traits_var;
		[CompilerGenerated]
		public virtual NSDictionary Traits {
			[Export ("traits")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTraitsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTraitsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Traits_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_UserTraits_var;
		[CompilerGenerated]
		public virtual NSDictionary UserTraits {
			[Export ("userTraits", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserTraitsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserTraitsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserTraits_var = ret;
				return ret;
			}
			
			[Export ("setUserTraits:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserTraits_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserTraits_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserTraits_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Attachments_var = null;
				__mt_CustomFields_var = null;
				__mt_Traits_var = null;
				__mt_UserTraits_var = null;
			}
		}
	} /* class UVConfig */
}
