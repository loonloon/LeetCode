using System;
using System.Linq;

/*
 * 191. Number of 1 Bits
 * https://leetcode.com/problems/number-of-1-bits/description/
 */
namespace HammingWeight
{
    class Program
    {
        /*
         * Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
         *
         * Example 1:
         * Input: 11
         * Output: 3
         * Explanation: Integer 11 has binary representation 00000000000000000000000000001011
         *
         * Example 2:
         * Input: 128
         * Output: 1
         * Explanation: Integer 128 has binary representation 00000000000000000000000010000000
         *
         */
        static void Main(string[] args)
        {
            var result = HammingWeight(11);
            var result2 = HammingWeight(128);
        }

        public static int HammingWeight(uint n)
        {
            var binary = Convert.ToString(n, 2);
            return binary.Count(x => x == '1');
        }
    }
}
