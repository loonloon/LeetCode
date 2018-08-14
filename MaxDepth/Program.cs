using System;
using System.Collections.Generic;

/*
 * 559. Maximum Depth of N-ary Tree
 * https://leetcode.com/problems/maximum-depth-of-n-ary-tree/description/
 *
 */
namespace MaxDepth
{
    class Program
    {
        /*
         * Given a n-ary tree, find its maximum depth.
         * The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
         * For example, given a 3-ary tree:
         *
         *         1
               /   |   \
              3    2    4
             / \
            5   6
         *
         * We should return its max depth, which is 3.
         *
         * Note:
         * The depth of the tree is at most 1000.
         * The total number of nodes is at most 5000.
         *
         */
        static void Main(string[] args)
        {
            var result = MaxDepth(new Node(1, new List<Node>
            {
                new Node(3, new List<Node>
                {
                    new Node(5, null),
                    new Node(6, null)
                }),
                new Node(2, null),
                new Node(4, null)
            }));
        }

        public static int MaxDepth(Node root)
        {
            var max = 0;

            if (root == null)
            {
                return max;
            }

            foreach (var childNode in root.Children)
            {
                max = Math.Max(max, MaxDepth(childNode));
            }

            return max + 1;
        }
    }

    public class Node
    {
        public int Val;
        public IList<Node> Children;

        public Node(int val, IList<Node> children)
        {
            Val = val;
            Children = children;
        }
    }
}
