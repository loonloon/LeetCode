/*
 * 538. Convert BST to Greater Tree
 * https://leetcode.com/problems/convert-bst-to-greater-tree/
 */
namespace ConvertBST
{
    class Program
    {
        /*
         * Given a Binary Search Tree (BST), convert it to a Greater Tree such that every key of the original
         * BST is changed to the original key plus sum of all keys greater than the original key in BST.
         *
         * Example:
         * Input: The root of a Binary Search Tree like this:
         *    5
         *  /   \
         * 2     13
         *
         * Output: The root of a Greater Tree like this:
         *    18
         *   /   \
         * 20     13
         *
         */
        static void Main(string[] args)
        {
            var result = ConvertBST(new TreeNode(5)
            {
                Left = new TreeNode(2),
                Right = new TreeNode(13)
            });
        }

        private static int sum;
        public static TreeNode ConvertBST(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            ConvertBST(root.Right);
            root.Val += sum;
            sum = root.Val;
            ConvertBST(root.Left);

            return root;
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
