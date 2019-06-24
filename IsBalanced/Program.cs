using System;
/*
 * 110. Balanced Binary Tree
 * https://leetcode.com/problems/balanced-binary-tree/
 */
namespace IsBalanced
{
    class Program
    {
        /*
         * Given a binary tree, determine if it is height-balanced.
         * For this problem, a height-balanced binary tree is defined as:
         * a binary tree in which the depth of the two subtrees of every node never differ by more than 1.
         *
         * Example 1:
         * Given the following tree [3,9,20,null,null,15,7]:
         *   3
         *  / \
         * 9  20
         *   /  \
         *  15   7
         *
         * Return true.
         *
         * Example 2:
         * Given the following tree [1,2,2,3,3,null,null,4,4]:
         *       1
         *      / \
         *     2   2
         *    / \
         *   3   3
         *  / \
         * 4   4
         *
         * Return false.
         *
         */
        static void Main(string[] args)
        {
            var result = IsBalanced(new TreeNode(3)
            {
                Left = new TreeNode(9),
                Right = new TreeNode(20)
                {
                    Left = new TreeNode(15),
                    Right = new TreeNode(7)
                }
            });

            var result2 = IsBalanced(new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(3)
                    {
                        Left = new TreeNode(4),
                        Right = new TreeNode(4)
                    },
                    Right = new TreeNode(3)
                },
                Right = new TreeNode(2)
            });
        }

        public static bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var left = Depth(root.Left);
            var right = Depth(root.Right);
            return Math.Abs(left - right) <= 1 && IsBalanced(root.Left) && IsBalanced(root.Right);
        }

        private static int Depth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(Depth(root.Left), Depth(root.Right)) + 1;
        }
    }

    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int x) { Val = x; }
    }
}
