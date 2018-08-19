using System.Collections.Generic;
using System.Linq;

/*
 * 888. Fair Candy Swap
 * https://leetcode.com/problems/fair-candy-swap/description/
 */
namespace FairCandySwap
{
    class Program
    {
        /*
         * Alice and Bob have candy bars of different sizes: A[i] is the size of the i-th bar of candy that Alice has, and B[j] is the size of the j-th bar of candy that Bob has.
         *
         * * Since they are friends, they would like to exchange one candy bar each so that after the exchange, they both have the same total amount of candy.
         * (The total amount of candy a person has is the sum of the sizes of candy bars they have.)
         *
         * Return an integer array ans where ans[0] is the size of the candy bar that Alice must exchange, and ans[1] is the size of the candy bar that Bob must exchange.
         *
         * If there are multiple answers, you may return any one of them.  It is guaranteed an answer exists.
         *
         * Example 1:
         * Input: A = [1,1], B = [2,2]
         * Output: [1,2]
         *
         * Example 2:
         * Input: A = [1,2], B = [2,3]
         * Output: [1,2]
         *
         * Example 3:
         * Input: A = [2], B = [1,3]
         * Output: [2,3]
         *
         * Example 4:
         * Input: A = [1,2,5], B = [2,4]
         * Output: [5,4]
         *
         * Note:
         * 1 <= A.length <= 10000
         * 1 <= B.length <= 10000
         * 1 <= A[i] <= 100000
         * 1 <= B[i] <= 100000
         * It is guaranteed that Alice and Bob have different total amounts of candy.
         * It is guaranteed there exists an answer.
         *
         */
        static void Main(string[] args)
        {
            var result = FairCandySwap(new[] { 1, 1 }, new[] { 2, 2 });
            var result2 = FairCandySwap(new[] { 1, 2 }, new[] { 2, 3 });
            var result3 = FairCandySwap(new[] { 2 }, new[] { 1, 3 });
            var result4 = FairCandySwap(new[] { 1, 2, 5 }, new[] { 2, 4 });
        }

        public static int[] FairCandySwap(int[] A, int[] B)
        {
            var different = (A.Sum() - B.Sum()) / 2;
            var hash = new HashSet<int>(A);

            foreach (var b in B)
            {
                if (hash.Contains(b + different))
                {
                    return new[] { b + different, b };
                }
            }

            return new[] { 0 };
        }
    }
}
