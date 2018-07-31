using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using NLog;

namespace Prana.Tools
{
    class String
    {
        public static string Capitalize(string str)
        {
            string tmp = str.Replace("_", " ");
            return tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower();
        }

        public static string Substring(string str, int length)
        {
            string tmp = str.Length <= length ? str : str.Substring(0, length);

            return tmp;
        }

        public static bool IsValidEmailAddress(string s)
        {
            var regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return regex.IsMatch(s);
        }


        /// <summary>
        /// Takes the first character of an input string and makes it uppercase
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>String with the first character capitalized</returns>
        public static string ToFirstCharacterUpperCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;
            char[] inputChars = input.ToCharArray();
            for (int x = 0; x < inputChars.Length; ++x)
            {
                if (inputChars[x] != ' ' && inputChars[x] != '\t')
                {
                    inputChars[x] = char.ToUpper(inputChars[x]);
                    break;
                }
            }
            return new string(inputChars);
        }

        /// <summary>
        /// Removes control characters and other non-UTF-8 characters
        /// </summary>
        /// <param name="inString">The string to process</param>
        /// <returns>A string with no control characters or entities above 0x00FD</returns>
        public static string RemoveTroubleSomeCharacters(string inString)
        {
            if (inString == null) return null;

            var newString = new StringBuilder();
            char ch;

            for (int i = 0; i < inString.Length; i++)
            {

                ch = inString[i];
                // remove any characters outside the valid UTF-8 range as well as all control characters
                // except tabs and new lines
                if ((ch < 0x00FD && ch > 0x001F) || ch == '\t' || ch == '\n' || ch == '\r')
                {
                    newString.Append(ch);
                }
            }
            return newString.ToString();

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <see cref="http://stackoverflow.com/questions/309485/c-sharp-sanitize-file-name"/>
        /// <returns></returns>
        public static string MakeValidFileName(string name)
        {
            string invalidChars = Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidReStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);
            return Regex.Replace(name, invalidReStr, "_");
        }
    }

    public static class StringToolsExtensions
    {
        static Logger logger = LogManager.GetCurrentClassLogger();

        public static string StripHtml(this string htmlText)
        {
            var reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            return reg.Replace(htmlText, "");
        }

        public static string RemoveTroubleSomeCharacters(this string str)
        {
            return String.RemoveTroubleSomeCharacters(str);
        }

        public static string MakeValidFileName(this string str)
        {
            return String.MakeValidFileName(str);
        }

        public static List<string> Split(this string str)
        {
            return str.Split(',').ToList();
        }

        public static string Capitalize(this string str)
        {
            string tmp = str.Replace("_", " ");
            return tmp[0].ToString().ToUpper() + tmp.Substring(1).ToLower();
        }

        /// <summary>
        /// Takes the first character of an input string and makes it uppercase
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>String with the first character capitalized</returns>
        public static string ToFirstCharacterUpperCase(this string str)
        {
            return String.ToFirstCharacterUpperCase(str);
        }
    }
}
