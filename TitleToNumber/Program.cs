/*
 * 171. Excel Sheet Column Number
 * https://leetcode.com/problems/excel-sheet-column-number/description/
 */
namespace TitleToNumber
{
    class Program
    {
        /*
         * Given a column title as appear in an Excel sheet, return its corresponding column number.
         *
         * For example:
         * A -> 1
         * B -> 2
         * C -> 3
         * ...
         * Z -> 26
         * AA -> 27
         * AB -> 28
         * ...
         *
         * Example 1:
         * Input: "A"
         * Output: 1
         *
         * Example 2:
         * Input: "AB"
         * Output: 28
         *
         * Example 3:
         * Input: "ZY"
         * Output: 701
         *
         */
        static void Main(string[] args)
        {
            var result = TitleToNumber("ZY");
        }

        public static int TitleToNumber(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            var sum = 0;

            foreach (var c in s.ToUpper())
            {
                sum *= 26;
                sum += c - 'A' + 1;
            }

            return sum;
        }
    }
}
