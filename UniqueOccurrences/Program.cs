using System.Collections.Generic;

/*
 * 1207. Unique Number of Occurrences
 * https://leetcode.com/problems/unique-number-of-occurrences/
 */
namespace UniqueOccurrences
{
    class Program
    {
        /*
         * Given an array of integers arr, write a function that returns true if and only
         * if the number of occurrences of each value in the array is unique.
         *
         * Example 1:
         * Input: arr = [1,2,2,1,1,3]
         * Output: true
         * Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
         *
         * Example 2:
         * Input: arr = [1,2]
         * Output: false
         *
         * Example 3:
         * Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
         * Output: true
         *
         * Constraints:
         * 1 <= arr.length <= 1000
         * -1000 <= arr[i] <= 1000
         *
         */
        static void Main(string[] args)
        {
            var result = UniqueOccurrences(new[] { 1, 2, 2, 1, 1, 3 });
            var result2 = UniqueOccurrences(new[] { 1, 2 });
            var result3 = UniqueOccurrences(new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 });
        }

        public static bool UniqueOccurrences(int[] arr)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < arr.Length; i++)
            {
                var value = arr[i];

                if (!dictionary.ContainsKey(value))
                {
                    dictionary.Add(value, 1);
                }
                else
                {
                    dictionary[value] += 1;
                }
            }

            return dictionary.Values.Count == new HashSet<int>(dictionary.Values).Count;
        }
    }
}
