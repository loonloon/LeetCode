/*
 * 58. Length of Last Word
 * https://leetcode.com/problems/length-of-last-word
 */
namespace LengthOfLastWord
{
    /*
     * Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
     * If the last word does not exist, return 0.
     *
     * Note: A word is defined as a character sequence consists of non-space characters only.
     * Example:
     * Input: "Hello World"
     * Output: 5
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            var result = LengthOfLastWord("Hello World");
        }

        public static int LengthOfLastWord(string s)
        {
            //Solution 3
            var length = 0;
            var isChar = false;

            if (string.IsNullOrEmpty(s))
            {
                return length;
            }

            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(s[i]))
                {
                    length++;
                    isChar = true;
                }
                else
                {
                    if (isChar)
                    {
                        return length;
                    }
                }
            }

            return length;

            //Solution 2
            //var length = 0;
            //var tail = s.Length - 1;

            //while (tail >= 0 && s[tail] == ' ')
            //{
            //    tail--;
            //}

            //while (tail >= 0 && s[tail] != ' ')
            //{
            //    length++;
            //    tail--;
            //}

            //return length;

            //Solution 1
            //s = s.Trim();
            //var lastIndex = s.LastIndexOf(' ') + 1;
            //return s.Length - lastIndex;
        }
    }
}
