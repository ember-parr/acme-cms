using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert spaces before each capital letter in a string ||
        /// Does not insert space if space already exists. 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
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

        /// <summary>
        /// Reformats string to Title Casing 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string TitleCase(this string source)
        {
            bool isAllUpperCase(string input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!Char.IsUpper(input[i]) && input[i].ToString() != " ") return false;
                }
                    return true;
            }

            TextInfo TextCasing = new CultureInfo("en-US", false).TextInfo;
            if(string.IsNullOrWhiteSpace(source))
            {
                return string.Empty;
            }
            // if the source contains a space in the middle
            else if (source.Trim().Contains(" "))
            {
                string lowerCased = source.ToLower();
                return TextCasing.ToTitleCase(lowerCased).Trim();
            }
            // if the source is all capitilized with no spaces in middle
            else if (isAllUpperCase(source) && !source.Contains(" "))
            {
                return TextCasing.ToTitleCase(source);
            }
            // if the source is regular all caps with spaces
            else 
            {
                var addSpaces = InsertSpaces(source);
                return TextCasing.ToTitleCase(addSpaces).Trim();
            }
        }

        /// <summary>
        /// Reformats string to all lower case (including first letter)
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string LowerCase(this string source)
        {
            TextInfo TextCasing = new CultureInfo("en-US", false).TextInfo;
            return TextCasing.ToLower(source).Trim();
        }

        /// <summary>
        /// Reformats string to sentence case (first letter capitalized after each period.)
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string SentenceCase(this string source)
        {
            var trimmed = source.Trim();
            string result = string.Empty;
            string[] sentences = Regex.Split(trimmed, @"(?<=[\.!\?])\s+");
            foreach (string sentence in sentences)
            {
                sentence.Trim();
                string fixedSentence = sentence[0].ToString().ToUpper() + sentence.Substring(1).ToLower() + " ";
                result += fixedSentence;
            }
            result[0].ToString().ToUpper();

            return result.Trim();
        }
    }
}
