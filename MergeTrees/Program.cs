/*
 * 617. Merge Two Binary Trees
 * https://leetcode.com/problems/merge-two-binary-trees/description/
 */

namespace MergeTrees
{
    class Program
    {
        /*
         * Given two binary trees and imagine that when you put one of them to cover the other,
         * some nodes of the two trees are overlapped while the others are not.
         *
         * You need to merge them into a new binary tree. The merge rule is that if two nodes overlap,
         * then sum node values up as the new value of the merged node. Otherwise, the NOT null node will be used
         * as the node of new tree.
         *
         * Example 1:
         * Input:
         * Tree 1      Tree 2
         *     1          2
         *    / \        / \
         *   3   2      1   3
         *  /            \   \
         * 5              4   7
         *
         * Output:
         * Merged tree:
         *     3
         *    / \
         *   4   5
         *  / \   \
         * 5   4   7
         *
         */
        static void Main(string[] args)
        {
            var treeNode = new TreeNode(1)
            {
                Left = new TreeNode(3)
                {
                    Left = new TreeNode(5)
                },
                Right = new TreeNode(2)
            };

            var treeNode2 = new TreeNode(2)
            {
                Left = new TreeNode(1)
                {
                    Right = new TreeNode(4)
                },
                Right = new TreeNode(3)
                {
                    Right = new TreeNode(7)
                }
            };

            var result = MergeTrees(treeNode, treeNode2);
        }

        public class TreeNode
        {
            public int Val { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int x)
            {
                Val = x;
            }
        }

        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return null;
            }

            var treeNodeValue = t1 != null ? t1.Val : 0;
            var treeNode2Value = t2 != null ? t2.Val : 0;
            var mergeValue = treeNodeValue + treeNode2Value;

            var newTreeNode = new TreeNode(mergeValue)
            {
                Left = MergeTrees(t1?.Left, t2?.Left),
                Right = MergeTrees(t1?.Right, t2?.Right)
            };

            return newTreeNode;
        }
    }
}
