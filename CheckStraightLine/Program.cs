/*
 * 1232. Check If It Is a Straight Line
 * https://leetcode.com/problems/check-if-it-is-a-straight-line/
 */
namespace CheckStraightLine
{
    class Program
    {
        /*
         * You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point.
         * Check if these points make a straight line in the XY plane.
         *
         * Example 1:
         * Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
         * Output: true
         *
         * Example 2:
         * Input: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
         * Output: false
         *
         * Constraints:
         * 2 <= coordinates.length <= 1000
         * coordinates[i].length == 2
         * -10^4 <= coordinates[i][0], coordinates[i][1] <= 10^4
         * coordinates contains no duplicate point.
         *
         */
        static void Main(string[] args)
        {
            var result = CheckStraightLine(new[]
            {
                new []{ 1, 2 },
                new []{ 2, 3 },
                new []{ 3, 4 },
                new []{ 4, 5 },
                new []{ 5, 6 },
                new []{ 6, 7 }
            });

            var result2 = CheckStraightLine(new[]
            {
                new []{ 1, 1 },
                new []{ 2, 2 },
                new []{ 3, 4 },
                new []{ 4, 5 },
                new []{ 5, 6 },
                new []{ 7, 7 }
            });
        }

        public static bool CheckStraightLine(int[][] coordinates)
        {
            var x0 = coordinates[0][0];
            var y0 = coordinates[0][1];
            var x1 = coordinates[1][0];
            var y1 = coordinates[1][1];

            var dx = x1 - x0;
            var dy = y1 - y0;

            foreach (var co in coordinates)
            {
                var x = co[0];
                var y = co[1];

                if (dx * (y - y1) != dy * (x - x1))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
