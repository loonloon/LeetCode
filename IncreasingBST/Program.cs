/*
 * 897. Increasing Order Search Tree
 * https://leetcode.com/problems/increasing-order-search-tree/
 */
namespace IncreasingBST
{
    class Program
    {
        /*
         * Given a tree, rearrange the tree in in-order so that the leftmost node in the tree is now the root of the tree,
         * and every node has no left child and only 1 right child.
         *
         * Example 1:
         * Input: [5,3,6,2,4,null,8,1,null,null,null,7,9]
         *            5
         *          /   \
         *         3     6
         *        / \     \
         *       2   4     8
         *      /         / \
         *     1         7   9
         *
         * Output: [1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9]
         *
         *   1
         *    \
         *     2
         *      \
         *       3
         *        \
         *         4
         *          \
         *           5
         *            \
         *             6
         *              \
         *               7
         *                \
         *                 8
         *                  \
         *                   9
         *
         */
        static void Main(string[] args)
        {
            var result = IncreasingBST(new TreeNode(5)
            {
                Left = new TreeNode(3)
                {
                    Left = new TreeNode(2)
                    {
                        Left = new TreeNode(1)
                    },
                    Right = new TreeNode(4)
                },
                Right = new TreeNode(6)
                {
                    Right = new TreeNode(8)
                    {
                        Left = new TreeNode(7),
                        Right = new TreeNode(9)
                    }
                }
            });
        }

        public static TreeNode IncreasingBST(TreeNode root)
        {
            return IncreasingBST(root, null);
        }

        public static TreeNode IncreasingBST(TreeNode root, TreeNode tail)
        {
            if (root == null)
            {
                return tail;
            }

            var res = IncreasingBST(root.Left, root);
            root.Left = null;
            root.Right = IncreasingBST(root.Right, tail);

            return res;
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
