using System.Linq;

/*
 * 500. Keyboard Row
 * https://leetcode.com/problems/keyboard-row/description/
 */

namespace FindWords
{
    class Program
    {
        /*
         * Given a List of words, return the words that can be typed using letters of
         * alphabet on only one row's of American keyboard like the image below.
         *
         * Example 1:
         * Input: ["Hello", "Alaska", "Dad", "Peace"]
         * Output: ["Alaska", "Dad"]
         *
         * Note:
         * You may use one character in the keyboard more than once.
         * You may assume the input string will only contain letters of alphabet.
         *
         */
        static void Main(string[] args)
        {
            var result = FindWords(new[] { "Hello", "Alaska", "Dad", "Peace" });
        }

        public static string[] FindWords(string[] words)
        {
            var firstRow = "qwertyuiop";
            var secondRow = "asdfghjkl";
            var thirdRow = "zxcvbnm";
            return words.Where(word => word.ToLower().All(x => firstRow.Contains(x)) ||
                                       word.ToLower().All(x => secondRow.Contains(x)) ||
                                       word.ToLower().All(x => thirdRow.Contains(x))).ToArray();
        }
    }
}
