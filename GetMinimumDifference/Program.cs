using System;

/*
 * 530. Minimum Absolute Difference in BST
 * https://leetcode.com/problems/minimum-absolute-difference-in-bst/description/
 */
namespace GetMinimumDifference
{
    class Program
    {
        /*
         * Given a binary search tree with non-negative values, find the minimum absolute difference between values of any two nodes.
         * Example:
         *
         * Input:
         * 1
         *  \
         *   3
         *  /
         * 2
         *
         * Output:
         * 1
         *
         * Explanation:
         * The minimum absolute difference is 1, which is the difference between 2 and 1 (or between 2 and 3).
         *
         * Note: There are at least two nodes in this BST.
         */

        private static int _min = int.MaxValue;
        private static int? _prev;

        static void Main(string[] args)
        {
            var result = GetMinimumDifference(new TreeNode(1)
            {
                Right = new TreeNode(3) { Left = new TreeNode(2) }
            });
        }

        public static int GetMinimumDifference(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            GetMinimumDifference(root.Left);

            if (_prev != null)
            {
                _min = Math.Min(_min, root.Val - (int)_prev);
            }

            _prev = root.Val;
            GetMinimumDifference(root.Right);
            return _min;
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
