using System.Text;
/*
 * 168. Excel Sheet Column Title
 * https://leetcode.com/problems/excel-sheet-column-title/
 */
namespace ConvertToTitle
{
    class Program
    {
        /*
         * Given a positive integer, return its corresponding column title as appear in an Excel sheet.
         * For example:
         * 1 -> A
         * 2 -> B
         * 3 -> C
         * ...
         * 26 -> Z
         * 27 -> AA
         * 28 -> AB
         * ...
         *
         * Example 1:
         * Input: 1
         * Output: "A"
         *
         * Example 2:
         * Input: 28
         * Output: "AB"
         *
         * Example 3:
         * Input: 701
         * Output: "ZY"
         *
         */
        static void Main(string[] args)
        {
            var result = ConvertToTitle(1);
            var result2 = ConvertToTitle(28);
            var result3 = ConvertToTitle(701);
        }

        public static string ConvertToTitle(int n)
        {
            var sb = new StringBuilder();

            while (n > 0)
            {
                //from back to front
                var number = (n - 1) % 26;
                n = (n - 1) / 26;

                var ch = (char) (number + 'A');
                sb.Insert(0, ch);
            }

            return sb.ToString();
        }
    }
}
