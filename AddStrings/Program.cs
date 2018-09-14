using System.Text;
/*
 * 415. Add Strings
 * https://leetcode.com/problems/add-strings/description/
 */
namespace AddStrings
{
    class Program
    {
        /*
         * Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.
         *
         * Note:
         * The length of both num1 and num2 is < 5100.
         * Both num1 and num2 contains only digits 0-9.
         * Both num1 and num2 does not contain any leading zero.
         * You must not use any built-in BigInteger library or convert the inputs to integer directly.
         *
         */
        static void Main(string[] args)
        {
            var result = AddStrings("11", "29");
        }

        public static string AddStrings(string num1, string num2)
        {
            var num1Index = num1.Length - 1;
            var num2Index = num2.Length - 1;
            var carry = 0;

            var num1Array = num1.ToCharArray();
            var num2Array = num2.ToCharArray();
            var sb = new StringBuilder();

            while (num1Index >= 0 || num2Index >= 0 || carry == 1)
            {
                var num1Digit = num1Index >= 0 ? (num1Array[num1Index--] - '0') : 0;
                var num2Digit = num2Index >= 0 ? (num2Array[num2Index--] - '0') : 0;
                var sum = num1Digit + num2Digit + carry;
                sb.Insert(0, sum % 10);

                //if sum is 10, 进位
                carry = sum / 10;
            }

            return sb.ToString();
        }
    }
}
