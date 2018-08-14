/*
 * 766. Toeplitz Matrix
 * https://leetcode.com/problems/toeplitz-matrix/description/
 */
namespace IsToeplitzMatrix
{
    class Program
    {
        /*
         * A matrix is Toeplitz if every diagonal from top-left to bottom-right has the same element.
         * Now given an M x N matrix, return True if and only if the matrix is Toeplitz.
         *
         * Example 1:
         * Input:
         * matrix =
         * [[1,2,3,4],
         * [5,1,2,3],
         * [9,5,1,2]]
         *
         * Output: True
         * Explanation:
         * In the above grid, the diagonals are:
         * "[9]", "[5, 5]", "[1, 1, 1]", "[2, 2, 2]", "[3, 3]", "[4]".
         * In each diagonal all elements are the same, so the answer is True.
         *
         * Example 2:
         * Input:
         * matrix =
         * [[1,2],
         * [2,2]]
         *
         * Output: False
         * Explanation:
         * The diagonal "[1, 2]" has different elements.
         *
         * Note:
         * matrix will be a 2D array of integers.
         * matrix will have a number of rows and columns in range [1, 20].
         * matrix[i][j] will be integers in range [0, 99].
         *
         */
        static void Main(string[] args)
        {
            var result = IsToeplitzMatrix(new[,]
            {
                {1, 2, 3, 4},
                {5, 1, 2, 3},
                {9, 5, 1, 2}
            });

            var result2 = IsToeplitzMatrix(new[,]
            {
                {1, 2},
                {2, 2}
            });
        }

        public static bool IsToeplitzMatrix(int[,] matrix)
        {
            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row > 0 && col > 0 && matrix[row - 1, col - 1] != matrix[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
