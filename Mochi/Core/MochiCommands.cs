// SPDX-License-Identifier: GPL-3.0-or-later

using Mochi.Core.Environment;

namespace Mochi.Core.Commands;

class MochiCommands
{

    internal static int ExecuteCommand(string input)
    {
        (string command, List<string> args) =  ParseCommand(input);

        if (command == "exit")
        {
            MochiEnvironment.Exit(0);
        }
        else
        {
            Console.WriteLine("Command unknown.");
            return 1;
        }

        return 0;
    }

    private static (string, List<string>) ParseCommand(string input)
    {
        string[] parts = input.Split(' ', 2);

        string command = parts[0];

        List<string> args = parts.Length > 1
            ? [.. parts[1].Split(' ', StringSplitOptions.RemoveEmptyEntries)]
            : [];

        return (command, args);
    }
}