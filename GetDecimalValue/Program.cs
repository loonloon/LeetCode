/*
 * 1290. Convert Binary Number in a Linked List to Integer
 * https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
 */
namespace GetDecimalValue
{
    class Program
    {
        /*
         * Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1.
         * The linked list holds the binary representation of a number.
         *
         * Return the decimal value of the number in the linked list.
         *
         * Example 1:
         * Input: head = [1,0,1]
         * Output: 5
         * Explanation: (101) in base 2 = (5) in base 10
         *
         * Example 2:
         * Input: head = [0]
         * Output: 0
         *
         * Example 3:
         * Input: head = [1]
         * Output: 1
         *
         * Example 4:
         * Input: head = [1,0,0,1,0,0,1,1,1,0,0,0,0,0,0]
         * Output: 18880
         *
         * Example 5:
         * Input: head = [0,0]
         * Output: 0
         *
         * Constraints:
         * The Linked List is not empty.
         * Number of nodes will not exceed 30.
         * Each node's value is either 0 or 1.
         *
         */
        static void Main(string[] args)
        {
            var result = GetDecimalValue(new ListNode(1, new ListNode(0, new ListNode(1))));
            var result2 = GetDecimalValue(new ListNode());
            var result3 = GetDecimalValue(new ListNode(1));
            var result4 = GetDecimalValue(new ListNode(1, new ListNode(0, new ListNode(0, new ListNode(1, new ListNode(0, new ListNode(0, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode())))))))))))))));
            var result5 = GetDecimalValue(new ListNode(0, new ListNode()));
        }

        public static int GetDecimalValue(ListNode head)
        {
            var answer = 0;

            while (head != null)
            {
                answer = (2 * answer) + head.Val;
                head = head.Next;
            }

            return answer;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int val = 0, ListNode next = null)
        {
            Val = val;
            Next = next;
        }
    }
}
