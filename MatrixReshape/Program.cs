using System.Collections.Generic;
using System.Linq;

/*
 * 566. Reshape the Matrix
 * https://leetcode.com/problems/reshape-the-matrix/description/
 */

namespace MatrixReshape
{
    class Program
    {
        /*
         * In MATLAB, there is a very useful function called 'reshape', which can reshape a matrix into a new one with different size but keep its original data.
         * You're given a matrix represented by a two-dimensional array,
         * and two positive integers r and c representing the row number and column number of the wanted reshaped matrix, respectively.
         *
         * The reshaped matrix need to be filled with all the elements of the original matrix in the same row-traversing order as they were.
         * If the 'reshape' operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.
         *
         * Example 1:
         * Input:
         * nums =
         * [[1,2],
         * [3,4]]
         * r = 1, c = 4
         *
         * Output:
         * [[1,2,3,4]]
         *
         * Explanation:
         * The row-traversing of nums is [1,2,3,4]. The new reshaped matrix is a 1 * 4 matrix, fill it row by row by using the previous list.
         *
         * Example 2:
         * Input:
         * nums =
         * [[1,2],
         * [3,4]]
         * r = 2, c = 4
         *
         * Output:
         * [[1,2],
         * [3,4]]
         *
         * Explanation:
         * There is no way to reshape a 2 * 2 matrix to a 2 * 4 matrix. So output the original matrix.
         *
         */
        static void Main(string[] args)
        {
            var result = MatrixReshape(new[,] { { 1, 2 }, { 3, 4 } }, 1, 4);
        }

        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            var totalNumbers = r * c;

            if (totalNumbers != nums.Length)
            {
                return nums;
            }

            var reshapeNumbers = new int[r, c];
            var numList = nums.Cast<int>().ToList();
            var queue = new Queue<int>(numList);

            for (var i = 0; i < r; i++)
            {
                for (var j = 0; j < c; j++)
                {
                    reshapeNumbers[i, j] = queue.Dequeue();
                }
            }

            return reshapeNumbers;
        }
    }
}
