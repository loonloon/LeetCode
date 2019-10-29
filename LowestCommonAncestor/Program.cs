/*
 * 235. Lowest Common Ancestor of a Binary Search Tree
 * https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
 */
namespace LowestCommonAncestor
{
    class Program
    {
        /*
         * Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.
         * According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q
         * as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”
         *
         * Given binary search tree:  root = [6,2,8,0,4,7,9,null,null,3,5]
         * Example 1:
         * Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
         * Output: 6
         * Explanation: The LCA of nodes 2 and 8 is 6.
         *
         * Example 2:
         * Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 4
         * Output: 2
         * Explanation: The LCA of nodes 2 and 4 is 2, since a node can be a descendant of itself according to the LCA definition.
         *
         * Note:
         * All of the nodes' values will be unique.
         * p and q are different and both values will exist in the BST.
         *
         */
        static void Main(string[] args)
        {
            var treeNode2 = new TreeNode(2)
            {
                Left = new TreeNode(0),
                Right = new TreeNode(4)
                {
                    Left = new TreeNode(3),
                    Right = new TreeNode(5)
                }
            };

            var treeNode8 = new TreeNode(8)
            {
                Left = new TreeNode(7),
                Right = new TreeNode(9)
            };

            var result = LowestCommonAncestor(new TreeNode(6)
            {
                Left = treeNode2,
                Right = treeNode8
            }, treeNode2, treeNode8);
        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while (true)
            {
                if (root == null)
                {
                    return null;
                }

                if (root.Val > p.Val && root.Val > q.Val)
                {
                    root = root.Left;
                    continue;
                }

                if (root.Val < p.Val && root.Val < q.Val)
                {
                    root = root.Right;
                    continue;
                }

                return root;
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
