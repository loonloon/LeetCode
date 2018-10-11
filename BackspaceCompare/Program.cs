/*
 * 844. Backspace String Compare
 */
namespace BackspaceCompare
{
    class Program
    {
        /*
         * Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.
         *
         * Example 1:
         * Input: S = "ab#c", T = "ad#c"
         * Output: true
         * Explanation: Both S and T become "ac".
         *
         * Example 2:
         * Input: S = "ab##", T = "c#d#"
         * Output: true
         * Explanation: Both S and T become "".
         *
         * Example 3:
         * Input: S = "a##c", T = "#a#c"
         * Output: true
         * Explanation: Both S and T become "c".
         *
         * Example 4:
         * Input: S = "a#c", T = "b"
         * Output: false
         * Explanation: S becomes "c" while T becomes "b".
         *
         * Note:
         * 1 <= S.length <= 200
         * 1 <= T.length <= 200
         * S and T only contain lowercase letters and '#' characters.
         *
         * Follow up:
         * Can you solve it in O(N) time and O(1) space?
         *
         */
        static void Main(string[] args)
        {
            var result = BackspaceCompare("ab#c", "ad#c");
            var result2 = BackspaceCompare("ab##", "c#d#");
            var result3 = BackspaceCompare("a##c", "#a#c");
            var result4 = BackspaceCompare("a#c", "b");
        }


        public static bool BackspaceCompare(string S, string T)
        {
            var sLength = S.Length - 1;
            var tLength = T.Length - 1;

            while (true)
            {
                for (var back = 0; sLength >= 0 && (back > 0 || S[sLength] == '#'); --sLength)
                {
                    back += S[sLength] == '#' ? 1 : -1;
                }

                for (var back = 0; tLength >= 0 && (back > 0 || T[tLength] == '#'); --tLength)
                {
                    back += T[tLength] == '#' ? 1 : -1;
                }

                if (sLength >= 0 && tLength >= 0 && S[sLength] == T[tLength])
                {
                    sLength--;
                    tLength--;
                }
                else
                {
                    return sLength == -1 && tLength == -1;
                }
            }
        }
    }
}
