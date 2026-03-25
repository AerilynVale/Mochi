// SPDX-License-Identifier: GPL-3.0-or-later

using Mochi.Core.Environment;

namespace Mochi.Core.Prompt;

class MochiPrompt
{
    internal static string GetPrompt()
    {
        string path = MochiEnvironment.GetPath() ?? string.Empty;

        if (string.IsNullOrEmpty(path)) {
            return "[UNABLE TO GENERATE PROMPT] ";
        }

        return $"{path}> ";
    }
}