using System.Text;

/*
 * 709. To Lower Case
 * https://leetcode.com/problems/to-lower-case/description/
 */
namespace ToLowerCase
{
    class Program
    {
        /*
         * Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.
         *
         * Example 1:
         * Input: "Hello"
         * Output: "hello"
         *
         * Example 2:
         * Input: "here"
         * Output: "here"
         *
         * Example 3:
         * Input: "LOVELY"
         * Output: "lovely"
         *
         */
        static void Main(string[] args)
        {
            //https://www.asciitable.com/
            var result = ToLowerCase("Hello");
            var result2 = ToLowerCase("here");
            var result3 = ToLowerCase("LOVELY");
        }

        public static string ToLowerCase(string str)
        {
            var stringBuilder = new StringBuilder();

            foreach (var t in str)
            {
                var ascii = (int)t;

                if (ascii >= 65 && ascii <= 90)
                {
                    ascii += 32;
                }

                stringBuilder.Append((char)ascii);
            }

            return stringBuilder.ToString();
        }
    }
}
