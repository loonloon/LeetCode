using System;

namespace DiameterOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DiameterOfBinaryTree(new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(4),
                    Right = new TreeNode(5)
                },
                Right = new TreeNode(3)
            });
        }

        public static int DiameterOfBinaryTree(TreeNode root)
        {
            var max = 0;
            MaxDepth(root, ref max);
            return max;
        }

        private static int MaxDepth(TreeNode root, ref int max)
        {
            if (root == null)
            {
                return 0;
            }

            var left = MaxDepth(root.Left, ref max);
            var right = MaxDepth(root.Right, ref max);
            max = Math.Max(max, left + right);
            return Math.Max(left, right) + 1;
        }
    }

    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            Val = val;
            Left = left;
            Right = right;
        }
    }
}
