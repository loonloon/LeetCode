/*
 * 606. Construct String from Binary Tree
 * https://leetcode.com/problems/construct-string-from-binary-tree/description/
 */
namespace Tree2str
{
    class Program
    {
        /*
         * You need to construct a string consists of parenthesis and integers from a binary tree with the preorder traversing way.
         *
         * The null node needs to be represented by empty parenthesis pair "()". And you need to omit all the empty parenthesis pairs
         * that don't affect the one-to-one mapping relationship between the string and the original binary tree.
         *
         * Example 1:
         * Input: Binary tree: [1,2,3,4]
         *      1
         *    /   \
         *   2     3
         *  /
         * 4
         *
         * Output: "1(2(4))(3)"
         *
         * Explanation:
         * Originallay it needs to be "1(2(4)())(3()())", but you need to omit all the unnecessary empty parenthesis pairs.
         * And it will be "1(2(4))(3)".
         *
         */
        static void Main(string[] args)
        {
            var result = Tree2str(new TreeNode(1) { Left = new TreeNode(2) { Left = new TreeNode(4) }, Right = new TreeNode(3) });
        }

        public static string Tree2str(TreeNode t)
        {
            if (t == null)
            {
                return "";
            }

            var result = $"{t.Val}";
            var left = Tree2str(t.Left);
            var right = Tree2str(t.Right);

            if (left == "" && right == "")
            {
                return result;
            }

            if (left == "")
            {
                return $"{result}()({right})";
            }

            if (right == "")
            {
                return $"{result}({left})";
            }

            return $"{result}({left})({right})";
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
