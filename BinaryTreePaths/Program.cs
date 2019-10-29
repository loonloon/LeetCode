using System.Collections.Generic;
/*
 * 257. Binary Tree Paths
 * https://leetcode.com/problems/binary-tree-paths/
 */
namespace BinaryTreePaths
{
    class Program
    {
        /*
         * Given a binary tree, return all root-to-leaf paths.
         * Note: A leaf is a node with no children.
         *
         * Example:
         * Input:
         *    1
         *  /   \
         * 2     3
         *  \
         *   5
         *
         * Output: ["1->2->5", "1->3"]
         * Explanation: All root-to-leaf paths are: 1->2->5, 1->3
         *
         */
        static void Main(string[] args)
        {
            var result = BinaryTreePaths(new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Right = new TreeNode(5)
                },
                Right = new TreeNode(3)
            });
        }

        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            var result = new List<string>();

            if (root == null)
            {
                return result;
            }

            GetPaths(root, result, $"{root.Val}");
            return result;
        }

        private static void GetPaths(TreeNode root, List<string> result, string path)
        {
            if (root == null)
            {
                return;
            }

            if (root.Left == null && root.Right == null)
            {
                result.Add(path);
            }

            if (root.Left != null)
            {
                GetPaths(root.Left, result, $"{path}->{root.Left.Val}");
            }

            if (root.Right != null)
            {
                GetPaths(root.Right, result, $"{path}->{root.Right.Val}");
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
