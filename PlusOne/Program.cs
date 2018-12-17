/*
 * 66. Plus One
 * https://leetcode.com/problems/plus-one/
 */
namespace PlusOne
{
    class Program
    {
        /*
         * Given a non-empty array of digits representing a non-negative integer, plus one to the integer.
         *
         * The digits are stored such that the most significant digit is at the head of the list,
         * and each element in the array contain a single digit.
         *
         * You may assume the integer does not contain any leading zero, except the number 0 itself.
         *
         * Example 1:
         * Input: [1,2,3]
         * Output: [1,2,4]
         * Explanation: The array represents the integer 123.
         *
         * Example 2:
         * Input: [4,3,2,1]
         * Output: [4,3,2,2]
         * Explanation: The array represents the integer 4321.
         *
         */
        static void Main(string[] args)
        {
            var result = PlusOne(new[] { 1, 2, 3 });
            var result2 = PlusOne(new[] { 9, 9 });
        }

        public static int[] PlusOne(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0;)
            {
                //if last digit is 9, set digit to 0
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    i--;
                }
                else
                {
                    //plus 1 to last digit, then stop
                    digits[i] += 1;
                    break;
                }
            }

            //if digit is 0, need to resize the array
            if (digits[0] == 0)
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
            }

            return digits;
        }
    }
}
