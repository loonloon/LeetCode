using System.Collections.Generic;
/*
 *20. Valid Parentheses
 * https://leetcode.com/problems/valid-parentheses/
 *
 */
namespace IsValid
{
    /*
     * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     * An input string is valid if:
     *
     * 1. Open brackets must be closed by the same type of brackets.
     * 2. Open brackets must be closed in the correct order.
     * Note that an empty string is also considered valid.
     *
     * Example 1:
     * Input: "()"
     * Output: true
     *
     * Example 2:
     * Input: "()[]{}"
     * Output: true
     *
     * Example 3:
     * Input: "(]"
     * Output: false
     *
     * Example 4:
     * Input: "([)]"
     * Output: false
     *
     * Example 5:
     * Input: "{[]}"
     * Output: true
     *
     */
    class Program
    {
        static void Main(string[] args)
        {
            var result = IsValid("()");
            var result2 = IsValid("()[]{}");
            var result3 = IsValid("(]");
            var result4 = IsValid("([)]");
            var result5 = IsValid("{[]}");
        }

        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var character in s)
            {
                switch (character)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    default:
                        if (stack.Count == 0 || stack.Pop() != character)
                        {
                            return false;
                        }
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}
