// SPDX-License-Identifier: GPL-3.0-or-later

using Mochi.Core.Prompt;

namespace Mochi.Core;

class MochiCore
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Mochi v0.1.0-alpha.");
        Console.WriteLine("Copyright (c) 2026 Aerilyn Vale and contributers. GNU GPL-3.0-or-later.\n");

        var kernel = new MochiKernel();

        int exitCode = await kernel.RunAsync();

        Environment.Exit(exitCode);
    }
}

class MochiKernel
{
    public async Task<int> RunAsync()
    {
        string prompt = MochiPrompt.GetPrompt();

        while (true)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) continue;
            if (input == "exit") return 0;

            await ExecuteCommand(input);
        }
    }

    private async Task ExecuteCommand(string input)
    {
        Console.WriteLine($"Running command for {input}.");
    }
}