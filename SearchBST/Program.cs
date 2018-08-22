/*
 * 700. Search in a Binary Search Tree
 * https://leetcode.com/problems/search-in-a-binary-search-tree/description/
 */
namespace SearchBST
{
    class Program
    {
        /*
         * Given the root node of a binary search tree (BST) and a value. You need to find the node in the BST that the node's value equals the given value.
         * Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.
         * For example,
         * Given the tree:
         *     4
         *    / \
         *   2   7
         *  / \
         * 1   3
         *
         * And the value to search: 2
         *
         * You should return this subtree:
         *   2
         *  / \
         * 1   3
         *
         * In the example above, if we want to search the value 5, since there is no node with value 5, we should return NULL.
         * Note that an empty tree is represented by NULL, therefore you would see the expected output (serialized tree format) as [], not null.
         *
         */
        static void Main(string[] args)
        {
            var result = SearchBST(new TreeNode(4)
            {
                Left = new TreeNode(2) { Left = new TreeNode(1), Right = new TreeNode(3) },
                Right = new TreeNode(7)
            }, 2);
        }

        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Val == val)
            {
                return root;
            }

            var left = SearchBST(root.Left, val);

            if (left != null)
            {
                return left;
            }

            return SearchBST(root.Right, val);
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
