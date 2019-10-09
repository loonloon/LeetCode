/*
 * 1071. Greatest Common Divisor of Strings
 * https://leetcode.com/problems/greatest-common-divisor-of-strings/
 */
namespace GcdOfStrings
{
    class Program
    {
        /*
         * For strings S and T, we say "T divides S" if and only if S = T + ... + T  (T concatenated with itself 1 or more times)
         * Return the largest string X such that X divides str1 and X divides str2.
         *
         * Example 1:
         * Input: str1 = "ABCABC", str2 = "ABC"
         * Output: "ABC"
         *
         * Example 2:
         * Input: str1 = "ABABAB", str2 = "ABAB"
         * Output: "AB"
         *
         * Example 3:
         * Input: str1 = "LEET", str2 = "CODE"
         * Output: ""
         *
         * Note:
         * 1 <= str1.length <= 1000
         * 1 <= str2.length <= 1000
         * str1[i] and str2[i] are English uppercase letters.
         *
         */
        static void Main(string[] args)
        {
            var result = GcdOfStrings("ABCABC", "ABC");
            var result2 = GcdOfStrings("ABABAB", "ABAB");
            var result3 = GcdOfStrings("LEET", "CODE");
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            var n1 = str1.Length;
            var n2 = str2.Length;
            var gcd = Gcd(n1, n2);

            //check with str2 first
            for (var i = 0; i < n2; i++)
            {
                if (str2[i] != str1[i % gcd])
                {
                    return string.Empty;
                }
            }

            //check with str1
            for (var i = gcd + 1; i < n1; i++)
            {
                if (str1[i] != str1[i % gcd])
                {
                    return string.Empty;
                }
            }

            return str1.Substring(0, gcd);
        }

        private static int Gcd(int a, int b)
        {
            while (true)
            {
                if (b == 0)
                {
                    return a;
                }

                var a1 = a;
                a = b;
                b = a1 % b;
            }
        }
    }
}
