using System.Collections.Generic;
/*
 * 203. Remove Linked List Elements
 * https://leetcode.com/problems/remove-linked-list-elements/
 */
namespace RemoveElements
{
    class Program
    {
        /*
         * Remove all elements from a linked list of integers that have value val.
         * Example:
         * Input:  1->2->6->3->4->5->6, val = 6
         * Output: 1->2->3->4->5
         *
         */
        static void Main(string[] args)
        {
            var result = RemoveElements(new ListNode(1)
            {
                Next = new ListNode(2)
                {
                    Next = new ListNode(6)
                    {
                        Next = new ListNode(3)
                        {
                            Next = new ListNode(4)
                            {
                                Next = new ListNode(5)
                                {
                                    Next = new ListNode(6)
                                }
                            }
                        }
                    }
                }
            }, 6);
        }

        public static ListNode RemoveElements(ListNode head, int val)
        {
            var listNodes = new List<ListNode>();

            while (head != null)
            {
                if (head.Val != val)
                {
                    listNodes.Add(head);
                }

                head = head.Next;
            }

            if (listNodes.Count > 0)
            {
                var firstNode = new ListNode(listNodes[0].Val);
                var currentNode = firstNode;

                for (var i = 1; i < listNodes.Count; i++)
                {
                    currentNode.Next = new ListNode(listNodes[i].Val);
                    currentNode = currentNode.Next;
                }

                return firstNode;
            }

            return null;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int x) { Val = x; }
    }
}
