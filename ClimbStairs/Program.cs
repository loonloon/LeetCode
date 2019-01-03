/*
 * 70. Climbing Stairs
 * https://leetcode.com/problems/climbing-stairs/
 */
namespace ClimbStairs
{
    class Program
    {
        /*
         * You are climbing a stair case. It takes n steps to reach to the top.
         * Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
         * Note: Given n will be a positive integer.
         *
         * Example 1:
         * Input: 2
         * Output: 2
         * Explanation: There are two ways to climb to the top.
         * 1. 1 step + 1 step
         * 2. 2 steps
         *
         * Example 2:
         * Input: 3
         * Output: 3
         * Explanation: There are three ways to climb to the top.
         * 1. 1 step + 1 step + 1 step
         * 2. 1 step + 2 steps
         * 3. 2 steps + 1 step
         *
         */
        static void Main(string[] args)
        {
            var result = ClimbStairs(2);
            var result2 = ClimbStairs(3);
        }

        public static int ClimbStairs(int n)
        {
            // base cases
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            var oneStepBefore = 2;
            var twoStepsBefore = 1;
            var allWays = 0;

            for (var i = 2; i < n; i++)
            {
                //e.g.
                //n = 5
                //1. allWays =  3, oneStepBefore = 3, twoStepsBefore = 2
                //2. allWays =  5, oneStepBefore = 5, twoStepsBefore = 3
                //3. allWays =  8, oneStepBefore = 8, twoStepsBefore = 5
                allWays = oneStepBefore + twoStepsBefore;
                twoStepsBefore = oneStepBefore;
                oneStepBefore = allWays;
            }

            return allWays;
        }
    }
}
