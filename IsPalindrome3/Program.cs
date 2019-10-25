/*
 * 234. Palindrome Linked List
 * https://leetcode.com/problems/palindrome-linked-list/
 */
namespace IsPalindrome3
{
    class Program
    {
        /*
         * Given a singly linked list, determine if it is a palindrome.
         *
         * Example 1:
         * Input: 1->2
         * Output: false
         *
         * Example 2:
         * Input: 1->2->2->1
         * Output: true
         *
         * Follow up:
         * Could you do it in O(n) time and O(1) space?
         *
         */
        static void Main(string[] args)
        {
            var result = IsPalindrome(new ListNode(1)
            {
                Next = new ListNode(2)
            });

            var result2 = IsPalindrome((new ListNode(1)
            {
                Next = new ListNode(2)
                {
                    Next = new ListNode(2)
                    {
                        Next = new ListNode(1)
                    }
                }
            }));
        }

        public static bool IsPalindrome(ListNode head)
        {
            var temp = head;
            var half = false;
            return IsPalindrome(temp, ref head, ref half);
        }

        private static bool IsPalindrome(ListNode current, ref ListNode head, ref bool isHalf)
        {
            if (current == null)
            {
                return true;
            }

            var result = IsPalindrome(current.Next, ref head, ref isHalf);

            if (isHalf)
            {
                return true;
            }

            if (!result)
            {
                return false;
            }

            if (current == head || current.Next == head)
            {
                isHalf = true;
                return true;
            }

            if (current.Val == head.Val)
            {
                head = head.Next;
                return true;
            }

            return false;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int x)
        {
            Val = x;
        }
    }
}
