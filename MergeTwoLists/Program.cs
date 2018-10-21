/*
 * 21. Merge Two Sorted Lists
 * https://leetcode.com/problems/merge-two-sorted-lists/
 */
namespace MergeTwoLists
{
    class Program
    {
        /*
         * Merge two sorted linked lists and return it as a new list.
         * The new list should be made by splicing together the nodes of the first two lists.
         *
         * Example:
         * Input: 1->2->4, 1->3->4
         * Output: 1->1->2->3->4->4
         *
         */
        static void Main(string[] args)
        {
            var result = MergeTwoLists(
                new ListNode(1)
                {
                    Next = new ListNode(2)
                    {
                        Next = new ListNode(4)
                    }
                },
                new ListNode(1)
                {
                    Next = new ListNode(3)
                    {
                        Next = new ListNode(4)
                    }
                });
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            if (l1.Val < l2.Val)
            {
                l1.Next = MergeTwoLists(l1.Next, l2);
                return l1;
            }

            l2.Next = MergeTwoLists(l2.Next, l1);
            return l2;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int x) { Val = x; }
    }
}
