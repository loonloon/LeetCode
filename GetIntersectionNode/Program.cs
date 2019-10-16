/*
 * 160. Intersection of Two Linked Lists
 * https://leetcode.com/problems/intersection-of-two-linked-lists/
 */
namespace GetIntersectionNode
{
    class Program
    {
        /*
         * Write a program to find the node at which the intersection of two singly linked lists begins.
         * For example, the following two linked lists:
         *
         * Example 1:
         * Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,0,1,8,4,5], skipA = 2, skipB = 3
         * Output: Reference of the node with value = 8
         * Input Explanation: The intersected node's value is 8 (note that this must not be 0 if the two lists intersect).
         * From the head of A, it reads as [4,1,8,4,5]. From the head of B, it reads as [5,0,1,8,4,5].
         * There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.
         *
         * Example 2:
         * Input: intersectVal = 2, listA = [0,9,1,2,4], listB = [3,2,4], skipA = 3, skipB = 1
         * Output: Reference of the node with value = 2
         * Input Explanation: The intersected node's value is 2 (note that this must not be 0 if the two lists intersect).
         * From the head of A, it reads as [0,9,1,2,4]. From the head of B, it reads as [3,2,4].
         * There are 3 nodes before the intersected node in A; There are 1 node before the intersected node in B.
         *
         * Example 3:
         * Input: intersectVal = 0, listA = [2,6,4], listB = [1,5], skipA = 3, skipB = 2
         * Output: null
         * Input Explanation: From the head of A, it reads as [2,6,4]. From the head of B, it reads as [1,5].
         * Since the two lists do not intersect, intersectVal must be 0, while skipA and skipB can be arbitrary values.
         * Explanation: The two lists do not intersect, so return null.
         *
         * Notes:
         * If the two linked lists have no intersection at all, return null.
         * The linked lists must retain their original structure after the function returns.
         * You may assume there are no cycles anywhere in the entire linked structure.
         * Your code should preferably run in O(n) time and use only O(1) memory.
         */
        static void Main(string[] args)
        {
            var example1Intersect = new ListNode(8)
            {
                Next = new ListNode(4)
                {
                    Next = new ListNode(5)
                }
            };

            var example1A = new ListNode(4)
            {
                Next = new ListNode(1)
                {
                    Next = example1Intersect
                }
            };

            var example1B = new ListNode(5)
            {
                Next = new ListNode(0)
                {
                    Next = new ListNode(1)
                    {
                        Next = example1Intersect
                    }
                }
            };

            var result = GetIntersectionNode(example1A, example1B);

            var example2Intersect = new ListNode(2)
            {
                Next = new ListNode(4)
            };

            var example2A = new ListNode(0)
            {
                Next = new ListNode(9)
                {
                    Next = new ListNode(1)
                    {
                        Next = example2Intersect
                    }
                }
            };

            var example2B = new ListNode(3)
            {
                Next = example2Intersect
            };

            var result2 = GetIntersectionNode(example2A, example2B);

            var example3A = new ListNode(2)
            {
                Next = new ListNode(6)
                {
                    Next = new ListNode(4)
                }
            };

            var example3B = new ListNode(1)
            {
                Next = new ListNode(5)
            };

            var result3 = GetIntersectionNode(example3A, example3B);
        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var pointerA = headA;
            var pointerB = headB;

            while (pointerA != pointerB)
            {
                pointerA = pointerA != null ? pointerA.Next : headB;
                pointerB = pointerB != null ? pointerB.Next : headA;
            }

            return pointerA;

            //    var listA = new List<ListNode>();

            //    while (headA != null)
            //    {
            //        listA.Add(headA);
            //        headA = headA.Next;
            //    }

            //    while (headB != null)
            //    {
            //        if (listA.Contains(headB))
            //        {
            //            return headB;
            //        }

            //        headB = headB.Next;
            //    }

            //    return null;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int x) { Val = x; }
    }
}
