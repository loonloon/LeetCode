/*
 * 35. Search Insert Position
 * https://leetcode.com/problems/search-insert-position/description/
 */
namespace SearchInsert
{
    class Program
    {
        /*
         * Given a sorted array and a target value, return the index if the target is found.
         * If not, return the index where it would be if it were inserted in order.
         *
         * You may assume no duplicates in the array.
         *
         * Example 1:
         * Input: [1,3,5,6], 5
         * Output: 2
         *
         * Example 2:
         * Input: [1,3,5,6], 2
         * Output: 1
         *
         * Example 3:
         * Input: [1,3,5,6], 7
         * Output: 4
         *
         * Example 4:
         * Input: [1,3,5,6], 0
         * Output: 0
         *
         */
        static void Main(string[] args)
        {
            var result = SearchInsert(new[] { 1, 3, 5, 6 }, 5);
            var result2 = SearchInsert(new[] { 1, 3, 5, 6 }, 2);
            var result3 = SearchInsert(new[] { 1, 3, 5, 6 }, 7);
            var result4 = SearchInsert(new[] { 1, 3, 5, 6 }, 0);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 1)
            {
                return target > nums[0] ? 1 : 0;
            }

            //can use binary search
            for (var i = 0; i < nums.Length; i++)
            {
                if (target > nums[i])
                {
                    continue;
                }

                return i;
            }

            return nums.Length;
        }
    }
}
