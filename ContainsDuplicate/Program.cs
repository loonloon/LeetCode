using System.Collections.Generic;

/*
 * 217. Contains Duplicate
 * https://leetcode.com/problems/contains-duplicate/description/
 */
namespace ContainsDuplicate
{
    class Program
    {
        /*
         * Given an array of integers, find if the array contains any duplicates.
         * Your function should return true if any value appears at least twice in the array,
         * and it should return false if every element is distinct.
         *
         * Example 1:
         * Input: [1,2,3,1]
         * Output: true
         *
         * Example 2:
         * Input: [1,2,3,4]
         * Output: false
         *
         * Example 3:
         * Input: [1,1,1,3,3,4,3,2,4,2]
         * Output: true
         *
         */
        static void Main(string[] args)
        {
            var result = ContainsDuplicate(new[] { 1, 2, 3, 1 });
            var result2 = ContainsDuplicate(new[] { 1, 2, 3, 4 });
            var result3 = ContainsDuplicate(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dictionary.ContainsKey(num))
                {
                    return true;
                }

                dictionary.Add(num, 1);
            }

            return false;
        }
    }
}
