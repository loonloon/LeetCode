using System.Collections.Generic;
/*
 * 859. Buddy Strings
 * https://leetcode.com/problems/buddy-strings/
 */
namespace BuddyStrings
{
    class Program
    {
        /*
         * Given two strings A and B of lowercase letters, return true if and only if we can swap two letters in A so that the result equals B.
         *
         * Example 1:
         * Input: A = "ab", B = "ba"
         * Output: true
         *
         * Example 2:
         * Input: A = "ab", B = "ab"
         * Output: false
         *
         * Example 3:
         * Input: A = "aa", B = "aa"
         * Output: true
         *
         * Example 4:
         * Input: A = "aaaaaaabc", B = "aaaaaaacb"
         * Output: true
         *
         * Example 5:
         * Input: A = "", B = "aa"
         * Output: false
         *
         */
        static void Main(string[] args)
        {
            var result = BuddyStrings("ab", "ba");
            var result2 = BuddyStrings("ab", "ab");
            var result3 = BuddyStrings("aa", "aa");
            var result4 = BuddyStrings("aaaaaaabc", "aaaaaaacb");
            var result5 = BuddyStrings("", "aa");
        }

        public static bool BuddyStrings(string A, string B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            //example 2 and 3
            if (A.Equals(B))
            {
                var hashSet = new HashSet<char>();

                foreach (var character in A.ToCharArray())
                {
                    hashSet.Add(character);
                }

                return hashSet.Count < A.Length;
            }

            var difference = new List<int>();

            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i])
                {
                    continue;
                }

                difference.Add(i);
            }

            return difference.Count == 2 &&
                   A[difference[0]] == B[difference[1]] &&
                   A[difference[1]] == B[difference[0]];
        }
    }
}
