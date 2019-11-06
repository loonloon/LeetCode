/*
 * 345. Reverse Vowels of a String
 * https://leetcode.com/problems/reverse-vowels-of-a-string/
 */
namespace ReverseVowels
{
    class Program
    {
        /*
         * Write a function that takes a string as input and reverse only the vowels of a string.
         * Example 1:
         * Input: "hello"
         * Output: "holle"
         *
         * Example 2:
         * Input: "leetcode"
         * Output: "leotcede"
         *
         * Note:
         * The vowels does not include the letter "y".
         *
         */
        static void Main(string[] args)
        {
            var result = ReverseVowels("hello");
            var result2 = ReverseVowels("leetcode");
        }

        public static string ReverseVowels(string s)
        {
            var lastPointerIndex = s.Length - 1;
            var sArray = s.ToCharArray();

            for (var i = 0; i < sArray.Length; i++)
            {
                if (!IsVowel(s[i]))
                {
                    continue;
                }

                if (i >= lastPointerIndex)
                {
                    break;
                }

                for (var j = lastPointerIndex; j >= i; j--)
                {
                    if (!IsVowel(sArray[j]))
                    {
                        continue;
                    }

                    var temp = sArray[j];
                    sArray[j] = sArray[i];
                    sArray[i] = temp;
                    lastPointerIndex = j - 1;
                    break;
                }
            }

            return new string(sArray);
        }

        private static bool IsVowel(char c)
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    return true;
                default:
                    return false;
            }
        }
    }
}
