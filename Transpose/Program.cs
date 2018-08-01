/*
 * 867. Transpose Matrix
 * https://leetcode.com/problems/transpose-matrix/description/
 */

namespace Transpose
{
    class Program
    {
        /*
         * Given a matrix A, return the transpose of A.
         * The transpose of a matrix is the matrix flipped over it's main diagonal, switching the row and column indices of the matrix.
         *
         * Example 1:
         * Input: [[1,2,3],[4,5,6],[7,8,9]]
         * Output: [[1,4,7],[2,5,8],[3,6,9]]
         *
         * Example 2:
         * Input: [[1,2,3],[4,5,6]]
         * Output: [[1,4],[2,5],[3,6]]
         *
         * Note:
         * 1 <= A.length <= 1000
         * 1 <= A[0].length <= 1000
         *
         */
        static void Main(string[] args)
        {
            var result = Transpose(new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } });
            var result2 = Transpose(new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } });
        }

        public static int[][] Transpose(int[][] A)
        {
            var row = A.GetLength(0);
            var column = A[0].GetLength(0);
            var transpose = new int[column][];

            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    if (transpose[j] == null)
                    {
                        transpose[j] = new int[row];
                    }

                    transpose[j][i] = A[i][j];
                }
            }

            return transpose;
        }
    }
}
