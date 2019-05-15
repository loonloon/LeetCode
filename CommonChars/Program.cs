using System;
using System.Collections.Generic;

/*
 * 1002. Find Common Characters
 * https://leetcode.com/problems/find-common-characters/
 */
namespace CommonChars
{
    class Program
    {
        /*
         * Given an array A of strings made only from lowercase letters,
         * return a list of all characters that show up in all strings within the list (including duplicates).
         *
         * For example, if a character occurs 3 times in all strings but not 4 times,
         * you need to include that character three times in the final answer.
         *
         * You may return the answer in any order.
         *
         * Example 1:
         * Input: ["bella","label","roller"]
         * Output: ["e","l","l"]
         *
         * Example 2:
         * Input: ["cool","lock","cook"]
         * Output: ["c","o"]
         *
         * Note:
         * 1 <= A.length <= 100
         * 1 <= A[i].length <= 100
         * A[i][j] is a lowercase letter
         *
         */
        static void Main(string[] args)
        {
            var result = CommonChars(new[] { "bella", "label", "roller" });
            var result2 = CommonChars(new[] { "cool", "lock", "cook" });
        }

        public static IList<string> CommonChars(string[] A)
        {
            var ans = new List<string>();
            var count = new int[26];

            for (var i = 0; i < count.Length; i++)
            {
                count[i] = int.MaxValue;
            }

            for (var index = 0; index < A.Length; index++)
            {
                var str = A[index];
                var cnt = new int[26];

                // count each char's frequency in string str.
                for (var i = 0; i < str.Length; i++)
                {
                    ++cnt[str[i] - 'a'];
                }

                // update minimum frequency.
                for (var i = 0; i < 26; i++)
                {
                    count[i] = Math.Min(cnt[i], count[i]);
                }
            }

            for (var c = 'a'; c <= 'z'; c++)
            {
                while (count[c - 'a']-- > 0)
                {
                    ans.Add("" + c);
                }
            }

            return ans;
        }
    }
}
