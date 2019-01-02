namespace MaxSubArray
{
    /*
     * 53. Maximum Subarray
     * https://leetcode.com/problems/maximum-subarray/
     */
    class Program
    {
        /*
         * Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
         * Example:
         * Input: [-2,1,-3,4,-1,2,1,-5,4],
         * Output: 6
         * Explanation: [4,-1,2,1] has the largest sum = 6.
         *
         */
        static void Main(string[] args)
        {
            var result = MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            //Kadane's Algorithm
            var max = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                var next = nums[i] + nums[i - 1];

                if (nums[i] < next)
                {
                    nums[i] = next;
                }

                if (max < nums[i])
                {
                    max = nums[i];
                }
            }

            return max;
        }
    }
}
