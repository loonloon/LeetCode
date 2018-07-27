using System.Linq;

/*
 * 561. Array Partition I
 * https://leetcode.com/problems/array-partition-i/description/
 */
namespace ArrayPairSum
{
    class Program
    {
        /*
         * Given an array of 2n integers, your task is to group these integers into n pairs of integer,
         * say (a1, b1), (a2, b2), ..., (an, bn) which makes sum of min(ai, bi)
         * for all i from 1 to n as large as possible.
         *
         * Example 1:
         * Input: [1,4,3,2]
         * Output: 4
         * Explanation: n is 2, and the maximum sum of pairs is 4 = min(1, 2) + min(3, 4).
         *
         */
        static void Main(string[] args)
        {
            var result = ArrayPairSum(new[] { 1, 4, 3, 2 });
        }

        public static int ArrayPairSum(int[] nums)
        {
            var orderedNumbers = nums.OrderBy(x => x).ToList();
            var total = 0;

            for (var i = 0; i < orderedNumbers.Count; i += 2)
            {
                total += orderedNumbers[i] + orderedNumbers[i + 1];
            }

            return total;
        }
    }
}
