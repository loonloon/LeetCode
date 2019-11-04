using System.Collections.Generic;
/*
 * 290. Word Pattern
 * https://leetcode.com/problems/word-pattern/
 */
namespace WordPattern
{
    class Program
    {
        /*
         * Given a pattern and a string str, find if str follows the same pattern.
         * Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in str.
         *
         * Example 1:
         * Input: pattern = "abba", str = "dog cat cat dog"
         * Output: true
         *
         * Example 2:
         * Input:pattern = "abba", str = "dog cat cat fish"
         * Output: false
         *
         * Example 3:
         * Input: pattern = "aaaa", str = "dog cat cat dog"
         * Output: false
         *
         * Example 4:
         * Input: pattern = "abba", str = "dog dog dog dog"
         * Output: false
         *
         * Notes:
         * You may assume pattern contains only lowercase letters, and str contains lowercase letters that may be separated by a single space.
         *
         */
        static void Main(string[] args)
        {
            var result = WordPattern("abba", "dog cat cat dog");
            var result2 = WordPattern("abba", "dog cat cat fish");
            var result3 = WordPattern("aaaa", "dog cat cat dog");
            var result4 = WordPattern("abba", "dog dog dog dog");
        }

        public static bool WordPattern(string pattern, string str)
        {
            var words = str.Split(" ");

            if (pattern.Length != words.Length)
            {
                return false;
            }

            //e.g.
            //a = dog
            //b = cat
            var patternMapping = new Dictionary<char, string>();

            for (var i = 0; i < words.Length; i++)
            {
                var patternCharacter = pattern[i];
                var word = words[i];

                if (patternMapping.ContainsKey(patternCharacter))
                {
                    if (!word.Equals(patternMapping[patternCharacter]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (patternMapping.ContainsValue(word))
                    {
                        return false;
                    }

                    patternMapping.Add(patternCharacter, word);
                }
            }

            return true;
        }
    }
}
