/*
 * 965. Univalued Binary Tree
 * https://leetcode.com/problems/univalued-binary-tree/
 */

using System.Collections.Generic;

namespace IsUnivalTree
{
    class Program
    {
        /*
         * A binary tree is univalued if every node in the tree has the same value.
         * Return true if and only if the given tree is univalued.
         *
         * Example 1:
         *
         *     1
         *    / \
         *   1   1 
         *  / \   \
         * 1   1   1
         *
         * Input: [1,1,1,1,1,null,1]
         * Output: true
         *
         * Example 2:
         *
         *     2
         *    / \
         *   2   2 
         *  / \  
         * 5   2   
         *
         * Input: [2,2,2,5,2]
         * Output: false
         *
         * Note:
         * The number of nodes in the given tree will be in the range [1, 100].
         * Each node's value will be an integer in the range [0, 99].
         *
         */
        static void Main(string[] args)
        {
            var result = IsUnivalTree(new TreeNode(1)
            {
                Left = new TreeNode(1)
                {
                    Left = new TreeNode(1),
                    Right = new TreeNode(1)
                },
                Right = new TreeNode(1)
                {
                    Right = new TreeNode(1)
                }
            });

            var result2 = IsUnivalTree(new TreeNode(2)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(5),
                    Right = new TreeNode(2)
                },
                Right = new TreeNode(2)
            });
        }

        public static bool IsUnivalTree(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();

                if (currentNode.Left != null && currentNode.Left.Val != currentNode.Val ||
                    currentNode.Right != null && currentNode.Right.Val != currentNode.Val)
                {
                    return false;
                }

                if (currentNode.Left != null)
                {
                    stack.Push(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    stack.Push(currentNode.Right);
                }
            }

            return true;
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
