﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ookii.CommandLine
{
    /// <summary>
    /// Provides information about a shell command (subcommand).
    /// </summary>
    public struct ShellCommandInfo
    {
        private readonly string _name;
        private readonly Type _commandType;
        private string? _description;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCommandInfo"/> struct.
        /// </summary>
        /// <param name="commandType">The type that implements the shell command.</param>
        /// <exception cref="ArgumentNullException">
        ///   <paramref name="commandType"/> is <see langword="null"/>.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///   <paramref name="commandType"/> is not a shell command type.
        /// </exception>
        public ShellCommandInfo(Type commandType)
        {
            _name = ShellCommand.GetShellCommandName(commandType);
            _commandType = commandType;
            _description = null;
        }

        private ShellCommandInfo(string name, Type commandType, string description)
        {
            _name = name;
            _commandType = commandType;
            _description = description;
        }

        /// <summary>
        /// Gets the name of the shell command.
        /// </summary>
        /// <value>
        /// The name of the shell command, based on either the <see cref="ShellCommandAttribute.CommandName"/>
        /// property or the <see cref="CommandType"/>'s name.
        /// </value>
        public string Name => _name;

        /// <summary>
        /// Gets the type that implements the shell command.
        /// </summary>
        /// <value>
        /// The type that implements the shell command.
        /// </value>
        public Type CommandType => _commandType;

        /// <summary>
        /// Gets the description of the shell command.
        /// </summary>
        /// <value>
        /// The description of the shell command, determined using the <see cref="DescriptionAttribute"/>
        /// attribute.
        /// </value>
        public string? Description => _description ??= ShellCommand.GetShellCommandDescription(_commandType);

        /// <summary>
        /// Gets a value that indicates if the shell command uses custom parsing.
        /// </summary>
        /// <remarks>
        /// The value of the command's <see cref="ShellCommandAttribute.CustomArgumentParsing"/>
        /// property.
        /// </remarks>
        public bool CustomArgumentParsing => CommandType.GetCustomAttribute<ShellCommandAttribute>()?.CustomArgumentParsing ?? false;

        /// <summary>
        /// Creates an instance of the shell command.
        /// </summary>
        /// <param name="args">The arguments to the shell command.</param>
        /// <param name="index">The index in <paramref name="args"/> at which to start parsing the arguments.</param>
        /// <param name="options">
        ///   The options that control parsing behavior. If <see langword="null" />, the default
        ///   options are used.
        /// </param>
        /// <returns>An instance of the <see cref="CommandType"/>.</returns>
        /// <exception cref="ArgumentNullException">
        ///   <paramref name="args"/>, or <paramref name="options"/> is <see langword="null"/>
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"/> does not fall inside the bounds of <paramref name="args"/>.</exception>
        public ShellCommand CreateInstance(string[] args, int index, ParseOptions? options = null)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            if (index < 0 || index > args.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            options ??= new();
            if (CustomArgumentParsing)
            {
                return (ShellCommand)Activator.CreateInstance(CommandType, args, index, options)!;
            }

            return (ShellCommand)CommandLineParser.ParseInternal(CommandType, args, index, options)!;
        }

        internal static ShellCommandInfo GetAutomaticVersionCommand()
        {
            return new ShellCommandInfo(Properties.Resources.AutomaticVersionCommandName,
                typeof(AutomaticVersionCommand), Properties.Resources.AutomaticVersionDescription);
        }
    }
}
