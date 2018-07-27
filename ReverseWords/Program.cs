using System.Linq;

/*
 * 557. Reverse Words in a String III
 * https://leetcode.com/problems/reverse-words-in-a-string-iii/description/
 */
namespace ReverseWords
{
    class Program
    {
        /*
         * Given a string, you need to reverse the order of characters in each word within a sentence
         * while still preserving whitespace and initial word order.
         *
         * Example 1:
         * Input: "Let's take LeetCode contest"
         * Output: "s'teL ekat edoCteeL tsetnoc"
         *
         */
        static void Main(string[] args)
        {
            var result = ReverseWords("Let's take LeetCode contest");
        }

        public static string ReverseWords(string s)
        {
            var splitString = s.Split(' ');
            return string.Join(" ", splitString.Select(x => string.Concat(x.Reverse())));
        }
    }
}
