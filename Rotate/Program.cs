using System.Linq;
/*
 * 189. Rotate Array
 * https://leetcode.com/problems/rotate-array/
 */
namespace Rotate
{
    class Program
    {
        /*
         * Given an array, rotate the array to the right by k steps, where k is non-negative.
         * Example 1:
         * Input: [1,2,3,4,5,6,7] and k = 3
         * Output: [5,6,7,1,2,3,4]
         * Explanation:
         * rotate 1 steps to the right: [7,1,2,3,4,5,6]
         * rotate 2 steps to the right: [6,7,1,2,3,4,5]
         * rotate 3 steps to the right: [5,6,7,1,2,3,4]
         *
         * Example 2:
         * Input: [-1,-100,3,99] and k = 2
         * Output: [3,99,-1,-100]
         * Explanation:
         * rotate 1 steps to the right: [99,-1,-100,3]
         * rotate 2 steps to the right: [3,99,-1,-100]
         *
         * Note:
         * Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
         * Could you do it in-place with O(1) extra space?
         *
         */
        static void Main(string[] args)
        { 
            Rotate(new[] {1, 2, 3, 4, 5, 6, 7}, 3);
            Rotate(new[] { -1, -100, 3, 99 }, 2);
        }

        public static void Rotate(int[] nums, int k)
        {
            var length = nums.Length;
            //k inside, length out side
            var p = k % length;
            var temp = nums.ToArray();

            for (var i = 0; i < length; i++)
            {
                if (p == length)
                {
                    p = 0;
                }

                nums[p] = temp[i];
                p++;
            }

            //for (var i = 0; i < k; i++)
            //{
            //    var lastValue = nums[nums.Length - 1];

            //    for (var j = nums.Length - 1; j >= 1; j--)
            //    {
            //        nums[j] = nums[j - 1];
            //    }

            //    nums[0] = lastValue;
            //}
        }
    }
}
