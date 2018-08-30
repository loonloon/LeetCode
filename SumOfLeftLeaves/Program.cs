using System.Collections.Generic;
using System.Linq;

/*
 * 404. Sum of Left Leaves
 * https://leetcode.com/problems/sum-of-left-leaves/description/
 */
namespace SumOfLeftLeaves
{
    class Program
    {
        /*
         * Find the sum of all left leaves in a given binary tree.
         * Example:
         *   3
         *  / \
         * 9  20
         *   /  \
         *  15   7
         *
         * There are two left leaves in the binary tree, with values 9 and 15 respectively. Return 24.
         *
         */
        static void Main(string[] args)
        {
            var result = SumOfLeftLeaves(new TreeNode(3)
            {
                Left = new TreeNode(9),
                Right = new TreeNode(20)
                {
                    Left = new TreeNode(15),
                    Right = new TreeNode(7)
                }
            });
        }

        public static int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var totalLeft = 0;
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var node = stack.Pop();

                if (node.Left != null)
                {
                    if (node.Left.Left == null && node.Left.Right == null)
                    {
                        totalLeft = node.Left.Val;
                    }
                    else
                    {
                        stack.Push(node.Left);
                    }
                }

                if (node.Right != null)
                {
                    if (node.Right.Left != null || node.Right.Right != null)
                    {
                        stack.Push(node.Right);
                    }
                }
            }

            return totalLeft;
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
