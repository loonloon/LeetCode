/*
 * 1089. Duplicate Zeros
 * https://leetcode.com/problems/duplicate-zeros/
 */

namespace DuplicateZeros
{
    class Program
    {
        /*
         * Given a fixed length array arr of integers, duplicate each occurrence of zero, shifting the remaining elements to the right.
         * Note that elements beyond the length of the original array are not written.
         * Do the above modifications to the input array in place, do not return anything from your function.
         *
         * Example 1:
         * Input: [1,0,2,3,0,4,5,0]
         * Output: null
         * Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
         *
         * Example 2:
         * Input: [1,2,3]
         * Output: null
         * Explanation: After calling your function, the input array is modified to: [1,2,3]
         *
         * Note:
         * 1 <= arr.length <= 10000
         * 0 <= arr[i] <= 9
         *
         */
        static void Main(string[] args)
        {
            DuplicateZeros(new[] { 1, 0, 2, 3, 0, 4, 5, 0 });
            DuplicateZeros(new[] { 1, 2, 3 });
        }

        public static void DuplicateZeros(int[] arr)
        {
            var countZero = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    countZero++;
                }
            }

            var len = arr.Length + countZero;

            //We just need O(1) space if we scan from back
            //i point to the original array, j point to the new location
            for (int i = arr.Length - 1, j = len - 1; i < j; i--, j--)
            {
                if (arr[i] != 0)
                {
                    if (j < arr.Length)
                    {
                        arr[j] = arr[i];
                    }
                }
                else
                {
                    if (j < arr.Length)
                    {
                        arr[j] = arr[i];
                    }

                    j--;

                    if (j < arr.Length)
                    {
                        //copy twice when hit '0'
                        arr[j] = arr[i]; 
                    }
                }
            }

            //var startIndex = 0;

            //while (startIndex < arr.Length)
            //{
            //    if (arr[startIndex] != 0)
            //    {
            //        startIndex++;
            //        continue;
            //    }

            //    //if found zero, get next position index
            //    var nextIndex = startIndex + 1;

            //    //shift content, start from tail 
            //    for (var i = arr.Length - 1; i > nextIndex; i--)
            //    {
            //        arr[i] = arr[i - 1];
            //    }

            //    if (nextIndex < arr.Length)
            //    {
            //        arr[nextIndex] = 0;
            //        startIndex += 2;
            //    }
            //    else
            //    {
            //        startIndex++;
            //    }
            //}
        }
    }
}
