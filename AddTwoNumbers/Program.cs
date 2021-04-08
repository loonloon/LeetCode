/*
 * 2. Add Two Numbers
 * https://leetcode.com/problems/add-two-numbers/
 */
namespace AddTwoNumbers
{
    class Program
    {
        /*
         * You are given two non-empty linked lists representing two non-negative integers.
         * The digits are stored in reverse order, and each of their nodes contains a single digit.
         * Add the two numbers and return the sum as a linked list.
         *
         * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
         *
         * Example 1:
         * Input: l1 = [2,4,3], l2 = [5,6,4]
         * Output: [7,0,8]
         * Explanation: 342 + 465 = 807.
         *
         * Example 2:
         * Input: l1 = [0], l2 = [0]
         * Output: [0]
         *
         * Example 3:
         * Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
         * Output: [8,9,9,9,0,0,0,1]
         *
         */
        static void Main(string[] args)
        {
            var result = AddTwoNumbers(new ListNode(2)
            {
                Next = new ListNode(4)
                {
                    Next = new ListNode(3)
                }
            }, new ListNode(5)
            {
                Next = new ListNode(6)
                {
                    Next = new ListNode(4)
                }
            });

            var result2 = AddTwoNumbers(new ListNode(0), new ListNode(0));

            var result3 = AddTwoNumbers(new ListNode(9)
            {
                Next = new ListNode(9)
                {
                    Next = new ListNode(9)
                    {
                        Next = new ListNode(9)
                        {
                            Next = new ListNode(9)
                            {
                                Next = new ListNode(9)
                                {
                                    Next = new ListNode(9)
                                }
                            }
                        }
                    }
                }
            }, new ListNode(9)
            {
                Next = new ListNode(9)
                {
                    Next = new ListNode(9)
                    {
                        Next = new ListNode(9)
                    }
                }
            });
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var head = new ListNode();
            var result = head;
            var carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                var sum = (l1?.Val ?? 0) + (l2?.Val ?? 0) + carry;
                result.Next = new ListNode(sum % 10);
                carry = sum / 10;
                l1 = l1 != null ? l1.Next : l1;
                l2 = l2 == null ? l2 : l2.Next;
                result = result.Next;
            }

            return head.Next;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }
    }
}
