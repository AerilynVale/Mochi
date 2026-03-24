// SPDX-License-Identifier: GPL-3.0-or-later

namespace Mochi.Core.Commands;

class MochiCommands
{
    internal static int ExecuteCommand(string input)
    {
        (string command, List<string> args) =  ParseCommand(input);
        Console.WriteLine($"{command} -- args:");

        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }

        return 0;
    }

    private static (string, List<string>) ParseCommand(string input)
    {
        string[] parts = input.Split(' ', 2);

        string command = parts[0];

        List<string> args = parts.Length > 1
            ? parts[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList()
            : new List<string>();

        return (command, args);
    }
}