/*
 * 434. Number of Segments in a String
 * https://leetcode.com/problems/number-of-segments-in-a-string/description/
 */
namespace CountSegments
{
    class Program
    {
        /*
         * Count the number of segments in a string, where a segment is defined to be a contiguous sequence of non-space characters.
         * Please note that the string does not contain any non-printable characters.
         *
         * Example:
         * Input: "Hello, my name is John"
         * Output: 5
         *
         */
        static void Main(string[] args)
        {
            var result = CountSegments("Hello, my name is John");
        }

        public static int CountSegments(string s)
        {
            var wordCount = 0;

            for (var i = 0; i < s.Length; i++)
            {
                //if character is not spacing AND
                //if index is 0, is words OR the spacing is before the character 
                if (s[i] != ' ' && (i == 0 || s[i - 1] == ' '))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}
