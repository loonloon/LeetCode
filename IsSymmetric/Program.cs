using System.Collections.Generic;

/*
 * 101. Symmetric Tree
 * https://leetcode.com/problems/symmetric-tree/
 */
namespace IsSymmetric
{
    class Program
    {
        /*
         * Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
         * For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
         *
         *     1
         *    / \
         *   2   2
         *  / \ / \
         * 3  4 4  3
         *
         * But the following [1,2,2,null,3,null,3] is not:
         *
         *    1
         *   / \
         *  2   2
         *  \   \
         *  3    3
         *
         */
        static void Main(string[] args)
        {
            var result = IsSymmetric(new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(3),
                    Right = new TreeNode(4)
                },
                Right = new TreeNode(2)
                {
                    Left = new TreeNode(4),
                    Right = new TreeNode(3)
                }
            });
        }

        public static bool IsSymmetric(TreeNode root)
        {
            return root == null || IsMirror(root.Left, root.Right);

            //non recursion
            //if (root == null)
            //{
            //    return true;
            //}

            //var stack = new Stack<TreeNode>();

            //if (root.Left != null)
            //{
            //    if (root.Right == null)
            //    {
            //        return false;
            //    }

            //    stack.Push(root.Left);
            //    stack.Push(root.Right);
            //}
            //else if (root.Right != null)
            //{
            //    return false;
            //}

            //while (stack.Count != 0)
            //{
            //    if (stack.Count % 2 != 0)
            //    {
            //        return false;
            //    }

            //    var right = stack.Pop();
            //    var left = stack.Pop();

            //    if (right.Val != left.Val)
            //    {
            //        return false;
            //    }

            //    if (left.Left != null)
            //    {
            //        if (right.Right == null)
            //        {
            //            return false;
            //        }

            //        stack.Push(left.Left);
            //        stack.Push(right.Right);
            //    }
            //    else if (right.Right != null)
            //    {
            //        return false;
            //    }

            //    if (left.Right != null)
            //    {
            //        if (right.Left == null)
            //        {
            //            return false;
            //        }

            //        stack.Push(left.Right);
            //        stack.Push(right.Left);
            //    }
            //    else if (right.Left != null)
            //    {
            //        return false;
            //    }
            //}

            //return true;
        }

        private static bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }

            if (left.Val != right.Val)
            {
                return false;
            }

            return IsMirror(left.Left, right.Right) && IsMirror(left.Right, right.Left);
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
