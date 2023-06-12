﻿using System;

namespace Ookii.CommandLine;

/// <summary>
/// Provides options that alter parsing behavior for the class that the attribute is applied
/// to.
/// </summary>
/// <remarks>
/// <para>
///   Options can be provided in several ways; you can change the properties of the
///   <see cref="CommandLineParser"/> class, you can use the <see cref="ParseOptions"/> class,
///   or you can use the <see cref="ParseOptionsAttribute"/> attribute.
/// </para>
/// <para>
///   This attribute allows you to define your preferred parsing behavior declaratively, on
///   the class that provides the arguments. Apply this attribute to the class to set the
///   properties.
/// </para>
/// <para>
///   If you also use the <see cref="ParseOptions"/> class, any options provided there will
///   override the options set in this attribute.
/// </para>
/// <para>
///   If you wish to use the default options, you do not need to apply this attribute to your
///   class at all.
/// </para>
/// </remarks>
[AttributeUsage(AttributeTargets.Class)]
public class ParseOptionsAttribute : Attribute
{
    /// <summary>
    /// Gets or sets a value that indicates the command line argument parsing rules to use.
    /// </summary>
    /// <value>
    /// The <see cref="ParsingMode"/> to use. The default is <see cref="ParsingMode.Default"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.Mode"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="CommandLineParser.Mode"/>
    public ParsingMode Mode { get; set; }

    /// <summary>
    /// Gets or sets a value that indicates whether the options follow POSIX conventions.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if the options follow POSIX conventions; otherwise,
    /// <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   This property is provided as a convenient way to set a number of related properties that
    ///   together indicate the parser is using POSIX conventions. POSIX conventions in this case
    ///   means that parsing uses long/short mode, argument names are case sensitive, and argument
    ///   names and value descriptions use dash case (e.g. "argument-name").
    /// </para>
    /// <para>
    ///   Setting this property to <see langword="true"/> is equivalent to setting the
    ///   <see cref="Mode"/> property to <see cref="ParsingMode.LongShort"/>, the
    ///   <see cref="CaseSensitive"/> property to <see langword="true"/>,
    ///   the <see cref="ArgumentNameTransform"/> property to <see cref="NameTransform.DashCase"/>,
    ///   and the <see cref="ValueDescriptionTransform"/> property to <see cref="NameTransform.DashCase"/>.
    /// </para>
    /// <para>
    ///   This property will only return <see langword="true"/> if the above properties are the
    ///   indicated values. It will return <see langword="false"/> for any other combination of
    ///   values, not just the ones indicated below.
    /// </para>
    /// <para>
    ///   Setting this property to <see langword="false"/> is equivalent to setting the
    ///   <see cref="Mode"/> property to <see cref="ParsingMode.Default"/>, the
    ///   <see cref="CaseSensitive"/> property to <see langword="false"/>,
    ///   the <see cref="ArgumentNameTransform"/> property to <see cref="NameTransform.None"/>,
    ///   and the <see cref="ValueDescriptionTransform"/> property to <see cref="NameTransform.None"/>.
    /// </para>
    /// </remarks>
    /// <seealso cref="ParseOptions.IsPosix"/>
    public virtual bool IsPosix
    {
        get => Mode == ParsingMode.LongShort && CaseSensitive && ArgumentNameTransform == NameTransform.DashCase &&
            ValueDescriptionTransform == NameTransform.DashCase;
        set
        {
            if (value)
            {
                Mode = ParsingMode.LongShort;
                CaseSensitive = true;
                ArgumentNameTransform = NameTransform.DashCase;
                ValueDescriptionTransform = NameTransform.DashCase;
            }
            else
            {
                Mode = ParsingMode.Default;
                CaseSensitive = false;
                ArgumentNameTransform = NameTransform.None;
                ValueDescriptionTransform = NameTransform.None;
            }
        }
    }

    /// <summary>
    /// Gets or sets a value that indicates how names are created for arguments that don't have
    /// an explicit name.
    /// </summary>
    /// <value>
    /// One of the values of the <see cref="NameTransform"/> enumeration. The default value is
    /// <see cref="NameTransform.None"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   If an argument doesn't have the <see cref="CommandLineArgumentAttribute.ArgumentName"/>
    ///   property set, the argument name is determined by taking the name of the property or
    ///   method that defines it, and applying the specified transformation.
    /// </para>
    /// <para>
    ///   The name transformation will also be applied to the names of the automatically added
    ///   help and version attributes.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.ArgumentNameTransform"/>
    ///   property.
    /// </para>
    /// </remarks>
    public NameTransform ArgumentNameTransform { get; set; }

    /// <summary>
    /// Gets or sets the prefixes that can be used to specify an argument name on the command
    /// line.
    /// </summary>
    /// <value>
    /// An array of prefixes, or <see langword="null"/> to use the value of
    /// <see cref="CommandLineParser.GetDefaultArgumentNamePrefixes()"/>. The default value is
    /// <see langword="null"/>
    /// </value>
    /// <remarks>
    /// <para>
    ///   If the <see cref="Mode"/> property is <see cref="ParsingMode.LongShort"/>,
    ///   or if the parsing mode is set to <see cref="ParsingMode.LongShort"/>
    ///   elsewhere, this property indicates the short argument name prefixes. Use
    ///   <see cref="LongArgumentNamePrefix"/> to set the argument prefix for long names.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.ArgumentNamePrefixes"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="CommandLineParser.ArgumentNamePrefixes"/>
    public string[]? ArgumentNamePrefixes { get; set; }

