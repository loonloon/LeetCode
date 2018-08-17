/*
 * 100. Same Tree
 * https://leetcode.com/problems/same-tree/description/
 */
namespace IsSameTree
{
    class Program
    {
        /*
         * Given two binary trees, write a function to check if they are the same or not.
         * Two binary trees are considered the same if they are structurally identical and the nodes have the same value.
         *
         * Example 1:
         * Input:
         *   1         1
         *  / \       / \
         * 2   3     2   3
         *
         * [1,2,3],   [1,2,3]
         * Output: true
         *
         * Example 2:
         * Input:
         *   1         1
         *  /           \
         * 2             2
         *
         * [1,2],     [1,null,2]
         * Output: false
         *
         * Example 3:
         * Input:
         *   1         1
         *  / \       / \
         * 2   1     1   2
         *
         * [1,2,1],   [1,1,2]
         * Output: false
         *
         */
        static void Main(string[] args)
        {
            var result = IsSameTree(
                new TreeNode(1) { Left = new TreeNode(2), Right = new TreeNode(3) },
                new TreeNode(1) { Left = new TreeNode(2), Right = new TreeNode(3) });

            var result2 = IsSameTree(
                new TreeNode(1) { Left = new TreeNode(2) },
                new TreeNode(1) { Right = new TreeNode(2) });

            var result3 = IsSameTree(
                new TreeNode(1) { Left = new TreeNode(2), Right = new TreeNode(1) },
                new TreeNode(1) { Left = new TreeNode(1), Right = new TreeNode(2) });
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            if (p.Val == q.Val)
            {
                return IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);
            }
            else
            {
                return false;
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
