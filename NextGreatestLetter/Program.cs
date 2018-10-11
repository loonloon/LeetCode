/*
 * 744. Find Smallest Letter Greater Than Target
 * https://leetcode.com/problems/find-smallest-letter-greater-than-target/
 */
namespace NextGreatestLetter
{
    class Program
    {
        /*
         * Given a list of sorted characters letters containing only lowercase letters, and given a target letter target,
         * find the smallest element in the list that is larger than the given target.
         *
         * Letters also wrap around. For example, if the target is target = 'z' and letters = ['a', 'b'], the answer is 'a'.
         *
         * Examples:
         * Input:
         * letters = ["c", "f", "j"]
         * target = "a"
         * Output: "c"
         *
         * Input:
         * letters = ["c", "f", "j"]
         * target = "c"
         * Output: "f"
         *
         * Input:
         * letters = ["c", "f", "j"]
         * target = "d"
         * Output: "f"
         *
         * Input:
         * letters = ["c", "f", "j"]
         * target = "g"
         * Output: "j"
         *
         * Input:
         * letters = ["c", "f", "j"]
         * target = "j"
         * Output: "c"
         *
         * Input:
         * letters = ["c", "f", "j"]
         * target = "k"
         * Output: "c"
         *
         * Note:
         * letters has a length in range [2, 10000].
         * letters consists of lowercase letters, and contains at least 2 unique letters.
         * target is a lowercase letter.
         *
         */
        static void Main(string[] args)
        {
            var result = NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'a');
            var result2 = NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'c');
            var result3 = NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'd');
            var result4 = NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'g');
            var result5 = NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'j');
            var result6 = NextGreatestLetter(new[] { 'c', 'f', 'j' }, 'k');
        }

        public static char NextGreatestLetter(char[] letters, char target)
        {
            //can use binary search if the data is in ascending order
            foreach (var letter in letters)
            {
                if (letter > target)
                {
                    return letter;
                }
            }

            return letters[0];
        }
    }
}
