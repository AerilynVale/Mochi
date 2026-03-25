// SPDX-License-Identifier: GPL-3.0-or-later

using Mochi.Core.Commands;
using Mochi.Core.Prompt;
using Mochi.Core.Environment;

namespace Mochi.Core;

class MochiCore
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Mochi v0.1.0-alpha.");
        Console.WriteLine("Copyright (c) 2026 Aerilyn Vale and contributers. GNU GPL-3.0-or-later.\n");

        int exitCode = await MochiKernel.RunAsync();

        MochiEnvironment.Exit(0);
    }
}

class MochiKernel
{
    internal static async Task<int> RunAsync()
    {
        string prompt = MochiPrompt.GetPrompt();

        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) continue;

            int result = MochiCommands.ExecuteCommand(input);

            Console.WriteLine($"Process exited with exit code {result}");
        }
    }
}