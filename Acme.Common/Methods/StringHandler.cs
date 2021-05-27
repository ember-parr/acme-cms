﻿using System;
using System.Globalization;


namespace Acme.Common.Methods
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            string result = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }

        public string TitleCase(string source)
        {
            TextInfo TextCasing = new CultureInfo("en-US", false).TextInfo;
            return TextCasing.ToTitleCase(source).Trim();
        }

        public string LowerCase(string source)
        {
            TextInfo TextCasing = new CultureInfo("en-US", false).TextInfo;
            return TextCasing.ToLower(source).Trim();
        }
    }
}