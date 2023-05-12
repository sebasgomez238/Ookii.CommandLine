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
        ///   Looks up a localized string similar to The AliasAttribute is ignored on the argument defined by {0} because it has no long name..
        /// </summary>
        internal static string AliasWithoutLongNameMessageFormat {
            get {
                return ResourceManager.GetString("AliasWithoutLongNameMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AliasAttribute is ignored on an argument with no long name..
        /// </summary>
        internal static string AliasWithoutLongNameTitle {
            get {
                return ResourceManager.GetString("AliasWithoutLongNameTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line argument defined by {0} uses the ArgumentConverterAttribute with a string argument, which is not supported by the GeneratedParserAttribute. Use a Type argument instead by using the typeof keyword..
        /// </summary>
        internal static string ArgumentConverterStringNotSupportedMessageFormat {
            get {
                return ResourceManager.GetString("ArgumentConverterStringNotSupportedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ArgumentConverterAttribute must use the typeof keyword..
        /// </summary>
        internal static string ArgumentConverterStringNotSupportedTitle {
            get {
                return ResourceManager.GetString("ArgumentConverterStringNotSupportedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The class {0} may not be a generic class when the {1} attribute is used..
        /// </summary>
        internal static string ClassIsGenericMessageFormat {
            get {
                return ResourceManager.GetString("ClassIsGenericMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Th eclass may not be a generic type..
        /// </summary>
        internal static string ClassIsGenericTitle {
            get {
                return ResourceManager.GetString("ClassIsGenericTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The class {0} may not be nested in another type when the {1} attribute is used..
        /// </summary>
        internal static string ClassIsNestedMessageFormat {
            get {
                return ResourceManager.GetString("ClassIsNestedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The class may not be a nested type..
        /// </summary>
        internal static string ClassIsNestedTitle {
            get {
                return ResourceManager.GetString("ClassIsNestedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The class {0} must use the &apos;partial&apos; modifier when the {1} attribute is used..
        /// </summary>
        internal static string ClassNotPartialMessageFormat {
            get {
                return ResourceManager.GetString("ClassNotPartialMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The class must be a partial class..
        /// </summary>
        internal static string ClassNotPartialTitle {
            get {
                return ResourceManager.GetString("ClassNotPartialTitle", resourceCulture);
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
        ///   Looks up a localized string similar to The default value is ignored if the argument is required, multi-value, or a method argument..
        /// </summary>
        internal static string DefaultValueIgnoredTitle {
            get {
                return ResourceManager.GetString("DefaultValueIgnoredTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default value of the argument defined by {0} is ignored because it is a method argument..
        /// </summary>
        internal static string DefaultValueWithMethodMessageFormat {
            get {
                return ResourceManager.GetString("DefaultValueWithMethodMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default value of the argument defined by {0} is ignored because it is a multi-value argument..
        /// </summary>
        internal static string DefaultValueWithMultiValueMessageFormat {
            get {
                return ResourceManager.GetString("DefaultValueWithMultiValueMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default value of the argument defined by {0} is ignored because the argument is required..
        /// </summary>
        internal static string DefaultValueWithRequiredMessageFormat {
            get {
                return ResourceManager.GetString("DefaultValueWithRequiredMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument defined by {0} uses the same position value as {1}..
        /// </summary>
        internal static string DuplicatePositionMessageFormat {
            get {
                return ResourceManager.GetString("DuplicatePositionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Two or more arguments use the same position value..
        /// </summary>
        internal static string DuplicatePositionTitle {
            get {
                return ResourceManager.GetString("DuplicatePositionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command class {0} cannot use the GeneratedParserAttribute class, because it implements the ICommandWithCustomParsing interface..
        /// </summary>
        internal static string GeneratedCustomParsingCommandMessageFormat {
            get {
                return ResourceManager.GetString("GeneratedCustomParsingCommandMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The GeneratedParserAttribute cannot be used with a class that implements the ICommandWithCustomParsing interface..
        /// </summary>
        internal static string GeneratedCustomParsingCommandTitle {
            get {
                return ResourceManager.GetString("GeneratedCustomParsingCommandTitle", resourceCulture);
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
        ///   Looks up a localized string similar to The assembly name &apos;{0}&apos; is not valid..
        /// </summary>
        internal static string InvalidAssemblyNameMessageFormat {
            get {
                return ResourceManager.GetString("InvalidAssemblyNameMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid assembly name..
        /// </summary>
        internal static string InvalidAssemblyNameTitle {
            get {
                return ResourceManager.GetString("InvalidAssemblyNameTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not a valid C# namespace name. The default namespace will be used instead..
        /// </summary>
        internal static string InvalidGeneratedConverterNamespaceMessageFormat {
            get {
                return ResourceManager.GetString("InvalidGeneratedConverterNamespaceMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified namespace for generated converters is not valid..
        /// </summary>
        internal static string InvalidGeneratedConverterNamespaceTitle {
            get {
                return ResourceManager.GetString("InvalidGeneratedConverterNamespaceTitle", resourceCulture);
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
        ///   Looks up a localized string similar to The CommandLineArgumentAttribute.IsHidden property is ignored for the argument defined by {0} because it is positional..
        /// </summary>
        internal static string IsHiddenWithPositionalMessageFormat {
            get {
                return ResourceManager.GetString("IsHiddenWithPositionalMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The CommandLineArgumentAttribute.IsHidden property is ignored for positional arguments..
        /// </summary>
        internal static string IsHiddenWithPositionalTitle {
            get {
                return ResourceManager.GetString("IsHiddenWithPositionalTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The CommandLineArgumentAttribute.IsRequired property is ignored for the required property {0}..
        /// </summary>
        internal static string IsRequiredWithRequiredPropertyMessageFormat {
            get {
                return ResourceManager.GetString("IsRequiredWithRequiredPropertyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The CommandLineArgumentAttribute.IsRequired property is ignored for a required property..
        /// </summary>
        internal static string IsRequiredWithRequiredPropertyTitle {
            get {
                return ResourceManager.GetString("IsRequiredWithRequiredPropertyTitle", resourceCulture);
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
        ///   Looks up a localized string similar to No command line argument converter exists for the argument&apos;s type..
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
        ///   Looks up a localized string similar to The command line argument property {0}.{1} may only have an &apos;init&apos; accessor if the property is also declared as &apos;required&apos;..
        /// </summary>
        internal static string NonRequiredInitOnlyPropertyMessageFormat {
            get {
                return ResourceManager.GetString("NonRequiredInitOnlyPropertyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Init accessors may only be used on required properties..
        /// </summary>
        internal static string NonRequiredInitOnlyPropertyTitle {
            get {
                return ResourceManager.GetString("NonRequiredInitOnlyPropertyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The positional argument defined by {0} comes after {1}, which is a multi-value argument and must come last..
        /// </summary>
        internal static string PositionalArgumentAfterMultiValueMessageFormat {
            get {
                return ResourceManager.GetString("PositionalArgumentAfterMultiValueMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A positional multi-value argument must be the last positional argument..
        /// </summary>
        internal static string PositionalArgumentAfterMultiValueTitle {
            get {
                return ResourceManager.GetString("PositionalArgumentAfterMultiValueTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required positional argument defined by {0} comes after {1}, which is optional..
        /// </summary>
        internal static string PositionalRequiredArgumentAfterOptionalMessageFormat {
            get {
                return ResourceManager.GetString("PositionalRequiredArgumentAfterOptionalMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required positional arguments must come before optional positional arguments..
        /// </summary>
        internal static string PositionalRequiredArgumentAfterOptionalTitle {
            get {
                return ResourceManager.GetString("PositionalRequiredArgumentAfterOptionalTitle", resourceCulture);
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
        ///   Looks up a localized string similar to The ShortAliasAttribute is ignored on the argument defined by {0} because it has no short name..
        /// </summary>
        internal static string ShortAliasWithoutShortNameMessageFormat {
            get {
                return ResourceManager.GetString("ShortAliasWithoutShortNameMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ShortAliasAttribute is ignored on an argument with no short name..
        /// </summary>
        internal static string ShortAliasWithoutShortNameTitle {
            get {
                return ResourceManager.GetString("ShortAliasWithoutShortNameTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} must be a reference type (class) when the {1} attribute is used..
        /// </summary>
        internal static string TypeNotReferenceTypeMessageFormat {
            get {
                return ResourceManager.GetString("TypeNotReferenceTypeMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command line arguments type must be a reference type..
        /// </summary>
        internal static string TypeNotReferenceTypeTitle {
            get {
                return ResourceManager.GetString("TypeNotReferenceTypeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An assembly matching the name &apos;{0}&apos; was not found..
        /// </summary>
        internal static string UnknownAssemblyNameMessageFormat {
            get {
                return ResourceManager.GetString("UnknownAssemblyNameMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown assembly name..
        /// </summary>
        internal static string UnknownAssemblyNameTitle {
            get {
                return ResourceManager.GetString("UnknownAssemblyNameTitle", resourceCulture);
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
