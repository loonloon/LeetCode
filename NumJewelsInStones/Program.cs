using System.Linq;

/*
 * 771. Jewels and Stones
 * https://leetcode.com/problems/jewels-and-stones/description/
 */
namespace NumJewelsInStones
{
    class Program
    {
        /*
         * J = jewels,
         * S = stones you have.  Each character in S is a type of stone you have.
         * You want to know how many of the stones you have are also jewels.
         *
         * The letters in J are guaranteed distinct.
         * All characters in J and S are letters.
         * Letters are case sensitive, so "a" is considered a different type of stone from "A".
         * S and J will consist of letters and have length at most 50.
         *
         * Example 1:
         * Input: J = "aA", S = "aAAbbbb"
         * Output: 3
         *
         * Example 2:
         * Input: J = "z", S = "ZZ"
         * Output: 0
         *
         */
        static void Main(string[] args)
        {
            var result = NumJewelsInStones("aA", "aAAbbbb");
            var result2 = NumJewelsInStones("z", "ZZ");
        }

        public static int NumJewelsInStones(string J, string S)
        {
            if (J.Length == 0 || S.Length == 0)
            {
                return 0;
            }

            var jewels = J.ToCharArray();
            var stones = S.ToCharArray();
            return stones.Count(stone => jewels.Contains(stone));
        }
    }
}
