/*
 * 637. Average of Levels in Binary Tree
 */

using System.Collections.Generic;
using System.Linq;

namespace AverageOfLevels
{
    class Program
    {
        /*
         * Given a non-empty binary tree, return the average value of the nodes on each level in the form of an array.
         * Example 1:
         * Input:
         *    3
         *   / \
         *  9  20
         *    /  \
         *   15   7
         *
         * Output: [3, 14.5, 11]
         * Explanation:
         * The average value of nodes on level 0 is 3,  on level 1 is 14.5, and on level 2 is 11.
         * Hence return [3, 14.5, 11].
         *
         * Note:
         * The range of node's value is in the range of 32-bit signed integer.
         *
         */
        static void Main(string[] args)
        {
            var result = AverageOfLevels(new TreeNode(3)
            {
                Left = new TreeNode(9),
                Right = new TreeNode(20)
                {
                    Left = new TreeNode(15),
                    Right = new TreeNode(7)
                }
            });
        }


        public static IList<double> AverageOfLevels(TreeNode root)
        {
            var list = new List<double>();
            var queue = new Queue<TreeNode>();

            if (root == null)
            {
                return list;
            }

            queue.Enqueue(root);

            while (queue.Any())
            {
                var n = queue.Count;
                var sum = 0.0;

                for (var i = 0; i < n; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.Val;

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                list.Add(sum / n);
            }

            return list;
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
