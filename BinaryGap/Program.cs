using System;

/*
 * 868. Binary Gap
 * https://leetcode.com/problems/binary-gap/description/
 */

namespace BinaryGap
{
    class Program
    {
        /*
         * Given a positive integer N, find and return the longest distance between two consecutive 1's in the binary representation of N.
         * If there aren't two consecutive 1's, return 0.
         *
         * Example 1:
         * Input: 22
         * Output: 2
         *
         * Explanation:
         * 22 in binary is 0b10110.
         * In the binary representation of 22, there are three ones, and two consecutive pairs of 1's.
         * The first consecutive pair of 1's have distance 2.
         * The second consecutive pair of 1's have distance 1.
         * The answer is the largest of these two distances, which is 2.
         *
         * Example 2:
         * Input: 5
         * Output: 2
         *
         * Explanation:
         * 5 in binary is 0b101.
         *
         * Example 3:
         * Input: 6
         * Output: 1
         *
         * Explanation:
         * 6 in binary is 0b110.
         *
         * Example 4:
         * Input: 8
         * Output: 0
         *
         * Explanation:
         * 8 in binary is 0b1000.
         * There aren't any consecutive pairs of 1's in the binary representation of 8, so we return 0.
         *
         */
        static void Main(string[] args)
        {
            var result = BinaryGap(22);
            var result2 = BinaryGap(5);
            var result3 = BinaryGap(6);
            var result4 = BinaryGap(8);
        }

        public static int BinaryGap(int N)
        {
            var res = 0;

            //Dividing by 2 is equivalent (in this case) to shifting right one place.
            //Dividing by 4 is equivalent to shifting right two places.
            //d = -32, represent as 32 bit boundary and value will not affect the result after increment.
            for (var d = -32; N > 0; N /= 2, d++)
            {
                if (N % 2 == 1)
                {
                    res = Math.Max(res, d);
                    d = 0;
                }
            }

            return res;

            //var binary = Convert.ToString(N, 2);
            //var gapList = new List<int>();
            //var gap = 1;

            //foreach (var bit in binary)
            //{
            //    if (!gapList.Any() && bit == '1')
            //    {
            //        gapList.Add(0);
            //    }
            //    else if (bit == '1')
            //    {
            //        gapList.Add(gap);
            //        gap = 1;
            //    }
            //    else
            //    {
            //        gap++;
            //    }
            //}

            //return gapList.Max();
        }
    }
}