    /// <summary>
    /// Gets or sets the argument name prefix to use for long argument names.
    /// </summary>
    /// <remarks>
    /// <para>
    ///   This property is only used if the <see cref="Mode"/> property is 
    ///   <see cref="ParsingMode.LongShort"/>, or if the parsing mode is set to
    ///   <see cref="ParsingMode.LongShort"/> elsewhere.
    /// </para>
    /// <para>
    ///   Use the <see cref="ArgumentNamePrefixes"/> to specify the prefixes for short argument
    ///   names.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.LongArgumentNamePrefix"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="CommandLineParser.LongArgumentNamePrefix"/>
    public string? LongArgumentNamePrefix { get; set; }

    /// <summary>
    /// Gets or sets a value that indicates whether argument names are treated as case
    /// sensitive.
    /// </summary>
    /// <value>
    /// <see langword="true" /> to indicate that argument names must match case exactly when
    /// specified, or <see langword="false"/> to indicate the case does not need to match.
    /// The default value is <see langword="false"/>
    /// </value>
    /// <remarks>
    /// <para>
    ///   When <see langword="true" />, the <see cref="CommandLineParser"/> will use
    ///   <see cref="StringComparer.Ordinal"/> for command line argument comparisons; otherwise,
    ///   it will use <see cref="StringComparer.OrdinalIgnoreCase" />.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.ArgumentNameComparison"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="CommandLineParser.ArgumentNameComparison"/>
    public bool CaseSensitive { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether duplicate arguments are allowed.
    /// </summary>
    /// <value>
    /// One of the values of the <see cref="ErrorMode"/> enumeration. The default value is
    /// <see cref="ErrorMode.Error"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   If set to <see cref="ErrorMode.Error"/>, supplying a non-multi-value argument more
    ///   than once will cause an exception. If set to <see cref="ErrorMode.Allow"/>, the
    ///   last value supplied will be used.
    /// </para>
    /// <para>
    ///   If set to <see cref="ErrorMode.Warning"/>, the <see cref="CommandLineParser{T}.ParseWithErrorHandling()"/>
    ///   method, the static <see cref="CommandLineParser.Parse{T}(ParseOptions?)"/> method and
    ///   the <see cref="Commands.CommandManager"/> class will print a warning to the
    ///   <see cref="ParseOptions.Error"/> stream when a duplicate argument is found. If you are
    ///   not using these methods, <see cref="ErrorMode.Warning"/> is identical to
    ///   <see cref="ErrorMode.Allow"/> and no warning is displayed.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.DuplicateArguments"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="CommandLineParser.AllowDuplicateArguments"/>
    public ErrorMode DuplicateArguments { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the value of arguments may be separated from
    /// the name by white space.
    /// </summary>
    /// <value>
    ///   <see langword="true"/> if white space is allowed to separate an argument name and its
    ///   value; <see langword="false"/> if only the values from <see cref="NameValueSeparators"/>
    ///   are allowed. The default value is <see langword="true"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.AllowWhiteSpaceValueSeparator"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="CommandLineParser.AllowWhiteSpaceValueSeparator"/>
    public bool AllowWhiteSpaceValueSeparator { get; set; } = true;

    /// <summary>
    /// Gets or sets the character used to separate the name and the value of an argument.
    /// </summary>
    /// <value>
    ///   The characters used to separate the name and the value of an argument, or <see langword="null"/>
    ///   to use the default value from the <see cref="CommandLineParser.GetDefaultNameValueSeparators"/>
    ///   method, which is a colon ':' and an equals sign '='. The default value is <see langword="null"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   These characters are used to separate the name and the value if both are provided as
    ///   a single argument to the application, e.g. <c>-sample:value</c> or <c>-sample=value</c>
    ///   if the default value is used.
    /// </para>
    /// <note>
    ///   The character chosen here cannot be used in the name of any parameter. Therefore,
    ///   it's usually best to choose a non-alphanumeric value such as the colon or equals sign.
    ///   The character can appear in argument values (e.g. <c>-sample:foo:bar</c> is fine, in which
    ///   case the value is "foo:bar").
    /// </note>
    /// <note>
    ///   Do not pick a white-space character as the separator. Doing this only works if the
    ///   whitespace character is part of the argument, which usually means it needs to be
    ///   quoted or escaped when invoking your application. Instead, use the
    ///   <see cref="AllowWhiteSpaceValueSeparator"/> property to control whether white space
    ///   is allowed as a separator.
    /// </note>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.NameValueSeparators"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="CommandLineParser.NameValueSeparators"/>
    public char[]? NameValueSeparators { get; set; }

    /// <summary>
    /// Gets or sets a value that indicates a help argument will be automatically added.
    /// </summary>
    /// <value>
    ///   <see langword="true"/> to automatically create a help argument; otherwise,
    ///   <see langword="false"/>. The default value is <see langword="true"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   If this property is <see langword="true"/>, the <see cref="CommandLineParser"/>
    ///   will automatically add an argument with the name "Help". If using <see cref="ParsingMode.LongShort"/>,
    ///   this argument will have the short name "?" and a short alias "h"; otherwise, it
    ///   will have the aliases "?" and "h". When supplied, this argument will cancel parsing
    ///   and cause usage help to be printed.
    /// </para>
    /// <para>
    ///   If you already have an argument conflicting with the names or aliases above, the
    ///   automatic help argument will not be created even if this property is
    ///   <see langword="true"/>.
    /// </para>
    /// <para>
    ///   The name, aliases and description can be customized by using a custom <see cref="LocalizedStringProvider"/>.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.AutoHelpArgument"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="LocalizedStringProvider.AutomaticHelpName"/>
    /// <seealso cref="LocalizedStringProvider.AutomaticHelpDescription"/>
    /// <seealso cref="LocalizedStringProvider.AutomaticHelpShortName"/>
    public bool AutoHelpArgument { get; set; } = true;

    /// <summary>
    /// Gets or sets a value that indicates a version argument will be automatically added.
    /// </summary>
    /// <value>
    ///   <see langword="true"/> to automatically create a version argument; otherwise,
    ///   <see langword="false"/>. The default value is <see langword="true"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   If this property is <see langword="true"/>, the <see cref="CommandLineParser"/>
    ///   will automatically add an argument with the name "Version". When supplied, this
    ///   argument will write version information to the console and cancel parsing, without
    ///   showing usage help.
    /// </para>
    /// <para>
    ///   If you already have an argument named "Version", the automatic version argument
    ///   will not be created even if this property is <see langword="true"/>.
    /// </para>
    /// <note>
    ///   The automatic version argument will never be created for subcommands.
    /// </note>
    /// <para>
    ///   The name and description can be customized by using a custom <see cref="LocalizedStringProvider"/>.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.AutoVersionArgument"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="LocalizedStringProvider.AutomaticVersionName"/>
    /// <seealso cref="LocalizedStringProvider.AutomaticVersionDescription"/>
    public bool AutoVersionArgument { get; set; } = true;

    /// <summary>
    /// Gets or sets a value that indicates whether unique prefixes of an argument are automatically
    /// used as aliases.
    /// </summary>
    /// <value>
    ///   <see langword="true"/> to automatically use unique prefixes of an argument as aliases
    ///   for that argument; otherwise, <see langword="false"/>. The default value is
    ///   <see langword="true"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   If this property is <see langword="true"/>, the <see cref="CommandLineParser"/> class
    ///   will consider any prefix that uniquely identifies an argument by its name or one of its
    ///   explicit aliases as an alias for that argument. For example, given two arguments "Port"
    ///   and "Protocol", "Po" and "Port" would be an alias for "Port, and "Pr" an alias for
    ///   "Protocol" (as well as "Pro", "Prot", "Proto", etc.). "P" would not be an alias because it
    ///   doesn't uniquely identify a single argument.
    /// </para>
    /// <para>
    ///   When using <see cref="ParsingMode.LongShort"/>, this only applies to long names. Explicit
    ///   aliases set with the <see cref="AliasAttribute"/> take precedence over automatic aliases.
    ///   Automatic prefix aliases are not shown in the usage help.
    /// </para>
    /// <para>
    ///   This behavior is enabled unless explicitly disabled here or using the
    ///   <see cref="ParseOptions.AutoPrefixAliases"/> property.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.AutoPrefixAliases"/>
    ///   property.
    /// </para>
    /// </remarks>
    public bool AutoPrefixAliases { get; set; } = true;

    /// <summary>
    /// Gets or sets a value that indicates how value descriptions derived from type names
    /// are transformed.
    /// </summary>
    /// <value>
    /// One of the members of the <see cref="NameTransform"/> enumeration. The default value is
    /// <see cref="NameTransform.None"/>.
    /// </value>
    /// <remarks>
    /// <para>
    ///   This property has no effect on explicit value description specified with the
    ///   <see cref="CommandLineArgument.ValueDescription"/> property or the
    ///   <see cref="ParseOptions.DefaultValueDescriptions"/> property.
    /// </para>
    /// <para>
    ///   This value can be overridden by the <see cref="ParseOptions.ValueDescriptionTransform"/>
    ///   property.
    /// </para>
    /// </remarks>
    /// <seealso cref="CommandLineArgument.ValueDescription"/>
    public NameTransform ValueDescriptionTransform { get; set; }

    internal StringComparison GetStringComparison()
    {
        if (CaseSensitive)
        {
            // Do not use Ordinal for case-sensitive comparisons so that when sorting capitals
            // and non-capitals are sorted together.
            return StringComparison.InvariantCulture;
        }
        else
        {
            return StringComparison.OrdinalIgnoreCase;
        }
    }
}
