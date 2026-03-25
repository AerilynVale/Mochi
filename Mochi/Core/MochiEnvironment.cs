// SPDX-License-Identifier: GPL-3.0-or-later

namespace Mochi.Core.Environment;

class MochiEnvironment
{
    internal static void Exit(int exitCode)
    {
        System.Environment.Exit(exitCode);
    }

    internal static string? GetPath()
    {
        try
        {
            return Directory.GetCurrentDirectory();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error, unable to get current directory: {e}");
            return null;
        }
    }
}