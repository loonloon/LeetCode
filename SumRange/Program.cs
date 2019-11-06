/*
 * 303. Range Sum Query - Immutable
 * https://leetcode.com/problems/range-sum-query-immutable/
 */
namespace SumRange
{
    class Program
    {
        /*
         * Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.
         *
         * Example:
         * Given nums = [-2, 0, 3, -5, 2, -1]
         * sumRange(0, 2) -> 1
         * sumRange(2, 5) -> -1
         * sumRange(0, 5) -> -3
         *
         * Note:
         * You may assume that the array does not change.
         * There are many calls to sumRange function.
         */
        static void Main(string[] args)
        {
            var obj = new NumArray(new []{ -2, 0, 3, -5, 2, -1 });
            obj.SumRange(0, 2);
            obj.SumRange(2, 5);
            obj.SumRange(0, 5);
        }
    }

    public class NumArray
    {
        private readonly int[] _sums;

        public NumArray(int[] nums)
        {
            _sums = new int[nums.Length + 1];

            for (var i = 1; i < nums.Length + 1; i++)
            {
                _sums[i] = _sums[i - 1] + nums[i - 1];

            }
        }

        public int SumRange(int i, int j)
        {
            return _sums[j + 1] - _sums[i];

            //slow way
            //var sum = 0;

            //for (var k = i; k <= j; k++)
            //{
            //    sum += _nums[k];
            //}

            //return sum;
        }
    }
}
