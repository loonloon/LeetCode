using System.Linq;
/*
 * 204. Count Primes
 * https://leetcode.com/problems/count-primes/
 */
namespace CountPrimes
{
    class Program
    {
        /*
         * Count the number of prime numbers less than a non-negative number, n.
         *
         * Example:
         * Input: 10
         * Output: 4
         * Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
         */
        static void Main(string[] args)
        {
            var result = CountPrimes(10);
        }

        public static int CountPrimes(int n)
        {
            var primes = new bool[n];

            if (n == 0 || n == 1)
            {
                return 0;
            }

            for (var i = 2; i < n; i++)
            {
                primes[i] = true;
            }

            for (var i = 2; i < n; i++)
            {
                if (!primes[i])
                {
                    continue;
                }

                for (var j = 2; j * i < n; j++)
                {
                    primes[i * j] = false;
                }
            }

            return primes.Count(x => x);
        }
    }
}
