﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IronScheme.VisualStudio.REPL {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IronScheme.VisualStudio.REPL.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Can not create the IronScheme REPL window..
        /// </summary>
        internal static string CanNotCreateConsole {
            get {
                return ResourceManager.GetString("CanNotCreateConsole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not create the object from the local registry.
        /// </summary>
        internal static string CanNotCreateObject {
            get {
                return ResourceManager.GetString("CanNotCreateObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &gt; .
        /// </summary>
        internal static string DefaultConsolePrompt {
            get {
                return ResourceManager.GetString("DefaultConsolePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to . .
        /// </summary>
        internal static string MultiLineConsolePrompt {
            get {
                return ResourceManager.GetString("MultiLineConsolePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IronScheme REPL.
        /// </summary>
        internal static string ToolWindowTitle {
            get {
                return ResourceManager.GetString("ToolWindowTitle", resourceCulture);
            }
        }
    }
}
