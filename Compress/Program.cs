/*
 * 443. String Compression
 * https://leetcode.com/problems/string-compression/
 */
namespace Compress
{
    class Program
    {
        /*
         * Given an array of characters, compress it in-place.
         * The length after compression must always be smaller than or equal to the original array.
         *
         * Every element of the array should be a character (not int) of length 1.
         * After you are done modifying the input array in-place, return the new length of the array.
         *
         * Follow up:
         * Could you solve it using only O(1) extra space?
         *
         * Example 1:
         * Input:
         * ["a","a","b","b","c","c","c"]
         *
         * Output:
         * Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
         *
         * Explanation:
         * "aa" is replaced by "a2". "bb" is replaced by "b2". "ccc" is replaced by "c3".
         *
         * Example 2:
         * Input:
         * ["a"]
         *
         * Output:
         * Return 1, and the first 1 characters of the input array should be: ["a"]
         *
         * Explanation:
         * Nothing is replaced.
         *
         * Example 3:
         * Input:
         * ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
         *
         * Output:
         * Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
         *
         * Explanation:
         * Since the character "a" does not repeat, it is not compressed. "bbbbbbbbbbbb" is replaced by "b12".
         * Notice each digit has it's own entry in the array.
         *
         */
        static void Main(string[] args)
        {
            var result = Compress(new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
            var result2 = Compress(new[] { 'a' });
            var result3 = Compress(new[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });
        }

        public static int Compress(char[] chars)
        {
            int indexAns = 0, index = 0;

            while (index < chars.Length)
            {
                var currentChar = chars[index];
                var count = 0;

                //keep moving index and calculate how many same character
                while (index < chars.Length && chars[index] == currentChar)
                {
                    index++;
                    count++;
                }

                //rewrite content
                chars[indexAns++] = currentChar;

                //if count is 1, no need write number to chars
                if (count == 1)
                {
                    continue;
                }

                //write number to chars
                foreach (var c in count.ToString().ToCharArray())
                {
                    chars[indexAns++] = c;
                }
            }

            return indexAns;
        }
    }
}
