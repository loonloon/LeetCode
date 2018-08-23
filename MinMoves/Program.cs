using System.Linq;

/*
 * 453. Minimum Moves to Equal Array Elements
 * https://leetcode.com/problems/minimum-moves-to-equal-array-elements/description/
 */
namespace MinMoves
{
    class Program
    {
        /*
         * Given a non-empty integer array of size n, find the minimum number of moves required to make all array elements equal,
         * where a move is incrementing n - 1 elements by 1.
         *
         * Example:
         * Input:
         * [1,2,3]
         *
         * Output:
         * 3
         *
         * Explanation:
         * Only three moves are needed (remember each move increments two elements):
         * [1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]
         *
         */
        static void Main(string[] args)
        {
            var result = MinMoves(new[] { 1, 2, 3 });
        }

        public static int MinMoves(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var min = nums.Min();
            return nums.Sum(num => num - min);
        }
    }
}
