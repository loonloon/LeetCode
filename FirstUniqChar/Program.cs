/*
 * 387. First Unique Character in a String
 * https://leetcode.com/problems/first-unique-character-in-a-string/description/
 */
namespace FirstUniqChar
{
    class Program
    {
        /*
         * Given a string, find the first non-repeating character in it and return it's index.
         * If it doesn't exist, return -1.
         *
         * Examples:
         * s = "leetcode"
         * return 0.
         *
         * s = "loveleetcode",
         * return 2.
         *
         */
        static void Main(string[] args)
        {
            var result = FirstUniqChar("leetcode");
        }

        public static int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            var chars = new char[256];

            foreach (var c in s)
            {
                chars[c]++;
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (chars[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
