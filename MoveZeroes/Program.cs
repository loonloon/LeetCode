/*
 * 283. Move Zeroes
 * https://leetcode.com/problems/move-zeroes/description/
 */

namespace MoveZeroes
{
    class Program
    {
        /*
         * Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
         *
         * Example:
         * Input: [0,1,0,3,12]
         * Output: [1,3,12,0,0]
         *
         * Note:
         * You must do this in-place without making a copy of the array.
         * Minimize the total number of operations.
         */
        static void Main(string[] args)
        {
            MoveZeroes(new[] { 0, 1, 0, 3, 12 });
        }

        public static void MoveZeroes(int[] nums)
        {
            //Solution 3
            var nonZeroCount = 0;

            // move all the nonzero elements advance
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroCount++] = nums[i];
                }
            }

            for (; nonZeroCount < nums.Length; nonZeroCount++)
            {
                nums[nonZeroCount] = 0;
            }

            //Solution 2
            //var count = 0;

            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == 0)
            //    {
            //        count++;
            //    }
            //    else if (count != 0)
            //    {
            //        nums[i - count] = nums[i];
            //        nums[i] = 0;
            //    }
            //}

            //Solution 1
            //for (int lastestZeroIndex = 0, i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] != 0)
            //    {
            //        nums[lastestZeroIndex] = nums[i];
            //        nums[i] = 0;
            //        lastestZeroIndex++;
            //    }
            //}
        }
    }
}
