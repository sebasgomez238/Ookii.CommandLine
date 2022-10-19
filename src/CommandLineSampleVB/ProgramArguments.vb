﻿Imports System.ComponentModel
Imports System.Globalization
Imports Ookii.CommandLine

''' <summary>
''' Class that defines the sample's command line arguments.
''' </summary>
<Description("Sample command line application. The application parses the command line and prints the results, but otherwise does nothing and none of the arguments are actually used for anything.")>
Class ProgramArguments

    ' This property defines a required positional argument called "Source". It can be set by name as e.g. "-Source value", or by position
    ' by specifying "value" as the first positional argument. Note that by default command line argument names are case insensitive, so
    ' this argument can also be specified as e.g. "-source value".
    ' On Windows, the default command name prefixes are "/" and "-", so the argument can also be specified as e.g. "/Source value". On Unix
    ' (using Mono), only "-" is accepted by default.
    <CommandLineArgument(Position:=0, IsRequired:=True), Description("The source data.")>
    Public Property Source As String

    ' This property defines a required positional argument called "Destination". It can be set by name as e.g. "-Destination value", or by position
    ' by specifying "value" as the second positional argument.
    <CommandLineArgument(Position:=1, IsRequired:=True), Description("The destination data.")>
    Public Property Destination As String

    ' This property defines a optional positional argument called "Index". It can be set by name as e.g. "-Index 5", or by position
    ' by specifying e.g. "5" as the third positional argument. If the argument is not specified, this property
    ' will be set to the default value 1.
    <CommandLineArgument(Position:=2, DefaultValue:=1), Description("The operation's index.")>
    Public Property Index As Integer

    ' This property defines an argument named "Date". This argument is not positional, so it can be supplied only by name, for example as "-Date 2013-01-31".
    ' This argument uses a nullable value type so it will be set to Nothing if the value is not supplied, rather than having to choose a default value.
    ' For types other than string, CommandLineParser will use the TypeConverter for the argument's type to try to convert the string to
    ' the correct type. You can use your own custom classes or structures for command line arguments as long as you create a TypeConverter for
    ' the type.
    ' The type conversion from string to DateTime is culture sensitive. Which culture is used is indicated by the CommandLineParser.Culture
    ' property, which defaults to the invariant culture. This is preferred to ensure a
    ' consistent parsing experience regardless of the user's culture.
    ' Always pay attention when a conversion is culture specific (this goes for dates, numbers,
    ' and various other types) and consider which culture is the right choice for your
    ' application.
    <CommandLineArgument(), Description("Provides a date to the application.")>
    Public Property [Date] As Date?

    ' This property defines an argument named "Count".
    ' This argument uses a custom ValueDescription so it shows up as "-Count <Number>" in the usage rather than as "-Count <Int32>"
    <CommandLineArgument(ValueDescription:="Number"), Description("Provides the count for something to the application.")>
    Public Property Count As Integer

    ' This property defines a switch argument named "Verbose".
    ' Non-positional arguments whose type is "Boolean" act as a switch; if they are supplied on the command line, their value will be true, otherwise
    ' it will be false. You don't need to specify a value, just specify "-Verbose" to set it to true. You can explicitly set the value by
    ' using "-Verbose:true" or "-Verbose:false" if you want, but it is not needed.
    ' If you give an argument the type bool?, it will be true if present, Nothing if omitted, and false only when explicitly set to false using "-Verbose:false"
    ' This argument has an alias, so it can also be specified using "-v" instead of its regular name. An argument can have multiple aliases by specifying
    ' the Alias attribute more than once.
    <CommandLineArgument, [Alias]("v"), Description("Print verbose information; this is an example of a switch argument.")>
    Public Property Verbose As Boolean

    ' This property defines a multi-value argument named "Value". Its name is specified explicitly so it differs from the property name.
    ' A multi-value argument can be specified multiple times. Every time it is specified, the value will be added to the array.
    ' To set multiple values, simply repeat the argument, e.g. "-Value foo -Value bar -Value baz" will set it to an array containing { "foo", "bar", "baz" }
    ' Since no default value is specified, the property will be Nothing if -Value is not supplied at all.
    ' Multi-value arguments can be created either using a property of an array type, or using a read-only property of any collection type (e.g. List<T>).
    ' The element type doesn't have to be a string. Any type that can be used for normal arguments can also be used for multi-value arguments.
    <CommandLineArgument("Value"), Description("This is an example of a multi-value argument, which can be repeated multiple times to set more than one value.")>
    Public Property Values As String()

    ' This property defines a switch argument named "Help", with the alias "?".
    ' For this argument, CancelParsing Is set to true so that command line processing is stopped
    ' when this argument is supplied. That way, we can print usage regardless of what other arguments are
    ' present.
    <CommandLineArgument(CancelParsing:=True), [Alias]("?"), Description("Displays this help message.")>
    Public Property Help As Boolean

    ' Using a Shared creation function for a command line arguments class is not required, but it's a convenient
    ' way to place all command-line related functionality in one place. To parse the arguments (eg. from the Main method)
    ' you then only need to call this function.
    Public Shared Function Create() As ProgramArguments
        ' UsageOptions are used to print usage information if there was an error parsing
        ' the command line or parsing was cancelled (by the -Help property above).
        ' By default, aliases and default values are not included in the usage descriptions;
        ' for this sample, I do want to include them.
        Dim options As New ParseOptions With {
            .UsageOptions = New WriteUsageOptions With {
                .IncludeDefaultValueInDescription = True,
                .IncludeAliasInDescription = True
            }
        }

        ' The static Parse method handles parsing, printing error and usage information
        ' (using a LineWrappingTextWriter to neatly wrap console output), and converting to
        ' the proper type.
        ' It takes the arguments from Environment.GetCommandLineArgs().
        Return CommandLineParser.Parse(Of ProgramArguments)(options)
    End Function

    ' If you want more control over the parsing behavior, you can manually create an instance
    ' of the CommandLineParser class And handle errors And usage yourself, as below.
    ' This is only necessary if you want to deviate from what the static Parse method does,
    ' which is Not the case here; this method Is only provided for demonstrative purposes.
    Public Shared Function CreateCustom(ByVal args() As String) As ProgramArguments
        ' Certain argument types, such as dates and floating point numbers, could have culture
        ' specific parsing behavior. You can use the InvariantCulture to ensure a consistent
        ' experience regardless of the user's current culture.
        Dim parser As New CommandLineParser(GetType(ProgramArguments)) With {
            .Culture = CultureInfo.InvariantCulture
        }

        Try
            ' The Parse function returns Nothing only when the Help argument cancelled parsing.
            Dim result As ProgramArguments = DirectCast(parser.Parse(args), ProgramArguments)
            If result IsNot Nothing Then
                Return result
            End If
        Catch ex As Exception
            ' We use the LineWrappingTextWriter to neatly wrap console output.
            Using writer As LineWrappingTextWriter = LineWrappingTextWriter.ForConsoleError()
                ' Tell the user what went wrong.
                writer.WriteLine(ex.Message)
                writer.WriteLine()
            End Using
        End Try

        ' If we got here, we should print usage information to the console.
        ' By default, aliases and default values are not included in the usage descriptions; for this sample, I do want to include them.
        Dim options As New WriteUsageOptions With {
            .IncludeDefaultValueInDescription = True,
            .IncludeAliasInDescription = True
        }

        ' WriteUsageToConsole automatically uses a LineWrappingTextWriter to properly word-wrap the text.
        parser.WriteUsageToConsole(options)
        Return Nothing
    End Function
End Class
