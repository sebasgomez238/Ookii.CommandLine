﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ookii.CommandLine.Generator.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ookii.CommandLine.Generator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The command line arguments class {0} may not be a generic class when the GeneratedParserAttribute is used..
        /// </summary>
        internal static string ArgumentsClassIsGenericMessageFormat {
            get {
                return ResourceManager.GetString("ArgumentsClassIsGenericMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments class may not be a generic type..
        /// </summary>
        internal static string ArgumentsClassIsGenericTitle {
            get {
                return ResourceManager.GetString("ArgumentsClassIsGenericTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments class {0} may not be nested in another type when the GeneratedParserAttribute is used..
        /// </summary>
        internal static string ArgumentsClassIsNestedMessageFormat {
            get {
                return ResourceManager.GetString("ArgumentsClassIsNestedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments class may not be a nested type..
        /// </summary>
        internal static string ArgumentsClassIsNestedTitle {
            get {
                return ResourceManager.GetString("ArgumentsClassIsNestedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments class {0} must use the &apos;partial&apos; modifier..
        /// </summary>
        internal static string ArgumentsClassNotPartialMessageFormat {
            get {
                return ResourceManager.GetString("ArgumentsClassNotPartialMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments class must be a partial class..
        /// </summary>
        internal static string ArgumentsClassNotPartialTitle {
            get {
                return ResourceManager.GetString("ArgumentsClassNotPartialTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments type {0} must be a reference type (class)..
        /// </summary>
        internal static string ArgumentsTypeNotReferenceTypeMessageFormat {
            get {
                return ResourceManager.GetString("ArgumentsTypeNotReferenceTypeMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments type must be a reference type..
        /// </summary>
        internal static string ArgumentsTypeNotReferenceTypeTitle {
            get {
                return ResourceManager.GetString("ArgumentsTypeNotReferenceTypeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments class {0} has the CommandAttribute but does not implement the ICommand interface..
        /// </summary>
        internal static string CommandAttributeWithoutInterfaceMessageFormat {
            get {
                return ResourceManager.GetString("CommandAttributeWithoutInterfaceMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments class has the CommandAttribute but does not implement ICommand..
        /// </summary>
        internal static string CommandAttributeWithoutInterfaceTitle {
            get {
                return ResourceManager.GetString("CommandAttributeWithoutInterfaceTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The multi-value command line argument defined by {0}.{1} must have an array rank of one..
        /// </summary>
        internal static string InvalidArrayRankMessageFormat {
            get {
                return ResourceManager.GetString("InvalidArrayRankMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A multi-value command line argument defined by an array properties must have an array rank of one..
        /// </summary>
        internal static string InvalidArrayRankTitle {
            get {
                return ResourceManager.GetString("InvalidArrayRankTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method {0}.{1} does not have a valid signature for a command line argument..
        /// </summary>
        internal static string InvalidMethodSignatureMessageFormat {
            get {
                return ResourceManager.GetString("InvalidMethodSignatureMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A method command line argument has an invalid signature..
        /// </summary>
        internal static string InvalidMethodSignatureTitle {
            get {
                return ResourceManager.GetString("InvalidMethodSignatureTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No command line argument converter exists for type {0} used by the argument defined by {1}.{2}, and none could be generated. Use the Ookii.CommandLine.Conversion.ArgumentConverterAttribute to specify a custom converter..
        /// </summary>
        internal static string NoConverterMessageFormat {
            get {
                return ResourceManager.GetString("NoConverterMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No acommand line rgument converter exists for the argument&apos;s type..
        /// </summary>
        internal static string NoConverterTitle {
            get {
                return ResourceManager.GetString("NoConverterTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0}.{1} will not create a command line argument because it is not a public instance property..
        /// </summary>
        internal static string NonPublicInstancePropertyMessageFormat {
            get {
                return ResourceManager.GetString("NonPublicInstancePropertyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Properties that are not public instance will be ignored..
        /// </summary>
        internal static string NonPublicInstancePropertyTitle {
            get {
                return ResourceManager.GetString("NonPublicInstancePropertyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method {0}.{1} will not create a command line argument because it is not a public static method..
        /// </summary>
        internal static string NonPublicStaticMethodMessageFormat {
            get {
                return ResourceManager.GetString("NonPublicStaticMethodMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Methods that are not public and static will be ignored..
        /// </summary>
        internal static string NonPublicStaticMethodTitle {
            get {
                return ResourceManager.GetString("NonPublicStaticMethodTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0}.{1} must have a public set accessor..
        /// </summary>
        internal static string PropertyIsReadOnlyMessageFormat {
            get {
                return ResourceManager.GetString("PropertyIsReadOnlyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A command line argument property must have a public set accessor..
        /// </summary>
        internal static string PropertyIsReadOnlyTitle {
            get {
                return ResourceManager.GetString("PropertyIsReadOnlyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The attribute {0} is unknown and will be ignored by the GeneratedParserAttribute..
        /// </summary>
        internal static string UnknownAttributeMessageFormat {
            get {
                return ResourceManager.GetString("UnknownAttributeMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown attribute will be ignored..
        /// </summary>
        internal static string UnknownAttributeTitle {
            get {
                return ResourceManager.GetString("UnknownAttributeTitle", resourceCulture);
            }
        }
    }
}
