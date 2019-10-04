using System;
/*
 * 1160. Find Words That Can Be Formed by Characters
 * https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/
 */
namespace CountCharacters
{
    class Program
    {
        /*
         * You are given an array of strings words and a string chars.
         * A string is good if it can be formed by characters from chars (each character can only be used once).
         *
         * Return the sum of lengths of all good strings in words.
         *
         * Example 1:
         * Input: words = ["cat","bt","hat","tree"], chars = "atach"
         * Output: 6
         *
         * Explanation:
         * The strings that can be formed are "cat" and "hat" so the answer is 3 + 3 = 6.
         *
         * Example 2:
         * Input: words = ["hello","world","leetcode"], chars = "welldonehoneyr"
         * Output: 10
         *
         * Explanation:
         * The strings that can be formed are "hello" and "world" so the answer is 5 + 5 = 10.
         *
         * Note:
         * 1 <= words.length <= 1000
         * 1 <= words[i].length, chars.length <= 100
         * All strings contain lowercase English letters only.
         *
         */
        static void Main(string[] args)
        {
            var result = CountCharacters(new[] { "cat", "bt", "hat", "tree" }, "atach");
            var result2 = CountCharacters(new[] { "hello", "world", "leetcode" }, "welldonehoneyr");
        }

        public static int CountCharacters(string[] words, string chars)
        {
            var ascii = new int[26];
            var count = 0;

            for (var i = 0; i < chars.Length; i++)
            {
                ascii[chars[i] - 'a']++;
            }

            for (var i = 0; i < words.Length; i++)
            {
                int j;
                var tempAscii = new int[26];
                Array.Copy(ascii, 0, tempAscii, 0, ascii.Length);
                var word = words[i];

                for (j = 0; j < word.Length; j++)
                {
                    var characterIndex = word[j] - 'a';

                    if (tempAscii[characterIndex] > 0)
                    {
                        tempAscii[characterIndex]--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (j == word.Length)
                {
                    count += word.Length;
                }
            }

            return count;
        }
    }
}
