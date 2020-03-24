/*
 * 680. Valid Palindrome II
 * https://leetcode.com/problems/valid-palindrome-ii/
 */
namespace ValidPalindrome
{
    class Program
    {
        /*
         * Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.
         *
         * Example 1:
         * Input: "aba"
         * Output: True
         *
         * Example 2:
         * Input: "abca"
         * Output: True
         *
         * Explanation: You could delete the character 'c'.
         * Note:
         * The string will only contain lowercase characters a-z. The maximum length of the string is 50000.
         *
         */
        static void Main(string[] args)
        {
            var result = ValidPalindrome("aba");
            var result2 = ValidPalindrome("abca");
        }

        public static bool ValidPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] == s[j])
                {
                    continue;
                }

                var leftIndex1 = i;
                var rightIndex1 = j - 1;
                var leftIndex2 = i + 1;
                var rightIndex2 = j;

                //removing left
                while (leftIndex1 < rightIndex1 && s[leftIndex1] == s[rightIndex1])
                {
                    leftIndex1++;
                    rightIndex1--;
                }

                //removing right
                while (leftIndex2 < rightIndex2 && s[leftIndex2] == s[rightIndex2])
                {
                    leftIndex2++;
                    rightIndex2--;
                }

                return leftIndex1 >= rightIndex1 || leftIndex2 >= rightIndex2;
            }

            return true;
        }
    }
}
