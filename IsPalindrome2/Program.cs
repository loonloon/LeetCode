using System;
/*
 * 125. Valid Palindrome
 * https://leetcode.com/problems/valid-palindrome/
 */
namespace IsPalindrome2
{
    class Program
    {
        /*
         * Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
         * Note: For the purpose of this problem, we define empty string as valid palindrome.
         *
         * Example 1:
         * Input: "A man, a plan, a canal: Panama"
         * Output: true
         *
         * Example 2:
         * Input: "race a car"
         * Output: false
         *
         */
        static void Main(string[] args)
        {
            var result = IsPalindrome("A man, a plan, a canal: Panama");
            var result2 = IsPalindrome("race a car");
        }

        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int headIndex = 0, tailIndex = s.Length - 1;

            while (headIndex <= tailIndex)
            {
                var headCharacter = s[headIndex];
                var tailCharacter = s[tailIndex];

                if (!char.IsLetterOrDigit(headCharacter))
                {
                    // move from front to back
                    headIndex++;
                }
                else if (!char.IsLetterOrDigit(tailCharacter))
                {
                    // move from back to front
                    tailIndex--;
                }
                else
                {
                    if (!headCharacter.ToString().Equals(tailCharacter.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }

                    headIndex++;
                    tailIndex--;
                }
            }

            return true;
        }
    }
}
