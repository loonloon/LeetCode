/*
 * 1394. Find Lucky Integer in an Array
 * https://leetcode.com/problems/find-lucky-integer-in-an-array/
 */
namespace FindLucky
{
    class Program
    {
        /*
         * Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.
         * Return a lucky integer in the array. If there are multiple lucky integers return the largest of them. If there is no lucky integer return -1.
         * 
         * Example 1:
         * Input: arr = [2,2,3,4]
         * Output: 2
         * Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
         * 
         * Example 2:
         * Input: arr = [1,2,2,3,3,3]
         * Output: 3
         * Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
         * 
         * Example 3:
         * Input: arr = [2,2,2,3,3]
         * Output: -1
         * Explanation: There are no lucky numbers in the array.
         * 
         * Example 4:
         * Input: arr = [5]
         * Output: -1
         * 
         * Example 5:
         * Input: arr = [7,7,7,7,7,7,7]
         * Output: 7
         * 
         * Constraints:
         * 1 <= arr.length <= 500
         * 1 <= arr[i] <= 500
         * 
         */
        static void Main(string[] args)
        {
            var result = FindLucky(new[] { 2, 2, 3, 4 });
            var result2 = FindLucky(new[] { 1, 2, 2, 3, 3, 3 });
            var result3 = FindLucky(new[] { 2, 2, 2, 3, 3 });
            var result4 = FindLucky(new[] { 5 });
            var result5 = FindLucky(new[] { 7, 7, 7, 7, 7, 7, 7 });
        }

        public static int FindLucky(int[] arr)
        {
            var luckyArr = new int[501];

            for (var i = 0; i < arr.Length; i++)
            {
                luckyArr[arr[i]]++;
            }

            for (var i = 500; i > 0; i--)
            {
                if (luckyArr[i] == i)
                {
                    return i;
                }
            }

            return -1;

            //var dictionary = new Dictionary<int, int>();

            //for (var i = 0; i < arr.Length; i++)
            //{
            //    var key = arr[i];

            //    if (dictionary.ContainsKey(key))
            //    {
            //        dictionary[key]++;
            //    }
            //    else
            //    {
            //        dictionary.Add(key, 1);
            //    }
            //}

            //var lucky = -1;

            //foreach (var (key, value) in dictionary)
            //{
            //    if (key == value)
            //    {
            //        lucky = Math.Max(lucky, key);
            //    }
            //}

            //return lucky;
        }
    }
}
