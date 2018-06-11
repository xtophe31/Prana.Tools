using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Prana.Tools
{
    partial class Random
    {
        /// <summary>
        /// returns a randomly generated string
        /// </summary>
        /// <param name="length">Length of the string</param>
        /// <returns>a randomly generated string of the specified length</returns>
        public string NextString(int length)
        {
            if (length < 1)
                return "";
            return NextString(length, ".");
        }

        /// <summary>
        /// Returns a randomly generated string of a specified length, containing
        /// only a set of characters, and at max a specified number of non alpha numeric characters.
        /// </summary>
        /// <param name="length">Length of the string</param>
        /// <param name="allowedCharacters">Characters allowed in the string</param>
        /// <param name="numberOfNonAlphaNumericsAllowed">Number of non alpha numeric characters allowed.</param>
        /// <returns>A randomly generated string of a specified length, containing only a set of characters, and at max a specified number of non alpha numeric characters.</returns>
        public string NextString(int length, string allowedCharacters, int numberOfNonAlphaNumericsAllowed)
        {
            if (length < 1)
                return "";
            var tempBuilder = new StringBuilder();
            var comparer = new Regex(allowedCharacters);
            var alphaNumbericComparer = new Regex("[0-9a-zA-z]");
            int counter = 0;
            while (tempBuilder.Length < length)
            {
                var tempValue = new string(Convert.ToChar(Convert.ToInt32(Math.Floor(94 * NextDouble() + 32))), 1);
                if (comparer.IsMatch(tempValue))
                {
                    if (!alphaNumbericComparer.IsMatch(tempValue) && numberOfNonAlphaNumericsAllowed > counter)
                    {
                        tempBuilder.Append(tempValue);
                        ++counter;
                    }
                    else if (alphaNumbericComparer.IsMatch(tempValue))
                    {
                        tempBuilder.Append(tempValue);
                    }
                }
            }
            return tempBuilder.ToString();
        }

        /// <summary>
        /// Returns a randomly generated string of a specified length, containing
        /// only a set of characters
        /// </summary>
        /// <param name="length">length of the string</param>
        /// <param name="allowedCharacters">string of characters that are allowed in the string</param>
        /// <returns>A randomly generated string of the specified length, containing only the allowed characters.</returns>
        public string NextString(int length, string allowedCharacters)
        {
            if (length < 1)
                return "";
            return NextString(length, allowedCharacters, length);
        }

        /// <summary>
        /// Returns a randomly generated letter, containing only a set of characters
        /// </summary>
        /// <param name="allowedCharacters">Array of characters that are allowed in the string</param>
        /// <returns>A randomly generated string of the specified length, containing only the allowed characters.</returns>
        public string NextLetter(string[] allowedCharacters)
        {
            return allowedCharacters[Next(0, allowedCharacters.Length - 1)];
        }

        /// <summary>
        /// Returns a randomly generated string looking as a real word using vowels and consonants.
        /// Those words are nonsense but flollow language conventions closely enough to be readable and memorable by humans.
        /// </summary>
        /// <param name="requestedLength">length of the string</param>
        /// <returns>A randomly generated string</returns>
        public string NextWord(int requestedLength)
        {
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] vowels = { "a", "e", "i", "o", "u" };

            string word = "";

            if (requestedLength == 1)
                word = NextLetter(vowels);
            else
            {
                for (int i = 0; i < requestedLength; i += 2)
                    word += NextLetter(consonants) + NextLetter(vowels);

                word = word.Replace("q", "qu").Substring(0, requestedLength); // We may generate a string longer than requested length, but it doesn't matter if cut off the excess.
            }

            return word;
        }


    }
}
