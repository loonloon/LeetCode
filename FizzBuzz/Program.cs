using System.Collections.Generic;

/*
 * 412. Fizz Buzz
 * https://leetcode.com/problems/fizz-buzz/description/
 */

namespace FizzBuzz
{
    class Program
    {
        /*
         * Write a program that outputs the string representation of numbers from 1 to n.
         * But for multiples of three it should output "Fizz" instead of the number and for the multiples of five output "Buzz".
         * For numbers which are multiples of both three and five output "FizzBuzz".
         *
         * Example:
         * n = 15,
         * Return:
         * [
         * "1",
         * "2",
         * "Fizz",
         * "4",
         * "Buzz",
         * "Fizz",
         * "7",
         * "8",
         * "Fizz",
         * "Buzz",
         * "11",
         * "Fizz",
         * "13",
         * "14",
         * "FizzBuzz"
         * ]
         *
         */
        static void Main(string[] args)
        {
            var result = FizzBuzz(15);
        }

        public static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();

            for (var i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }
    }
}
