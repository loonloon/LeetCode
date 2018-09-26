using System.Linq;
using System.Text;
/*
 * 67. Add Binary
 * https://leetcode.com/problems/add-binary
 */
namespace AddBinary
{
    class Program
    {
        /*
         * Given two binary strings, return their sum (also a binary string).
         * The input strings are both non-empty and contains only characters 1 or 0.
         *
         * Example 1:
         * Input: a = "11", b = "1"
         * Output: "100"
         *
         * Example 2:
         * Input: a = "1010", b = "1011"
         * Output: "10101"
         *
         */
        static void Main(string[] args)
        {
            var result = AddBinary("11", "1");
        }

        public static string AddBinary(string a, string b)
        {
            var stringBuilder = new StringBuilder();
            var aIndex = a.Length - 1;
            var bIndex = b.Length - 1;
            var carry = 0;

            //from back to front, math
            while (aIndex >= 0 || bIndex >= 0)
            {
                var sum = carry;

                if (aIndex >= 0)
                {
                    sum += a[aIndex--] - '0';
                }

                if (bIndex >= 0)
                {
                    sum += b[bIndex--] - '0';
                }

                stringBuilder.Append(sum % 2);
                carry = sum / 2;
            }

            if (carry != 0)
            {
                stringBuilder.Append(carry);
            }

            return new string(stringBuilder.ToString().Reverse().ToArray());
        }
    }
}
