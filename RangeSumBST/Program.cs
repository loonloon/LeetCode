using System.Collections.Generic;

/*
 * 938. Range Sum of BST
 * https://leetcode.com/problems/range-sum-of-bst/
 */
namespace RangeSumBST
{
    class Program
    {
        /*
         * Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).
         *
         * The binary search tree is guaranteed to have unique values.
         *
         * Example 1:
         * Input: root = [10,5,15,3,7,null,18], L = 7, R = 15
         * Output: 32
         *
         *        10
         *       /  \
         *      5   15
         *    /  \    \
         *   3    7   18
         *
         * Example 2:
         * Input: root = [10,5,15,3,7,13,18,1,null,6], L = 6, R = 10
         * Output: 23
         *
         *         10
         *       /    \
         *      5      15
         *    /  \    /  \
         *   3    7  13  18
         *  /    /
         * 1    6
         *
         * Note:
         * The number of nodes in the tree is at most 10000.
         * The final answer is guaranteed to be less than 2^31.
         *
         */
        static void Main(string[] args)
        {
            var result = RangeSumBST(new TreeNode(10)
            {
                Left = new TreeNode(5)
                {
                    Left = new TreeNode(3),
                    Right = new TreeNode(7)
                },
                Right = new TreeNode(15)
                {
                    Right = new TreeNode(18)
                }
            }, 7, 15);
        }

        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            var ans = 0;
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node == null)
                {
                    continue;
                }

                if (L <= node.Val && node.Val <= R)
                {
                    ans += node.Val;
                }

                if (L < node.Val)
                {
                    stack.Push(node.Left);
                }

                if (node.Val < R)
                {
                    stack.Push(node.Right);
                }
            }

            return ans;
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
