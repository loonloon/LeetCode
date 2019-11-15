using System.Collections.Generic;
/*
 * 447. Number of Boomerangs
 * https://leetcode.com/problems/number-of-boomerangs/
 */
namespace NumberOfBoomerangs
{
    class Program
    {
        /*
         * Given n points in the plane that are all pairwise distinct, a "boomerang" is a tuple of points (i, j, k)
         * such that the distance between i and j equals the distance between i and k (the order of the tuple matters).
         *
         * Find the number of boomerangs. You may assume that n will be at most 500 and coordinates of points are all in the range [-10000, 10000] (inclusive).
         *
         * Example:
         * Input: [[0,0],[1,0],[2,0]]
         * Output: 2
         * Explanation:
         * The two boomerangs are [[1,0],[0,0],[2,0]] and [[1,0],[2,0],[0,0]]
         *
         */
        static void Main(string[] args)
        {
            var result = NumberOfBoomerangs(new[] { new[] { 0, 0 }, new[] { 1, 0 }, new[] { 2, 0 } });
        }

        public static int NumberOfBoomerangs(int[][] points)
        {
            var res = 0;
            var map = new Dictionary<int, int>();

            for (var i = 0; i < points.Length; i++)
            {
                for (var j = 0; j < points.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    /* https://www.mathsisfun.com/algebra/distance-2-points.html */
                    var d = (points[i][0] - points[j][0]) * (points[i][0] - points[j][0]) + 
                            (points[i][1] - points[j][1]) * (points[i][1] - points[j][1]);

                    if (map.ContainsKey(d))
                    {
                        map[d] += 1;
                    }
                    else
                    {
                        map.Add(d, 0);
                    }
                }

                foreach (var value in map.Values)
                { 
                    /*
                     * Suppose we have three points A1, A2, A3 all have the same distence to point B
                     * Then our output should be
                     * [B, A1, A2]
                     * [B, A1, A3]
                     * [B, A2, A1]
                     * [B, A2, A3]
                     * [B, A3, A1]
                     * [B, A3, A2]
                     * Do you find out the math in here? we need to permutate 3 points into 2 positions, and that is 3*(3-1) = 6.
                     */
                    res += value * (value + 1);
                }

                map.Clear();
            }

            return res;
        }
    }
}
