using System;

namespace Helpers {
    public static class RandomExtensions {
        public static char GetRandomChar(this Random random, string s) {
            int index = random.Next(0, s.Length - 1);
            char letter = s[index];
            return letter;
        }
    }

    public static class StringExtensions {
        public static string Capitalize(this string s) {
            return s[0].ToString().ToUpper() + s.Substring(1);
        }
    }
}