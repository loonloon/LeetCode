/*
 * 1047. Remove All Adjacent Duplicates In String
 * https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
 */
namespace RemoveDuplicates2
{
    class Program
    {
        /*
         * Given a string S of lowercase letters, a duplicate removal consists of choosing two adjacent and equal letters, and removing them.
         * We repeatedly make duplicate removals on S until we no longer can.
         * Return the final string after all such duplicate removals have been made.  It is guaranteed the answer is unique.
         *
         * Example 1:
         * Input: "abbaca"
         * Output: "ca"
         * Explanation:
         * For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal,
         * and this is the only possible move.  The result of this move is that the string is "aaca",
         * of which only "aa" is possible, so the final string is "ca".
         *
         * Note:
         * 1 <= S.length <= 20000
         S consists only of English lowercase letters.
         */
        static void Main(string[] args)
        {
            var result = RemoveDuplicates("abbaca");
        }

        public static string RemoveDuplicates(string S)
        {
            var i = 0;

            while (i < S.Length - 1)
            {
                if (S[i] == S[i + 1])
                {
                    S = S.Remove(i, 2);
                    i -= i > 0 ? 2 : 1;
                }

                i += 1;
            }

            return S;

            //int i = 0, n = S.Length;
            //var stack = new char[n];

            //for (var j = 0; j < n; j++)
            //{
            //    if (i > 0 && stack[i - 1] == S[j])
            //    {
            //        --i;
            //    }
            //    else
            //    {
            //        stack[i++] = S[j];
            //    }
            //}

            //return new string(stack, 0, i);
        }
    }
}
