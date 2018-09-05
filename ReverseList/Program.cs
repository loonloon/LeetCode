/*
 * 206. Reverse Linked List
 * https://leetcode.com/problems/reverse-linked-list/description/
 */
namespace ReverseList
{
    class Program
    {
        /*
         * Reverse a singly linked list.
         *
         * Example:
         * Input: 1->2->3->4->5->NULL
         * Output: 5->4->3->2->1->NULL
         *
         */
        static void Main(string[] args)
        {
            var result = ReverseList(new ListNode(1)
            {
                Next = new ListNode(2) { Next = new ListNode(3) { Next = new ListNode(4) { Next = new ListNode(5) } } }
            });
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode newHead = null;

            while (head != null)
            {
                var next = head.Next;
                head.Next = newHead;
                newHead = head;
                head = next;
            }

            return newHead;
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
