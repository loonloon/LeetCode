using System.Collections.Generic;
/*
 * 599. Minimum Index Sum of Two Lists
 * https://leetcode.com/problems/minimum-index-sum-of-two-lists/
 */
namespace FindRestaurant
{
    class Program
    {
        /*
         * Suppose Andy and Doris want to choose a restaurant for dinner, and they both have a list of favorite restaurants represented by strings.
         * You need to help them find out their common interest with the least list index sum.
         * If there is a choice tie between answers, output all of them with no order requirement. You could assume there always exists an answer.
         *
         * Example 1:
         * Input:
         * ["Shogun", "Tapioca Express", "Burger King", "KFC"]
         * ["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"]
         * Output: ["Shogun"]
         * Explanation: The only restaurant they both like is "Shogun".
         *
         * Example 2:
         * Input:
         * ["Shogun", "Tapioca Express", "Burger King", "KFC"]
         * ["KFC", "Shogun", "Burger King"]
         * Output: ["Shogun"]
         *
         * Explanation: The restaurant they both like and have the least index sum is "Shogun" with index sum 1 (0+1).
         * Note:
         * The length of both lists will be in the range of [1, 1000].
         * The length of strings in both lists will be in the range of [1, 30].
         * The index is starting from 0 to the list length minus 1.
         * No duplicates in both lists.
         *
         */
        static void Main(string[] args)
        {
            var result = FindRestaurant(new[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" });
            var result2 = FindRestaurant(new[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new[] { "KFC", "Shogun", "Burger King" });
        }

        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            var map = new Dictionary<string, int>();

            for (var i = 0; i < list1.Length; i++)
            {
                map.Add(list1[i], i);
            }

            var minSumIndex = int.MaxValue;
            var result = new List<string>();

            for (var i = 0; i < list2.Length; i++)
            {
                if (!map.ContainsKey(list2[i]))
                {
                    continue;
                }

                var list1Index = map[list2[i]];
                var sumIndex = i + list1Index;

                if (sumIndex > minSumIndex)
                {
                    continue;
                }

                if (sumIndex < minSumIndex)
                {
                    result.Clear();
                    minSumIndex = sumIndex;
                }

                result.Add(list2[i]);
            }

            return result.ToArray();
        }
    }
}
