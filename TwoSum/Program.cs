/*
 * 167. Two Sum II - Input array is sorted
 * https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
 */
namespace TwoSum
{
    class Program
    {
        /*
         * Given an array of integers that is already sorted in ascending order,
         * find two numbers such that they add up to a specific target number.
         *
         * The function twoSum should return indices of the two numbers such that they add up to the target,
         * where index1 must be less than index2.
         *
         * Note:
         * Your returned answers (both index1 and index2) are not zero-based.
         * You may assume that each input would have exactly one solution and you may not use the same element twice.
         *
         * Example:
         * Input: numbers = [2,7,11,15], target = 9
         * Output: [1,2]
         * Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
         *
         */
        static void Main(string[] args)
        {
            var result = TwoSum(new[] { 2, 7, 11, 15 }, 9);
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            var indice = new int[2];

            if (numbers == null || numbers.Length < 2)
            {
                return indice;
            }

            var left = 0;
            var right = numbers.Length - 1;

            while (left < right)
            {
                var total = numbers[left] + numbers[right];

                if (total == target)
                {
                    indice[0] = left + 1;
                    indice[1] = right + 1;
                    break;
                }

                if (total > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return indice;
        }
    }
}
