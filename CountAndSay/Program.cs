/*
 * 38. Count and Say
 * https://leetcode.com/problems/count-and-say/
 */

using System.Collections.Generic;
using System.Text;

namespace CountAndSay
{
    /*
     * The count-and-say sequence is the sequence of integers with the first five terms as following:
     * 1.     1
     * 2.     11
     * 3.     21
     * 4.     1211
     * 5.     111221
     * 1 is read off as "one 1" or 11.
     * 11 is read off as "two 1s" or 21.
     * 21 is read off as "one 2, then one 1" or 1211.
     *
     * Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence.
     * Note: Each term of the sequence of integers will be represented as a string.
     *
     * Example 1:
     * Input: 1
     * Output: "1"
     *
     * Example 2:
     * Input: 4
     * Output: "1211"
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            //var result = CountAndSay(1);
            var result2 = CountAndSay(2);
        }

        public static string CountAndSay(int n)
        {
            var current = new StringBuilder("1");

            for (var i = 1; i < n; i++)
            {
                var previous = current;
                current = new StringBuilder();
                var count = 1;
                var say = previous[0];

                for (int j = 1, len = previous.Length; j < len; j++)
                {
                    if (previous[j] != say)
                    {
                        current.Append(count).Append(say);
                        count = 1;
                        say = previous[j];
                    }
                    else
                    {
                        count++;
                    }
                }

                current.Append(count).Append(say);
            }

            return current.ToString();
        }
    }
}
