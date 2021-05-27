using System;
using System.Globalization;
using System.Text.RegularExpressions;

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

        //public string SentenceCase(string source)
        //{
        //    var lowercase = source.ToLower();
        //    var r = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
        //    var result = r.Replace(lowercase, source => source.Value.ToUpper());
        //    return result.Trim();
        //}

        public string SentenceCase(string source)
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
