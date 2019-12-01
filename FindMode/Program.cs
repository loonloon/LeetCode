using System.Collections.Generic;
/*
 * 501. Find Mode in Binary Search Tree
 * https://leetcode.com/problems/find-mode-in-binary-search-tree/
 */
namespace FindMode
{
    class Program
    {
        /*
         * Given a binary search tree (BST) with duplicates, find all the mode(s) (the most frequently occurred element) in the given BST.
         * Assume a BST is defined as follows:
         *
         * The left subtree of a node contains only nodes with keys less than or equal to the node's key.
         * The right subtree of a node contains only nodes with keys greater than or equal to the node's key.
         * Both the left and right subtrees must also be binary search trees.
         *
         * For example:
         * Given BST [1,null,2,2],
         * 1
         *  \
         *   2
         *  /
         * 2
         *
         * return [2].
         *
         * Note: If a tree has more than one mode, you can return them in any order.
         * Follow up: Could you do that without using any extra space? (Assume that the implicit stack space incurred due to recursion does not count).
         *
         */
        static void Main(string[] args)
        {
            var result = FindMode(new TreeNode(1)
            {
                Right = new TreeNode(2)
                {
                    Left = new TreeNode(2)
                }
            });
        }

        private static TreeNode _prev;
        private static int _count;
        private static int _maxCount = -1;

        public static int[] FindMode(TreeNode root)
        {
            var modes = new List<int>();
            _prev = root;

            InOrder(root, modes);

            var result = new int[modes.Count];

            for (var i = 0; i < modes.Count; i++)
            {
                result[i] = modes[i];
            }

            return result;
        }

        private static void InOrder(TreeNode root, List<int> modes)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.Left, modes);

            //check is exist, if yes then + 1
            _count = _prev.Val == root.Val ? _count + 1 : 1;

            //if the found values count is same as max count is the modes, add in
            if (_count == _maxCount)
            {
                modes.Add(root.Val);
            }
            //if the count is greater than then max count, remove all the modes take the maximum one
            else if (_count > _maxCount)
            {
                modes.Clear();
                modes.Add(root.Val);
                _maxCount = _count;
            }

            _prev = root;
            InOrder(root.Right, modes);
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
