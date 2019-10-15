using System.Collections.Generic;
/*
 * 141. Linked List Cycle
 * https://leetcode.com/problems/linked-list-cycle/
 */
namespace HasCycle
{
    class Program
    {
        /*
         * Given a linked list, determine if it has a cycle in it.
         * To represent a cycle in the given linked list, we use an integer pos which represents the position (0-indexed)
         * in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.
         *
         * Example 1:
         * Input: head = [3,2,0,-4], pos = 1
         * Output: true
         * Explanation: There is a cycle in the linked list, where tail connects to the second node.
         *
         * Example 2:
         * Input: head = [1,2], pos = 0
         * Output: true
         * Explanation: There is a cycle in the linked list, where tail connects to the first node.
         *
         * Example 3:
         * Input: head = [1], pos = -1
         * Output: false
         * Explanation: There is no cycle in the linked list.
         *
         * Follow up:
         * Can you solve it using O(1) (i.e. constant) memory?
         */
        static void Main(string[] args)
        {
            var example1A = new ListNode(3);
            var example1B = new ListNode(2);
            var example1C = new ListNode(0);
            var example1D = new ListNode(-4);

            example1A.Next = example1B;
            example1B.Next = example1C;
            example1C.Next = example1D;
            example1D.Next = example1B;
            var result = HasCycle(example1A);

            var example2A = new ListNode(1);
            var example2B = new ListNode(2);

            example2A.Next = example2B;
            example2B.Next = example2A;
            var result2 = HasCycle(example2A);

            var result3 = HasCycle(new ListNode(1));
        }

        public static bool HasCycle(ListNode head)
        {
            var hashSet = new HashSet<ListNode>();

            while (head != null)
            {
                if (!hashSet.Contains(head))
                {
                    hashSet.Add(head);
                }
                else
                {
                    return true;
                }

                head = head.Next;
            }

            return false;

            //Two pointer
            //if (head == null || head.Next == null)
            //{
            //    return false;
            //}

            //ListNode fast = head, slow = head;

            //while (fast != null && fast.Next != null)
            //{
            //    fast = fast.Next.Next;
            //    slow = slow.Next;

            //    if (fast == slow)
            //    {
            //        return true;
            //    }
            //}

            //return false;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int x)
        {
            Val = x;
            Next = null;
        }
    }
}
