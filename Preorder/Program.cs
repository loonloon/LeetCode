using System.Collections.Generic;
using System.Linq;

/*
 * 589. N-ary Tree Preorder Traversal
 * https://leetcode.com/problems/n-ary-tree-preorder-traversal/description/
 */
namespace Preorder
{
    class Program
    {
        /*
         * Given an n-ary tree, return the preorder traversal of its nodes' values.
         * For example, given a 3-ary tree:
         *
         * Return its preorder traversal as: [1,3,5,6,2,4].
         * Note: Recursive solution is trivial, could you do it iteratively?
         *
         */
        static void Main(string[] args)
        {
            var result = Preorder(new Node(1, new List<Node>
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

        public static IList<int> Preorder(Node root)
        {
            var preorder = new List<int>();

            if (root == null)
            {
                return preorder;
            }

            var stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Any())
            {
                root = stack.Pop();
                preorder.Add(root.Val);

                if (root.Children == null)
                {
                    continue;
                }

                foreach (var t in root.Children.Reverse())
                {
                    stack.Push(t);
                }
            }

            return preorder;
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
