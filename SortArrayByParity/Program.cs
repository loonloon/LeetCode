/*
 * 905. Sort Array By Parity
 * https://leetcode.com/problems/sort-array-by-parity/
 */
namespace SortArrayByParity
{
    class Program
    {
        /*
         * Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.
         * You may return any answer array that satisfies this condition.
         *
         * Example 1:
         * Input: [3,1,2,4]
         * Output: [2,4,3,1]
         * The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
         *
         * Note:
         * 1 <= A.length <= 5000
         * 0 <= A[i] <= 5000
         *
         */
        static void Main(string[] args)
        {
            var result = SortArrayByParity(new[] { 3, 1, 2, 4 });
        }

        public static int[] SortArrayByParity(int[] A)
        {
            for (int i = 0, j = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    continue;
                }

                var temp = A[j];
                A[j++] = A[i];
                A[i] = temp;
            }

            return A;
        }
    }
}
