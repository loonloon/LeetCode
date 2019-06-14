using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 108. Convert Sorted Array to Binary Search Tree
 * https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
 */
namespace SortedArrayToBST
{
    class Program
    {
        /*
         * Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
         * For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of
         * every node never differ by more than 1.
         *
         * Example:
         * Given the sorted array: [-10,-3,0,5,9],
         * One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:
         *
         *     0
         *    / \
         *  -3   9
         *  /   /
         * -10  5
         *
         */
        static void Main(string[] args)
        {
            var result = SortedArrayToBST(new[] { -10, -3, 0, 5, 9 });
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            var head = SortedArrayToBST(nums, 0, nums.Length - 1);
            return head;
        }

        private static TreeNode SortedArrayToBST(IReadOnlyList<int> nums, int low, int high)
        {
            // Done
            if (low > high)
            {
                return null;
            }

            var mid = (low + high) / 2;
            var node = new TreeNode(nums[mid])
            {
                Left = SortedArrayToBST(nums, low, mid - 1),
                Right = SortedArrayToBST(nums, mid + 1, high)
            };
            return node;
        }
    }

    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int x)
        {
            Val = x;
        }
    }
}
