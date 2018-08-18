/*
 * 590. N-ary Tree Postorder Traversal
 * https://leetcode.com/problems/n-ary-tree-postorder-traversal/description/
 */

using System.Collections.Generic;

namespace Postorder
{
    class Program
    {
        /*
         * Given an n-ary tree, return the postorder traversal of its nodes' values.
         * For example, given a 3-ary tree:
         *      1
             /  |  \
             3  2  4
            / \
           5   6
         *
         * Return its postorder traversal as: [5,6,3,2,4,1].
         * Note: Recursive solution is trivial, could you do it iteratively?
         *
         */
        private static List<int> list = new List<int>();

        static void Main(string[] args)
        {
            var result = Postorder(new Node(1, new List<Node>
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

        public static IList<int> Postorder(Node root)
        {
            if (root == null)
            {
                return list;
            }

            foreach (var node in root.Children)
            {
                Postorder(node);
            }

            list.Add(root.Val);
            return list;
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
