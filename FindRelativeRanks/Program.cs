using System;
/*
 * 506. Relative Ranks
 * https://leetcode.com/problems/relative-ranks/
 */
namespace FindRelativeRanks
{
    class Program
    {
        /*
         * Given scores of N athletes, find their relative ranks and the people with the top three highest scores, who will be awarded medals: "Gold Medal", "Silver Medal" and "Bronze Medal".
         * 
         * Example 1:
         * Input: [5, 4, 3, 2, 1]
         * Output: ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"]
         * 
         * Explanation: The first three athletes got the top three highest scores, so they got "Gold Medal", "Silver Medal" and "Bronze Medal". 
         * For the left two athletes, you just need to output their relative ranks according to their scores.
         * 
         * Note:
         * N is a positive integer and won't exceed 10,000.
         * All the scores of athletes are guaranteed to be unique.
         * 
         */
        static void Main(string[] args)
        {
            var result = FindRelativeRanks(new[] { 5, 4, 3, 2, 1 });
        }

        public static string[] FindRelativeRanks(int[] nums)
        {
            var index = new int[nums.Length];
            var result = new string[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                index[i] = i;
            }

            Array.Sort(index, (a, b) => nums[b] - nums[a]);

            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    result[index[i]] = "Gold Medal";
                }
                else if (i == 1)
                {
                    result[index[i]] = "Silver Medal";
                }
                else if (i == 2)
                {
                    result[index[i]] = "Bronze Medal";
                }
                else
                {
                    result[index[i]] = $"{i + 1}";
                }
            }

            return result;
        }
    }
}
