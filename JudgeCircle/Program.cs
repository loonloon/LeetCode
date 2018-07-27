using System.Linq;

/*
 * 657. Judge Route Circle
 * https://leetcode.com/problems/judge-route-circle/description/
 */
namespace JudgeCircle
{
    class Program
    {
        /*
         * Initially, there is a Robot at position (0, 0).
         * Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.
         * The move sequence is represented by a string. And each move is represent by a character.
         *
         * The valid robot moves are R (Right), L (Left), U (Up) and D (down).
         * The output should be true or false representing whether the robot makes a circle.
         *
         * Example 1:
         * Input: "UD"
         * Output: true
         *
         * Example 2:
         * Input: "LL"
         * Output: false
         *
         */
        static void Main(string[] args)
        {
            var result = JudgeCircle("UD");
            var result2 = JudgeCircle("LL");
        }

        public static bool JudgeCircle(string moves)
        {
            return moves.Count(x => x == 'L') == moves.Count(x => x == 'R') && 
                   moves.Count(x => x == 'U') == moves.Count(x => x == 'D');
        }
    }
}
