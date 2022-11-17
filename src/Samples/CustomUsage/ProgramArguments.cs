﻿using Ookii.CommandLine;
using Ookii.CommandLine.Terminal;
using Ookii.CommandLine.Validation;
using System;
using System.ComponentModel;

namespace CustomUsage;

// This class defines the arguments for the sample. It uses the same arguments as the Parser
// sample, so see that sample for more detailed descriptions.
//
// This sample uses the long/short argument mode, and customizes the usage help.
[ApplicationFriendlyName("Ookii.CommandLine Long/Short Mode Sample")]
[Description("Sample command line application with highly customized usage help. The application parses the command line and prints the results, but otherwise does nothing and none of the arguments are actually used for anything.")]
[ParseOptions(Mode = ParsingMode.LongShort,
    NameTransform = NameTransform.DashCase,
    ValueDescriptionTransform = NameTransform.DashCase,
    CaseSensitive = true,
    DuplicateArguments = ErrorMode.Warning)]
class ProgramArguments
{
    // This argument has a short name, derived from the first letter of its long name. The long
    // name is "--source", and the short name is "-s".
    [CommandLineArgument(Position = 0, IsRequired = true, IsShort = true)]
    [Description("The source data.")]
    public string Source { get; set; } = string.Empty;

    [CommandLineArgument(Position = 1, IsRequired = true, IsShort = true)]
    [Description("The destination data.")]
    public string Destination { get; set; } = string.Empty;

    // This argument does not have a short name. Its long name is "--operation-index" thanks to the
    // NameTranform.
    [CommandLineArgument(DefaultValue = 1)]
    [Description("The operation's index.")]
    public int OperationIndex { get; set; }

    // This argument has an explicit short name, which is uppercase to distinguish it from the
    // lower case '-d" for "--destination".
    [CommandLineArgument(ShortName = 'D')]
    [Description("Provides a date to the application.")]
    public DateTime? Date { get; set; }

    [CommandLineArgument]
    [Description("This is an argument using an enumeration type.")]
    public DayOfWeek? Day { get; set; }

    [CommandLineArgument(IsShort = true)]
    [Description("Provides the count for something to the application.")]
    [ValidateRange(0, 100)]
    public int Count { get; set; }

    // Instead of an alias, this argument now has a short name. Note that you can still use aliases
    // in LongShort mode. Long name aliases are given with the AliasAttribute, and short name
    // aliases with the ShortAliasAttribute.
    [CommandLineArgument(IsShort = true)]
    [Description("Print verbose information; this is an example of a switch argument.")]
    public bool Verbose { get; set; }

    // Another switch argument. Switch arguments with short names can be combined; for example,
    // "-vp" sets both the verbose and process switch (this only works for switch arguments).
    [CommandLineArgument(IsShort = true)]
    [Description("Does the processing.")]
    public bool Process { get; set; }

    // This multi-value argument uses the MultiValueSeparatorAttribute, which means you can supply
    // multiple values like "--value foo bar baz". All following argument tokens are consumed until
    // another name is found (this also works in regular parsing mode).
    //
    // The explicit name must be explicitly lowercase, because the NameTranform doesn't apply to
    // explicit names.
    [CommandLineArgument("value")]
    [Description("This is an example of a multi-value argument, which can be repeated multiple times to set more than one value.")]
    [MultiValueSeparator]
    public string[]? Values { get; set; }

    public static ProgramArguments? Parse()
    {
        // Not all options can be set with the ParseOptionsAttribute.
        var options = new ParseOptions()
        {
            // Set the value description of all int arguments to "number", instead of doing it
            // separately on each argument.
            DefaultValueDescriptions = new Dictionary<Type, string>()
            {
                { typeof(int), "number" }
            },
            // Use our own string provider for the custom usage strings.
            StringProvider = new CustomStringProvider(),
            UsageWriter = new CustomUsageWriter()
            {
                // Only list the positional arguments in the syntax.
                UseAbbreviatedSyntax = true,
                // Set the indentation to work with the format used by the CustomStringProvider.
                ApplicationDescriptionIndent = 2,
                SyntaxIndent = 2,
                LongShortArgumentDescriptionIndent = 30,
                // Sort the description list by short name.
                ArgumentDescriptionListOrder = DescriptionListSortMode.AlphabeticalShortName,
                // Customize some of the colors.
                UsagePrefixColor = TextFormat.ForegroundYellow,
                ArgumentDescriptionColor = TextFormat.BoldBright,
            },
        };

        return CommandLineParser.Parse<ProgramArguments>(options);
    }
}
