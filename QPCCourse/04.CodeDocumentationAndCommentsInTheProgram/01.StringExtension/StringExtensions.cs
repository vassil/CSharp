﻿namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// A static class that has extension methods for the string class
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Get MD5 hash from a string
        /// </summary>
        /// <param name="input">The string input</param>
        /// <returns>Return the hexadecimal string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            var hashedData = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var bytesCollector = new StringBuilder();

            for (int bytePosition = 0; bytePosition < hashedData.Length; bytePosition++)
            {
                bytesCollector.Append(hashedData[bytePosition].ToString("x2"));
            }

            return bytesCollector.ToString();
        }

        /// <summary>
        /// Checks if a string equals "true", "ok", "yes", "1" or "да"
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns>Returns True if string contains "true", "ok", "yes", "1", "да"</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Convert string representation of a number to its 16-bit signed integer equivalent
        /// </summary>
        /// <param name="input">A string representing 16 bit signed integer that will be checked for conversion</param>
        /// <returns>Returns a converted string to a 16-bit signed integer</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Convert string representation of a number to its 32-bit signed integer equivalent
        /// </summary>
        /// <param name="input">A string representing 32-bit signed integer that will be checked for conversion</param>
        /// <returns>Returns a converted string to a 32-bit signed integer</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Convert string representation of a number to its 64-bit signed integer equivalent
        /// </summary>
        /// <param name="input">A string representing 64-bit signed integer that will be checked for conversion</param>
        /// <returns>Returns a converted string to a 64-bit signed integer</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Convert string representation of a date and time to its System.DateTime equivalent
        /// </summary>
        /// <param name="input">A string representing date and/or time format that will be checked for conversion</param>
        /// <returns>Returns a date and/or time to its System.DateTime equivalent</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalize first letter of a string
        /// </summary>
        /// <param name="input">A string to capitalize first letter</param>
        /// <returns>
        /// Returns the same string like the input parameter, but with capital first letter.
        /// If input string is null or empty the method returns null or empty string
        /// </returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Get a string between two other strings
        /// </summary>
        /// <param name="input">The string which is searched between two other strings</param>
        /// <param name="startString">The string that makes the left border of the searched string(input) </param>
        /// <param name="endString">The string that makes the right border of the searched string(input)</param>
        /// <param name="startFrom">Default 32-bit signed integer that shows from where the searching will be started</param>
        /// <returns>
        /// Returns string between two other strings. If the start string or end string do not 
        /// exist in the input, or some of them is null or empty returns empty string.
        /// </returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts cyrillic to latin letters
        /// </summary>
        /// <param name="input">The string with cyrillic letters</param>
        /// <returns>Returns new string with latin letters</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts latin letters to cyrillic ones
        /// </summary>
        /// <param name="input">The string with latin letters</param>
        /// <returns>Returns string with cyrillic letters</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Convert a string representation of a username to its valid one
        /// </summary>
        /// <param name="input">A string that represents invalid user name</param>
        /// <returns>Returns valid user name(removes invalid chars for user name)</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Convert a string representation of a file name to its latin valid one
        /// </summary>
        /// <param name="input">A string that represents file name</param>
        /// <returns>Returns valid latin file name(replaces cyrillic letters with latin ones, and removes invalid chars)</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Get a sequence of characters from string
        /// </summary>
        /// <param name="input">A string to manipulate</param>
        /// <param name="charsCount">32-signed integer value that shows the number of first characters</param>
        /// <returns>Returns first defined sequence of characters from string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Get file extension of a file name represented as a string
        /// </summary>
        /// <param name="fileName">A string that represents file name</param>
        /// <returns>Returns file extension from file name, represented as sting. If file name is invalid returns empty string</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Get the content type of a file extension represented as a string
        /// </summary>
        /// <param name="fileExtension">A string that represents file extension</param>
        /// <returns>Returns the content type of file extension. If file extension is not found returns
        /// string with value "application/octet-stream".
        /// </returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Get decimal representations in ASCII table of each character in a defined string
        /// </summary>
        /// <param name="input">A string to convert to byte array</param>
        /// <returns>Returns byte array with the decimal representation in ASCII table of each character in defined string</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
