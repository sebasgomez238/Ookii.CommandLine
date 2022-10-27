﻿// Copyright (c) Sven Groot (Ookii.org)
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Ookii.CommandLine
{
    /// <summary>
    /// Provides options for the <see cref="CommandLineParser.Parse{T}(string[], ParseOptions)"/> method
    /// and the <see cref="CommandLineParser.CommandLineParser(Type, ParseOptions?)"/> constructor.
    /// </summary>
    /// <remarks>
    /// <para>
    ///   Several options can also be specified using the <see cref="ParseOptionsAttribute"/>
    ///   attribute on the type defining the arguments. If the option is set in both in the
    ///   attribute and here, the value from <see cref="ParseOptions"/> will override the value
    ///   from the <see cref="ParseOptionsAttribute"/> attribute.
    /// </para>
    /// </remarks>
    public class ParseOptions
    {
        private WriteUsageOptions? _usageOptions;

        /// <summary>
        /// Gets or sets the culture used to convert command line argument values from their string representation to the argument type.
        /// </summary>
        /// <value>
        /// The culture used to convert command line argument values from their string representation to the argument type, or
        /// <see langword="null" /> to use <see cref="CultureInfo.InvariantCulture"/>. The default value is <see langword="null"/>
        /// </value>
        public CultureInfo? Culture { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates the command line argument parsing rules to use.
        /// </summary>
        /// <value>
        /// The <see cref="Ookii.CommandLine.ParsingMode"/> to use. The default is <see cref="ParsingMode.Default"/>.
        /// </value>
        /// <remarks>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.Mode"/> property.
        /// </para>
        /// </remarks>
        public ParsingMode? Mode { get; set; }

        /// <summary>
        /// Gets or sets the argument name prefixes to use when parsing the arguments.
        /// </summary>
        /// <value>
        /// The named argument switches, or <see langword="null"/> to indicate the values from the
        /// <see cref="ParseOptionsAttribute.ArgumentNamePrefixes"/> property, or the default
        /// prefixes for/ the current platform must be used. The default value is <see langword="null"/>.
        /// </value>
        /// <remarks>
        /// <para>
        ///   If the <see cref="Mode"/> property is <see cref="ParsingMode.LongShort"/>,
        ///   or if it is <see langword="null"/> and the parsing mode is set to <see cref="ParsingMode.LongShort"/>
        ///   elsewhere, this property indicates the short argument name prefixes. Use
        ///   <see cref="LongArgumentNamePrefix"/> to set the argument prefix for long names.
        /// </para>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.ArgumentNamePrefixes"/> property.
        /// </para>
        /// </remarks>

        public IEnumerable<string>? ArgumentNamePrefixes { get; set; }

        /// <summary>
        /// Gets or sets the argument name prefix to se for long argument names.
        /// </summary>
        /// <remarks>
        /// <para>
        ///   This property is only used if the <see cref="Mode"/> property is <see cref="ParsingMode.LongShort"/>,
        ///   or if it is <see langword="null"/> and the parsing mode is set to <see cref="ParsingMode.LongShort"/>
        ///   elsewhere.
        /// </para>
        /// <para>
        ///   Use the <see cref="ArgumentNamePrefixes"/> to specify the prefixes for short argument
        ///   names.
        /// </para>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.LongArgumentNamePrefix"/> property.
        /// </para>
        /// </remarks>
        public string? LongArgumentNamePrefix { get; set; }

        /// <summary>
        /// Gets or set the <see cref="IComparer{T}"/> to use to compare argument names.
        /// </summary>
        /// <value>
        /// The <see cref="IComparer{T}"/> to use to compare the names of named arguments, or
        /// <see langword="null"/> to use the determined using <see cref="ParseOptionsAttribute.CaseSensitive"/>,
        /// or if the <see cref="ParseOptionsAttribute"/> is not present, <see cref="StringComparer.OrdinalIgnoreCase"/>.
        /// The default value is <see langword="null"/>.
        /// </value>
        /// <remarks>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.CaseSensitive"/> property.
        /// </para>
        /// </remarks>
        public IComparer<string>? ArgumentNameComparer { get; set; }

        /// <summary>
        /// Gets or sets the output <see cref="TextWriter"/> used to print usage information if
        /// argument parsing fails or is cancelled.
        /// </summary>
        /// <remarks>
        /// If argument parsing is successful, nothing will be written.
        /// </remarks>
        /// <value>
        /// The <see cref="TextWriter"/> used to print usage information, or <see langword="null"/>
        /// to print to a <see cref="LineWrappingTextWriter"/> for the standard output stream
        /// (<see cref="Console.Out"/>). The default value is <see langword="null"/>.
        /// </value>
        public TextWriter? Out { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="TextWriter"/> used to print error information if argument
        /// parsing fails.
        /// </summary>
        /// <remarks>
        /// If argument parsing is successful, nothing will be written.
        /// </remarks>
        /// <value>
        /// The <see cref="TextWriter"/> used to print error information, or <see langword="null"/>
        /// to print to a <see cref="LineWrappingTextWriter"/> for the standard error stream 
        /// (<see cref="Console.Error"/>). The default value is <see langword="null"/>.
        /// </value>
        public TextWriter? Error { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether duplicate arguments are allowed.
        /// </summary>
        /// <value>
        ///   <see langword="true"/> if it is allowed to supply non-array arguments more than once;
        ///   <see langword="false"/> if it is not allowed, or <see langword="null" /> to use the
        ///   value from the <see cref="ParseOptionsAttribute.AllowDuplicateArguments"/> property,
        ///   or if the <see cref="ParseOptionsAttribute"/> is not present, the default option
        ///   which is <see langword="false"/>. The default value is <see langword="null"/>.
        /// </value>
        /// <remarks>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.CaseSensitive"/> property.
        /// </para>
        /// </remarks>
        /// <seealso cref="CommandLineParser.AllowDuplicateArguments"/>
        public bool? AllowDuplicateArguments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the value of arguments may be separated from the name by white space.
        /// </summary>
        /// <value>
        ///   <see langword="true"/> if white space is allowed to separate an argument name and its
        ///   value; <see langword="false"/> if only the <see cref="NameValueSeparator"/> is allowed,
        ///   or <see langword="null" /> to use the value from the <see cref="ParseOptionsAttribute.AllowWhiteSpaceValueSeparator"/>
        ///   property, or if the <see cref="ParseOptionsAttribute"/> is not present, the default
        ///   option which is <see langword="true"/>. The default value is <see langword="null"/>.
        /// </value>
        /// <remarks>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.AllowWhiteSpaceValueSeparator"/> property.
        /// </para>
        /// </remarks>
        /// <seealso cref="CommandLineParser.AllowWhiteSpaceValueSeparator"/>
        public bool? AllowWhiteSpaceValueSeparator { get; set; }

        /// <summary>
        /// Gets or sets the character used to separate the name and the value of an argument.
        /// </summary>
        /// <value>
        ///   The character used to separate the name and the value of an argument, or <see langword="null"/>
        ///   to use the value from the <see cref="ParseOptionsAttribute.NameValueSeparator" />
        ///   property, or if the <see cref="ParseOptionsAttribute"/> is not present, the default
        ///   separator which is the <see cref="CommandLineParser.DefaultNameValueSeparator"/>
        ///   constant, a colon (:). The default value is <see langword="null"/>.
        /// </value>
        /// <remarks>
        /// <para>
        ///   This character is used to separate the name and the value if both are provided as
        ///   a single argument to the application, e.g. <c>-sample:value</c> if the default value is used.
        /// </para>
        /// <note>
        ///   The character chosen here cannot be used in the name of any parameter. Therefore,
        ///   it's usually best to choose a non-alphanumeric value such as the colon or equals sign.
        ///   The character can appear in argument values (e.g. <c>-sample:foo:bar</c> is fine, in which
        ///   case the value is "foo:bar").
        /// </note>
        /// <note>
        ///   Do not pick a whitespace character as the separator. Doing this only works if the
        ///   whitespace character is part of the argument, which usually means it needs to be
        ///   quoted or escaped when invoking your application. Instead, use the
        ///   <see cref="AllowWhiteSpaceValueSeparator"/> property to control whether whitespace
        ///   is allowed as a separator.
        /// </note>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.NameValueSeparator"/> property.
        /// </para>
        /// </remarks>
        public char? NameValueSeparator { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates a help argument will be automatically added.
        /// </summary>
        /// <value>
        ///   <see langword="true"/> to automatically create a help argument; <see langword="false"/>
        ///   to not create one, or <see langword="null" /> to use the value from the
        ///   <see cref="ParseOptionsAttribute.AutoHelpArgument"/> property, or if the
        ///   <see cref="ParseOptionsAttribute"/> is not present, <see langword="true"/>.
        ///   The default value is <see langword="null"/>.
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
        ///   the automatic help argument will not be created even if this property is
        ///   <see langword="true"/>.
        /// </para>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.AutoHelpArgument"/> property.
        /// </para>
        /// </remarks>
        public bool? AutoHelpArgument { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates a version argument will be automatically added.
        /// </summary>
        /// <value>
        ///   <see langword="true"/> to automatically create a version argument; <see langword="false"/>
        ///   to not create one, or <see langword="null" /> to use the value from the
        ///   <see cref="ParseOptionsAttribute.AutoVersionArgument"/> property, or if the
        ///   <see cref="ParseOptionsAttribute"/> is not present, <see langword="true"/>.
        ///   The default value is <see langword="null"/>.
        /// </value>
        /// <remarks>
        /// <para>
        ///   If this property is <see langword="true"/>, the <see cref="CommandLineParser"/>
        ///   will automatically add an argument with the name "Version". When supplied, this
        ///   argument will write version information to the console and cancel parsing, without
        ///   showing usage help.
        /// </para>
        /// <para>
        ///   If you already have an argument named "Version", the the automatic version argument
        ///   will not be created even if this property is <see langword="true"/>.
        /// </para>
        /// <para>
        ///   If not <see langword="null"/>, this property overrides the value of the
        ///   <see cref="ParseOptionsAttribute.AutoVersionArgument"/> property.
        /// </para>
        /// </remarks>
        public bool AutoVersionArgument { get; set; } = true;

        /// <summary>
        /// Gets or sets the options to use to write usage information to <see cref="Out"/> when
        /// parsing the arguments fails or is cancelled.
        /// </summary>
        /// <value>
        /// The usage options.
        /// </value>
        public WriteUsageOptions UsageOptions
        {
            get => _usageOptions ??= new WriteUsageOptions();
            set => _usageOptions = value;
        }
    }
}
