/*
 * 669. Trim a Binary Search Tree
 * https://leetcode.com/problems/trim-a-binary-search-tree/description/
 */
namespace TrimBST
{
    class Program
    {
        /*
         * Given a binary search tree and the lowest and highest boundaries as L and R,
         * trim the tree so that all its elements lies in [L, R] (R >= L).
         *
         * You might need to change the root of the tree, so the result should return the new root of the trimmed binary search tree.
         *
         * Example 1:
         * Input:
         *    1
         *   / \
         *  0   2
         *
         * L = 1
         * R = 2
         *
         * Output:
         * 1
         *  \
         *   2
         *
         * Example 2:
         * Input:
         *    3
         *   / \
         *  0   4
         *   \
         *    2
         *   /
         *  1
         *
         * L = 1
         * R = 3
         *
         * Output:
         *     3
         *    /
         *   2
         *  /
         * 1
         *
         */
        static void Main(string[] args)
        {
            var result = TrimBST(new TreeNode(1)
            {
                Left = new TreeNode(0),
                Right = new TreeNode(2)
            }, 1, 2);

            var result2 = TrimBST(new TreeNode(1)
            {
                Left = new TreeNode(0)
                {
                    Right = new TreeNode(2)
                    {
                        Left = new TreeNode(1)
                    }
                },
                Right = new TreeNode(4)
            }, 1, 3);
        }

        public static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null)
            {
                return null;
            }

            //If the value of this node is less than L, then the whole left subtree will be smaller, 
            //so we can discard the left sub tree and return the root of the trimmed right sub tree 
            if (root.Val < L)
            {
                return TrimBST(root.Right, L, R);
            }

            //If the value of this node is greater than R, then the whole right subtree will be greater
            //so we can discard the right sub tree and return the root of the trimmed left sub tree
            if (root.Val > R)
            {
                return TrimBST(root.Left, L, R);
            }

            // If the value of this node does not need to be deleted, 
            // we need to pass this recursive call downwards to both sides
            root.Left = TrimBST(root.Left, L, R);
            root.Right = TrimBST(root.Right, L, R);
            return root;
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
