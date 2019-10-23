using System.Collections.Generic;
using System.Linq;
/*
 * 205. Isomorphic Strings
 * https://leetcode.com/problems/isomorphic-strings/
 */
namespace IsIsomorphic
{
    class Program
    {
        /*
         * Given two strings s and t, determine if they are isomorphic.
         * Two strings are isomorphic if the characters in s can be replaced to get t.
         *
         * All occurrences of a character must be replaced with another character while preserving the order of characters.
         * No two characters may map to the same character but a character may map to itself.
         *
         * Example 1:
         * Input: s = "egg", t = "add"
         * Output: true
         *
         * Example 2:
         * Input: s = "foo", t = "bar"
         * Output: false
         *
         * Example 3:
         * Input: s = "paper", t = "title"
         * Output: true
         *
         * Note:
         * You may assume both s and t have the same length.
         *
         */
        static void Main(string[] args)
        {
            var result = IsIsomorphic("egg", "add");
            var result2 = IsIsomorphic("foo", "bar");
            var result3 = IsIsomorphic("paper", "title");
        }

        public static bool IsIsomorphic(string s, string t)
        {
            if ((s == null || t == null) || (s.Length != t.Length))
            {
                return false;
            }

            var sPattern = GetNumPattern(s);
            var tPattern = GetNumPattern(t);

            if (sPattern.Count != tPattern.Count)
            {
                return false;
            }

            return !sPattern.Where((t1, i) => t1 != tPattern[i]).Any();
        }

        public static List<int> GetNumPattern(string s)
        {
            var dict = new Dictionary<char, int>();
            var pattern = new List<int>();

            foreach (var c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    /* Generate unique number for each unique character */
                    dict.Add(c, dict.Count + 1);
                }

                pattern.Add(dict[c]);
            }

            return pattern;
        }

        //public static int[] Encode(string s)
        //{
        //    var map = new int[256];
        //    var output = new int[s.Length];

        //    Array.Fill(map, -1);

        //    var charArray = s.ToCharArray();

        //    for (var i = 0; i < charArray.Length; i++)
        //    {
        //        var index = (int)charArray[i];

        //        if (map[index] == -1)
        //        {
        //            output[i] = i;
        //            map[index] = i;
        //        }
        //        else
        //        {
        //            output[i] = map[index];
        //        }
        //    }

        //    return output;
        //}
    }
}
