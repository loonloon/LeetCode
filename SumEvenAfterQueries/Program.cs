/*
 * 985. Sum of Even Numbers After Queries
 * https://leetcode.com/problems/sum-of-even-numbers-after-queries/
 */
namespace SumEvenAfterQueries
{
    class Program
    {
        /*
         * We have an array A of integers, and an array queries of queries.
         * For the i-th query val = queries[i][0], index = queries[i][1], we add val to A[index].
         * Then, the answer to the i-th query is the sum of the even values of A.
         *
         * (Here, the given index = queries[i][1] is a 0-based index, and each query permanently modifies the array A.)
         * Return the answer to all queries.  Your answer array should have answer[i] as the answer to the i-th query.
         *
         * Example 1:
         * Input: A = [1,2,3,4], queries = [[1,0],[-3,1],[-4,0],[2,3]]
         * Output: [8,6,2,4]
         * Explanation:
         *
         * At the beginning, the array is [1,2,3,4].
         * After adding 1 to A[0], the array is [2,2,3,4], and the sum of even values is 2 + 2 + 4 = 8.
         * After adding -3 to A[1], the array is [2,-1,3,4], and the sum of even values is 2 + 4 = 6.
         * After adding -4 to A[0], the array is [-2,-1,3,4], and the sum of even values is -2 + 4 = 2.
         * After adding 2 to A[3], the array is [-2,-1,3,6], and the sum of even values is -2 + 6 = 4.
         *
         * Note:
         * 1 <= A.length <= 10000
         * -10000 <= A[i] <= 10000
         * 1 <= queries.length <= 10000
         * -10000 <= queries[i][0] <= 10000
         * 0 <= queries[i][1] < A.length
         *
         */
        static void Main(string[] args)
        {
            var result = SumEvenAfterQueries(new[] { 1, 2, 3, 4 }, new[]
            {
                new[] { 1, 0},
                new[] { -3, 1 },
                new[] { -4, 0 },
                new[] { 2, 3 }
            });
        }

        public static int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var sum = 0;

            //sum all of even num in A
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    sum += A[i];
                }
            }

            var ans = new int[queries.Length];

            for (var i = 0; i < queries.Length; i++)
            {
                var index = queries[i][1];

                //sum is all even num of A
                //remove A[index] even number from sum first, because the A[index] may not be even number after += val
                if (A[index] % 2 == 0)
                {
                    sum -= A[index];
                }

                var val = queries[i][0];
                A[index] += val;

                if (A[index] % 2 == 0)
                {
                    sum += A[index];
                }

                ans[i] = sum;
            }

            return ans;

            //easy understand, but slow
            //var ans = new int[queries.Length];

            //for (var i = 0; i < queries.Length; i++)
            //{
            //    var index = queries[i][1];
            //    var val = queries[i][0];
            //    A[index] += val;

            //    for (var j = 0; j < A.Length; j++)
            //    {
            //        if (A[j] % 2 == 0)
            //        {
            //            ans[i] += A[j];
            //        }
            //    }
            //}

            //return ans;
        }
    }
}
