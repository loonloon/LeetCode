using System.Text;
/*
 * 686. Repeated String Match
 * https://leetcode.com/problems/repeated-string-match/
 */
namespace RepeatedStringMatch
{
    class Program
    {
        /*
         * Given two strings A and B, find the minimum number of times A has to be repeated such that B is a substring of it.
         * If no such solution, return -1.
         *
         * For example, with A = "abcd" and B = "cdabcdab".
         * Return 3, because by repeating A three times (“abcdabcdabcd”),
         * B is a substring of it; and B is not a substring of A repeated two times ("abcdabcd").
         *
         * Note:
         * The length of A and B will be between 1 and 10000.
         *
         */
        static void Main(string[] args)
        {
            var result = RepeatedStringMatch("abcd", "cdabcdab");
        }

        public static int RepeatedStringMatch(string A, string B)
        {
            var count = 0;
            var stringBuilder = new StringBuilder();

            while (stringBuilder.Length < B.Length)
            {
                stringBuilder.Append(A);
                count++;
            }

            if (stringBuilder.ToString().Contains(B))
            {
                return count;
            }

            //rotation case
            if (stringBuilder.Append(A).ToString().Contains(B))
            {
                return ++count;
            }

            return -1;
        }
    }
}
