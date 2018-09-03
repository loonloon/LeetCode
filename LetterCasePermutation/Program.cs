using System.Collections.Generic;
using System.Linq;
/*
 * 784. Letter Case Permutation
 * https://leetcode.com/problems/letter-case-permutation/
 */
namespace LetterCasePermutation
{
    class Program
    {
        /*
         * Given a string S, we can transform every letter individually to be lowercase or uppercase to create another string.
         * Return a list of all possible strings we could create.
         *
         * Examples:
         * Input: S = "a1b2"
         * Output: ["a1b2", "a1B2", "A1b2", "A1B2"]
         *
         * Input: S = "3z4"
         * Output: ["3z4", "3Z4"]
         *
         * Input: S = "12345"
         * Output: ["12345"]
         *
         * Note:
         * S will be a string with length at most 12.
         * S will consist only of letters or digits.
         *
         */
        static void Main(string[] args)
        {
            var result = LetterCasePermutation("a1b2");
            var result2 = LetterCasePermutation("3z4");
            var result3 = LetterCasePermutation("12345");
        }

        public static IList<string> LetterCasePermutation(string S)
        {
            if (S == null)
            {
                return new List<string>();
            }

            var queue = new Queue<string>();
            queue.Enqueue(S);

            for (var i = 0; i < S.Length; i++)
            {
                if (char.IsDigit(S[i]))
                {
                    continue;
                }

                var size = queue.Count;

                for (var j = 0; j < size; j++)
                {
                    var word = queue.Dequeue();
                    var chars = word.ToCharArray();

                    chars[i] = char.ToUpper(chars[i]);
                    queue.Enqueue(new string(chars));

                    chars[i] = char.ToLower(chars[i]);
                    queue.Enqueue(new string(chars));
                }
            }

            return queue.ToList();
        }
    }
}
