using System.Collections.Generic;
using System.Linq;

/*
 * 169. Majority Element
 * https://leetcode.com/problems/majority-element/description/
 */
namespace MajorityElement
{
    class Program
    {
        /*
         * Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
         * You may assume that the array is non-empty and the majority element always exist in the array.
         *
         * Example 1:
         * Input: [3,2,3]
         * Output: 3
         *
         * Example 2:
         * Input: [2,2,1,1,1,2,2]
         * Output: 2
         *
         */
        static void Main(string[] args)
        {
            var result = MajorityElement(new[] { 3, 2, 3 });
            var result2 = MajorityElement(new[] { 2, 2, 1, 1, 1, 2, 2 });
        }

        public static int MajorityElement(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num] += 1;
                }
                else
                {
                    dictionary.Add(num, 1);
                }
            }

            return dictionary.OrderByDescending(x => x.Value).First().Key;
        }
    }
}
