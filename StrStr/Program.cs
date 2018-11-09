/*
 * 28. Implement strStr()
 * https://leetcode.com/problems/implement-strstr/
 */
namespace StrStr
{
    class Program
    {
        /*
         * Implement strStr().
         * Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
         *
         * Example 1:
         * Input: haystack = "hello", needle = "ll"
         * Output: 2
         *
         * Example 2:
         * Input: haystack = "aaaaa", needle = "bba"
         * Output: -1
         *
         */
        static void Main(string[] args)
        {
            var result = StrStr("hello", "ll");
            var result2 = StrStr("aaaaa", "bba");
        }

        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            for (var i = 0; ; i++)
            {
                for (var j = 0; ; j++)
                {
                    if (j == needle.Length)
                    {
                        return i;
                    }

                    if (i + j == haystack.Length)
                    {
                        return -1;
                    }

                    if (needle[j] != haystack[i + j])
                    {
                        break;
                    }
                }
            }
        }
    }
}
