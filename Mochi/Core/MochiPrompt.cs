// SPDX-License-Identifier: GPL-3.0-or-later

namespace Mochi.Core.Prompt;

class MochiPrompt
{
    internal static string GetPrompt()
    {
        string path = GetPath() ?? string.Empty;

        if (string.IsNullOrEmpty(path)) {
            return "[UNABLE TO GENERATE PROMPT] ";
        }

        return $"{path}> ";
    }

    private static string? GetPath()
    {
        try
        {
            return Directory.GetCurrentDirectory();
        } catch (Exception e)
        {
            Console.WriteLine($"Error, unable to get current directory: {e}");
            return null;
        }
    }
}