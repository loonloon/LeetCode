using System;
using System.Text;

/*
 * 476. Number Complement
 */
namespace FindComplement
{
    class Program
    {
        /*
         * Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.
         * Note:
         * The given integer is guaranteed to fit within the range of a 32-bit signed integer.
         * You could assume no leading zero bit in the integer’s binary representation.
         *
         * Example 1:
         * Input: 5
         * Output: 2
         * Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
         *
         * Example 2:
         * Input: 1
         * Output: 0
         * Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.
         *
         */
        static void Main(string[] args)
        {
            var result = FindComplement(5);
            var result2 = FindComplement(1);
        }

        public static int FindComplement(int num)
        {
            var binary = Convert.ToString(num, 2);
            var complement = new StringBuilder();

            foreach (var bit in binary)
            {
                complement.Append(bit == '0' ? '1' : '0');
            }

            return Convert.ToInt32(complement.ToString(), 2);
        }
    }
}
