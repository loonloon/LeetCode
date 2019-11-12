/*
 * 374. Guess Number Higher or Lower
 * https://leetcode.com/problems/guess-number-higher-or-lower/
 */
namespace GuessNumber
{
    class Program
    {
        /*
         * We are playing the Guess Game. The game is as follows:
         * I pick a number from 1 to n. You have to guess which number I picked.
         * Every time you guess wrong, I'll tell you whether the number is higher or lower.
         *
         * You call a pre-defined API guess(int num) which returns 3 possible results (-1, 1, or 0):
         * -1 : My number is lower
         * 1 : My number is higher
         * 0 : Congrats! You got it!
         *
         * Example :
         * Input: n = 10, pick = 6
         * Output: 6
         *
         */
        static void Main(string[] args)
        {

        }

        public static int GuessNumber(int num)
        {
            int lo = 1, hi = num;

            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;

                if (Guess(mid) > 0)
                {
                    lo = mid + 1;
                }
                else if (Guess(mid) == 0)
                {
                    return mid;
                }
                else
                {
                    hi = mid - 1;
                }
            }

            return lo;
        }

        private static int Guess(in int mid)
        {
            throw new System.NotImplementedException();
        }
    }
}
