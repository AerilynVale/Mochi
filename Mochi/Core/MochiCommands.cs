// SPDX-License-Identifier: GPL-3.0-or-later

namespace Mochi.Core.Commands;

class MochiCommands
{
    internal static int ExecuteCommand(string input)
    {
        Console.WriteLine($"Running command for {input}.");
        return 0;
    }
}