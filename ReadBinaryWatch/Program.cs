﻿using System.Collections.Generic;
/*
 * 401. Binary Watch
 * https://leetcode.com/problems/binary-watch/
 */
namespace ReadBinaryWatch
{
    class Program
    {
        /*
         * A binary watch has 4 LEDs on the top which represent the hours (0-11), and the 6 LEDs on the bottom represent the minutes (0-59).
         * Each LED represents a zero or one, with the least significant bit on the right.
         *
         * For example, the above binary watch reads "3:25".
         * Given a non-negative integer n which represents the number of LEDs that are currently on, return all possible times the watch could represent.
         *
         * Example:
         * Input: n = 1
         * Return: ["1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16", "0:32"]
         *
         * Note:
         * The order of output does not matter.
         * The hour must not contain a leading zero, for example "01:00" is not valid, it should be "1:00".
         * The minute must be consist of two digits and may contain a leading zero, for example "10:2" is not valid, it should be "10:02".
         *
         */
        static void Main(string[] args)
        {
            var result = ReadBinaryWatch(1);
        }

        public static IList<string> ReadBinaryWatch(int num)
        {
            var results = new List<string>();

            for (var i = 0; i <= 11; i++)
            {
                for (var j = 0; j <= 59; j++)
                {
                    if ((Bit(i) + Bit(j)) != num)
                    {
                        continue;
                    }

                    var s = j > 9 ? $"{i}:{j}" : $"{i}:0{j}";
                    results.Add(s);
                }
            }

            return results;
        }

        public static int Bit(int n)
        {
            var count = 0;

            while (n != 0)
            {
                if (n % 2 != 0)
                {
                    count++;
                }

                n /= 2;
            }

            return count;
        }
    }
}
