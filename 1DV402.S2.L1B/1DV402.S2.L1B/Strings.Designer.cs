﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1DV402.S2.L1B {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("_1DV402.S2.L1B.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Gissning {0}:.
        /// </summary>
        internal static string guess_prompt {
            get {
                return ResourceManager.GetString("guess_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Du har redan gissat på {0}, gör om gissningen!.
        /// </summary>
        internal static string old_guess_prompt {
            get {
                return ResourceManager.GetString("old_guess_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RÄTT GISSAT! Du klarade det på {0} försök..
        /// </summary>
        internal static string right_prompt {
            get {
                return ResourceManager.GetString("right_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} är för högt. Du har {1} gissningar kvar..
        /// </summary>
        internal static string to_high_prompt {
            get {
                return ResourceManager.GetString("to_high_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} är för lågt. Du har {1} gissningar kvar..
        /// </summary>
        internal static string to_low_prompt {
            get {
                return ResourceManager.GetString("to_low_prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Det hemliga talet var {0}..
        /// </summary>
        internal static string wrong_prompt {
            get {
                return ResourceManager.GetString("wrong_prompt", resourceCulture);
            }
        }
    }
}
