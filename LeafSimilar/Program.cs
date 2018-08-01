using System.Collections.Generic;

/*
 * 872. Leaf-Similar Trees
 * https://leetcode.com/problems/leaf-similar-trees/description/
 */

namespace LeafSimilar
{
    class Program
    {
        /*
         * Consider all the leaves of a binary tree.  From left to right order, the values of those leaves form a leaf value sequence.
         *
         * For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).
         * Two binary trees are considered leaf-similar if their leaf value sequence is the same.
         * Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.
         *
         * Note:
         * Both of the given trees will have between 1 and 100 nodes.
         *
         */
        static void Main(string[] args)
        {
            var treeNode = new TreeNode(3)
            {
                Left = new TreeNode(5)
                {
                    Left = new TreeNode(6),
                    Right = new TreeNode(2)
                    {
                        Left = new TreeNode(7),
                        Right = new TreeNode(4)
                    }
                },
                Right = new TreeNode(1)
                {
                    Left = new TreeNode(9),
                    Right = new TreeNode(8)
                }
            };

            var result = LeafSimilar(treeNode, treeNode);
        }

        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root1);

            var stack2 = new Stack<TreeNode>();
            stack2.Push(root2);

            while (stack.Count != 0 && stack2.Count != 0)
            {
                if (DepthFirstSearch(stack) != DepthFirstSearch(stack2))
                {
                    return false;
                }
            }

            return stack.Count == 0 && stack2.Count == 0;
        }

        public static int DepthFirstSearch(Stack<TreeNode> stack)
        {
            while (true)
            {
                var treeNode = stack.Pop();

                //search from right first
                if (treeNode.Right != null)
                {
                    stack.Push(treeNode.Right);
                }

                if (treeNode.Left != null)
                {
                    stack.Push(treeNode.Left);
                }

                if (treeNode.Left == null && treeNode.Right == null)
                {
                    return treeNode.Val;
                }
            }
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
