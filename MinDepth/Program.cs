using System;
/*
 * 111. Minimum Depth of Binary Tree
 * https://leetcode.com/problems/minimum-depth-of-binary-tree/
 */
namespace MinDepth
{
    class Program
    {
        /*
         * Given a binary tree, find its minimum depth.
         * The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
         * Note: A leaf is a node with no children.
         * Example:
         * Given binary tree [3,9,20,null,null,15,7],
         *   3
         *  / \
         * 9  20
         *   /  \
         *  15   7
         *
         * return its minimum depth = 2.
         *
         */
        static void Main(string[] args)
        {
            var result = MinDepth(new TreeNode(3)
            {
                Left = new TreeNode(9),
                Right = new TreeNode(20)
                {
                    Left = new TreeNode(15),
                    Right = new TreeNode(7)
                }
            });
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = MinDepth(root.Left);
            var right = MinDepth(root.Right);
            return (left == 0 || right == 0) ? left + right + 1 : Math.Min(left, right) + 1;
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
