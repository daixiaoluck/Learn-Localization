﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearnGlobalization.App_LocalResources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Contacts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Contacts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LearnGlobalization.App_LocalResources.Contacts", typeof(Contacts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-mail地址.
        /// </summary>
        public static string EmailAddress {
            get {
                return ResourceManager.GetString("EmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-mail內容.
        /// </summary>
        public static string EmailContent {
            get {
                return ResourceManager.GetString("EmailContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 請填充{0}.
        /// </summary>
        public static string Please_fill_this_field_in {
            get {
                return ResourceManager.GetString("Please_fill_this_field_in", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 請輸入一個{0}.
        /// </summary>
        public static string Please_input_an_email_address {
            get {
                return ResourceManager.GetString("Please_input_an_email_address", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}超過{1}.
        /// </summary>
        public static string Your_input_is_too_long {
            get {
                return ResourceManager.GetString("Your_input_is_too_long", resourceCulture);
            }
        }
    }
}
