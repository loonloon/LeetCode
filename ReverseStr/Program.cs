using System;
/*
 * 541. Reverse String II
 * https://leetcode.com/problems/reverse-string-ii/description/
 */
namespace ReverseStr
{
    class Program
    {
        /*
         * Given a string and an integer k, you need to reverse the first k characters for every 2k characters counting from the start of the string.
         * If there are less than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters,
         * then reverse the first k characters and left the other as original.
         *
         * Example:
         * Input: s = "abcdefg", k = 2
         * Output: "bacdfeg"
         *
         * Restrictions:
         * The string consists of lower English letters only.
         * Length of the given string and k will in the range [1, 10000]
         *
         */
        static void Main(string[] args)
        {
            var result = ReverseStr("abcdefg", 2);
        }

        public static string ReverseStr(string s, int k)
        {
            var array = s.ToCharArray();
            var arrLength = array.Length;
            var index = 0;

            while (index < arrLength)
            {
                var minIndex = Math.Min(index + k - 1, arrLength - 1);
                Swap(array, index, minIndex);
                index += 2 * k;
            }

            return new string(array);
        }

        private static void Swap(char[] array, int currentIndex, int minIndex)
        {
            while (currentIndex < minIndex)
            {
                var temp = array[currentIndex];
                array[currentIndex++] = array[minIndex];
                array[minIndex--] = temp;
            }
        }
    }
}
