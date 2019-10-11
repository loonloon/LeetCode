/*
 * 925. Long Pressed Name
 * https://leetcode.com/problems/long-pressed-name/
 */
namespace IsLongPressedName
{
    class Program
    {
        /*
         * Your friend is typing his name into a keyboard.  Sometimes, when typing a character c,
         * the key might get long pressed, and the character will be typed 1 or more times.
         *
         * You examine the typed characters of the keyboard.  Return True if it is possible that it was your friends name,
         * with some characters (possibly none) being long pressed.
         *
         * Example 1:
         * Input: name = "alex", typed = "aaleex"
         * Output: true
         * Explanation: 'a' and 'e' in 'alex' were long pressed.
         *
         * Example 2:
         * Input: name = "saeed", typed = "ssaaedd"
         * Output: false
         * Explanation: 'e' must have been pressed twice, but it wasn't in the typed output.
         *
         * Example 3:
         * Input: name = "leelee", typed = "lleeelee"
         * Output: true
         *
         * Example 4:
         * Input: name = "laiden", typed = "laiden"
         * Output: true
         * Explanation: It's not necessary to long press any character.
         *
         * Note:
         * name.length <= 1000
         * typed.length <= 1000
         * The characters of name and typed are lowercase letters.
         *
         */
        static void Main(string[] args)
        {
            var result = IsLongPressedName("alex", "aaleex");
            var result2 = IsLongPressedName("saeed", "ssaaedd");
            var result3 = IsLongPressedName("leelee", "lleeelee");
            var result4 = IsLongPressedName("laiden", "laiden");
        }

        public static bool IsLongPressedName(string name, string typed)
        {
            var nameIndex = 0;

            for (var i = 0; i < typed.Length; i++)
            {
                if (nameIndex < name.Length && name[nameIndex] == typed[i])
                {
                    nameIndex++;
                }
                else if (i > 0 && typed[i] == typed[i - 1])
                {
                    //do nothing if current character is same as previous character
                }
                else
                {
                    return false;
                }
            }

            return nameIndex == name.Length;
        }
    }
}
