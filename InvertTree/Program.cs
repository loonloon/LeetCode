using System.Collections.Generic;
using System.Linq;

/*
 * 226. Invert Binary Tree
 * https://leetcode.com/problems/invert-binary-tree/description/
 */
namespace InvertTree
{
    class Program
    {
        /*
         * Invert a binary tree.
         * Example:
         * Input:
         *      4
         *    /   \
         *   2     7
         *  / \   / \
         * 1   3 6   9
         *
         * Output:
         *      4
         *    /   \
         *   7     2
         *  / \   / \
         * 9   6 3   1
         *
         */
        static void Main(string[] args)
        {
            var result = InvertTree(new TreeNode(4)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(1),
                    Right = new TreeNode(3)
                },
                Right = new TreeNode(7)
                {
                    Left = new TreeNode(6),
                    Right = new TreeNode(9)
                }
            });
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var node = stack.Pop();
                var left = node.Left;
                node.Left = node.Right;
                node.Right = left;

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }
            }

            return root;

            //Solution 1
            //if (root == null)
            //{
            //    return null;
            //}

            //var left = root.Left;
            //var right = root.Right;

            //root.Left = InvertTree(right);
            //root.Right = InvertTree(left);
            //return root;
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
