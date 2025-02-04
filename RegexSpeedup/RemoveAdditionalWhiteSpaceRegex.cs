﻿using System;
using System.Text.RegularExpressions;

namespace RegexSpeedup
{
    public static class RemoveAdditionalWhiteSpaceRegex
    {
        private static readonly Regex _whiteSpaceRegex = new Regex(@"\s+", RegexOptions.Compiled);

        public static string ReplaceWhiteSpaces(string text)
        {
            return _whiteSpaceRegex.Replace(text, " ").Trim();
        }
    }
}