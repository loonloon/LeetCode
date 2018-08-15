/*
 * 876. Middle of the Linked List
 * https://leetcode.com/problems/middle-of-the-linked-list/description/
 */
namespace MiddleNode
{
    class Program
    {
        /*
         * Given a non-empty, singly linked list with head node head, return a middle node of linked list.
         * If there are two middle nodes, return the second middle node.
         *
         * Example 1:
         * Input: [1,2,3,4,5]
         * Output: Node 3 from this list (Serialization: [3,4,5])
         * The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
         * Note that we returned a ListNode object ans, such that:
         * ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.
         *
         * Example 2:
         * Input: [1,2,3,4,5,6]
         * Output: Node 4 from this list (Serialization: [4,5,6])
         * Since the list has two middle nodes with values 3 and 4, we return the second one.
         *
         * Note:
         * The number of nodes in the given list will be between 1 and 100.
         *
         */
        static void Main(string[] args)
        {
            var result = MiddleNode(new ListNode(1)
            {
                Next = new ListNode(2)
                {
                    Next = new ListNode(3) { Next = new ListNode(4) { Next = new ListNode(5) } }
                }
            });

            var result2 = MiddleNode(new ListNode(1)
            {
                Next = new ListNode(2)
                {
                    Next = new ListNode(3) { Next = new ListNode(4) { Next = new ListNode(5) { Next = new ListNode(6) } } }
                }
            });
        }

        public static ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast?.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
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
