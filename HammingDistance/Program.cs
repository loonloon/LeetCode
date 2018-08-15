/*
 * 461. Hamming Distance
 * https://leetcode.com/problems/hamming-distance/description/
 */
namespace HammingDistance
{
    class Program
    {
        /*
         * The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
         * Given two integers x and y, calculate the Hamming distance.
         *
         * Example:
         * Input: x = 1, y = 4
         * Output: 2
         *
         * Explanation:
         * 1   (0 0 0 1)
         * 4   (0 1 0 0)
         *        ↑   ↑
         *
         * The above arrows point to positions where the corresponding bits are different.
         *
         * Note:
         * 0 ≤ x, y < 231.
         *
         */
        static void Main(string[] args)
        {
            var result = HammingDistance(1, 4);
        }

        public static int HammingDistance(int x, int y)
        {
            var z = x ^ y;
            var count = 0;

            while (z != 0)
            {
                count++;
                z &= (z - 1);
            }

            return count;
        }
    }
}
