using System;
/*
 * 633. Sum of Square Numbers
 * https://leetcode.com/problems/sum-of-square-numbers/
 */
namespace JudgeSquareSum
{
    class Program
    {
        /*
         * Given a non-negative integer c, your task is to decide whether there're two integers a and b such that a2 + b2 = c.
         * Example 1:
         * Input: 5
         * Output: True
         * Explanation: 1 * 1 + 2 * 2 = 5
         *
         * Example 2:
         * Input: 3
         * Output: False
         *
         */
        static void Main(string[] args)
        {
            var result = JudgeSquareSum(5);
            var result2 = JudgeSquareSum(3);
        }

        public static bool JudgeSquareSum(int c)
        {
            if (c < 0)
            {
                return false;
            }

            var left = 0;
            var right = (int)Math.Sqrt(c);

            while (left <= right)
            {
                var current = left * left + right * right;

                if (current < c)
                {
                    left++;
                }
                else if (current > c)
                {
                    right--;
                }
                else
                {
                    return true;
                }
            }

            return false;

            //var set = new HashSet<int>();

            //for (var i = 0; i <= Math.Sqrt(c); i++)
            //{
            //    set.Add(i * i);

            //    if (set.Contains(c - i * i))
            //    {
            //        return true;
            //    }
            //}

            //return false;
        }
    }
}
