/*
 * 268. Missing Number
 * https://leetcode.com/problems/missing-number/
 */
namespace MissingNumber
{
    class Program
    {
        /*
         * Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
         *
         * Example 1:
         * Input: [3,0,1]
         * Output: 2
         *
         * Example 2:
         * Input: [9,6,4,2,3,5,7,0,1]
         * Output: 8
         *
         * Note:
         * Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity?
         *
         */
        static void Main(string[] args)
        {
            var result = MissingNumber(new[] {3, 0, 1});
            var result2 = MissingNumber(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
        }

        public static int MissingNumber(int[] nums)
        {
            var sum = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            var expectedSum = (nums.Length) * (nums.Length + 1) / 2;
            return expectedSum - sum;

            //Array.Sort(nums);

            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] != i)
            //    {
            //        return i;
            //    }
            //}

            //return nums.Length;
        }
    }
}
