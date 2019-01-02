using System.Collections.Generic;
/*
 * 107. Binary Tree Level Order Traversal II
 * https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
 */
namespace LevelOrderBottom
{
    class Program
    {
        /*
         * Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
         *
         * For example:
         * Given binary tree [3,9,20,null,null,15,7],
         *    3
         *   / \
         *  9  20
         *    /  \
         *   15   7
         *
         * return its bottom-up level order traversal as:
         * [
         *  [15,7],
         *  [9,20],
         *  [3]
         * ]
         *
         */
        static void Main(string[] args)
        {
            var result = LevelOrderBottom(new TreeNode(3)
            {
                Left = new TreeNode(9),
                Right = new TreeNode(20)
                {
                    Left = new TreeNode(15),
                    Right = new TreeNode(7)
                }
            });
        }

        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            var wrapList = new List<IList<int>>();

            if (root == null) 
            {
                return wrapList;
            }

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var levelNum = queue.Count;
                var subList = new List<int>();

                for (var i = 0; i < levelNum; i++)
                {
                    if (queue.Peek().Left != null)
                    {
                        queue.Enqueue(queue.Peek().Left);
                    }

                    if (queue.Peek().Right != null)
                    {
                        queue.Enqueue(queue.Peek().Right);
                    }

                    subList.Add(queue.Dequeue().Val);
                }

                wrapList.Insert(0, subList);
            }

            return wrapList;
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
