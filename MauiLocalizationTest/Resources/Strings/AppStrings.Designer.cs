﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MauiLocalizationTest.Resources.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MauiLocalizationTest.Resources.Strings.AppStrings", typeof(AppStrings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click me.
        /// </summary>
        internal static string BTN_CLICK_ME {
            get {
                return ResourceManager.GetString("BTN_CLICK_ME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clicked {0} time.
        /// </summary>
        internal static string BTN_CLICKED_1_TIME {
            get {
                return ResourceManager.GetString("BTN_CLICKED_1_TIME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clicked {0} times.
        /// </summary>
        internal static string BTN_CLICKED_N_TIMES {
            get {
                return ResourceManager.GetString("BTN_CLICKED_N_TIMES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hello, World!.
        /// </summary>
        internal static string LBL_HELLO_WORLD {
            get {
                return ResourceManager.GetString("LBL_HELLO_WORLD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to .NET Multi-platform App UI.
        /// </summary>
        internal static string LBL_WELCOME {
            get {
                return ResourceManager.GetString("LBL_WELCOME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Home.
        /// </summary>
        internal static string MAIN_PAGE_TITLE {
            get {
                return ResourceManager.GetString("MAIN_PAGE_TITLE", resourceCulture);
            }
        }
    }
}
