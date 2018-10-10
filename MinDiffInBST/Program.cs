/*
 * 783. Minimum Distance Between BST Nodes
 * https://leetcode.com/problems/minimum-distance-between-bst-nodes/
 */

using System;

namespace MinDiffInBST
{
    class Program
    {
        /*
         * Given a Binary Search Tree (BST) with the root node root,
         * return the minimum difference between the values of any two different nodes in the tree.
         *
         * Example :
         * Input: root = [4,2,6,1,3,null,null]
         * Output: 1
         *
         * Explanation:
         * Note that root is a TreeNode object, not an array.
         * The given tree [4,2,6,1,3,null,null] is represented by the following diagram:
         *       4
         *     /   \
         *    2     6
         *  /   \
         * 1     3
         *
         *
         * while the minimum difference in this tree is 1, it occurs between node 1 and node 2,
         * also between node 3 and node 2.
         *
         * Note:
         * The size of the BST will be between 2 and 100.
         * The BST is always valid, each node's value is an integer, and each node's value is different.
         *
         */
        static void Main(string[] args)
        {
            var result = MinDiffInBST(new TreeNode(4)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(1),
                    Right = new TreeNode(3)
                },
                Right = new TreeNode(6)
            });
        }

        public static int result = int.MaxValue;
        public static int previousTreeNodeValue = -1;
        public static int MinDiffInBST(TreeNode root)
        {
            if (root.Left != null)
            {
                MinDiffInBST(root.Left);
            }

            if (previousTreeNodeValue >= 0)
            {
                result = Math.Min(result, root.Val - previousTreeNodeValue);
            }

            previousTreeNodeValue = root.Val;

            if (root.Right != null)
            {
                MinDiffInBST(root.Right);
            }

            return result;
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
