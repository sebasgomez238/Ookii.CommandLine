﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ookii.CommandLine.Validation
{
    /// <summary>
    /// Validates that the value of an argument is not <see langword="null"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    ///   An argument's value can only be <see langword="null"/> if its <see cref="TypeConverter"/>
    ///   returns <see langword="null"/> from the <see cref="TypeConverter.ConvertFrom(ITypeDescriptorContext?, System.Globalization.CultureInfo?, object)"/>
    ///   method.
    /// </para>
    /// <para>
    ///   It is not necessary to use this attribute on required arguments with types that can't be
    ///   <see langword="null"/>, such as value types (except <see cref="Nullable{T}"/>, and if
    ///   using .Net 6.0 or later, non-nullable reference types. The <see cref="CommandLineParser"/>
    ///   already ensures it will not assign <see langword="null"/> to these arguments.
    /// </para>
    /// <para>
    ///   If the argument is optional, validation is only performed if the argument is specified,
    ///   so the value may still be <see langword="null"/> if the argument is not supplied, if that
    ///   is the default value.
    /// </para>
    /// <para>
    ///   This validator does not add any help text to the argument description.
    /// </para>
    /// </remarks>
    /// <threadsafety static="true" instance="true"/>
    public class ValidateNotNullAttribute : ArgumentValidationAttribute
    {
        /// <summary>
        /// Determines if the argument's value is not null.
        /// </summary>
        /// <param name="argument">The argument being validated.</param>
        /// <param name="value">
        ///   The argument value. If not <see langword="null"/>, this must be an instance of
        ///   <see cref="CommandLineArgument.ArgumentType"/>.
        /// </param>
        /// <returns>
        ///   <see langword="true"/> if the value is valid; otherwise, <see langword="false"/>.
        /// </returns>
        public override bool IsValid(CommandLineArgument argument, object? value)
        {
            return value != null;
        }

        /// <summary>
        /// Gets the error message to display if validation failed.
        /// </summary>
        /// <param name="argument">The argument that was validated.</param>
        /// <param name="value">Not used.</param>
        /// <returns>The error message.</returns>
        public override string GetErrorMessage(CommandLineArgument argument, object? value)
        {
            return argument.Parser.StringProvider.NullArgumentValue(argument.ArgumentName);
        }
    }
}
