/*
 * 112. Path Sum
 * https://leetcode.com/problems/path-sum/
 */
namespace HasPathSum
{
    class Program
    {
        /*
         * Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values
         * along the path equals the given sum.
         *
         * Note: A leaf is a node with no children.
         * Example:
         * Given the below binary tree and sum = 22,
         *       5
         *      / \
         *     4   8
         *    /   / \
         *   11  13  4
         *  /  \      \
         * 7    2      1
         *
         * return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
         *
         */
        static void Main(string[] args)
        {
            var result = HasPathSum(new TreeNode(5)
            {
                Left = new TreeNode(4)
                {
                    Left = new TreeNode(11)
                    {
                        Left = new TreeNode(7),
                        Right = new TreeNode(2)
                    }
                },
                Right = new TreeNode(8)
                {
                    Left = new TreeNode(13),
                    Right = new TreeNode(4)
                    {
                        Right = new TreeNode(1)
                    }
                }
            }, 22);
        }

        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            var result = sum - root.Val;

            if (root.Left == null && root.Right == null && result == 0)
            {
                return true;
            }

            return HasPathSum(root.Left, result) || HasPathSum(root.Right, result);
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
