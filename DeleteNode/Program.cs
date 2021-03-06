﻿namespace DeleteNode
{
    /*
     * 237. Delete Node in a Linked List
     * https://leetcode.com/problems/delete-node-in-a-linked-list/description/
     */
    class Program
    {
        /*
         * Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.
         * Given linked list -- head = [4,5,1,9], which looks like following:
         * 4 -> 5 -> 1 -> 9
         *
         * Example 1:
         * Input: head = [4,5,1,9], node = 5
         * Output: [4,1,9]
         * Explanation:
         * You are given the second node with value 5, the linked list should become 4 -> 1 -> 9 after calling your function.
         *
         * Example 2:
         * Input: head = [4,5,1,9], node = 1
         * Output: [4,5,9]
         * Explanation:
         * You are given the third node with value 1, the linked list should become 4 -> 5 -> 9 after calling your function.
         *
         * Note:
         * The linked list will have at least two elements.
         * All of the nodes' values will be unique.
         * The given node will not be the tail and it will always be a valid node of the linked list.
         * Do not return anything from your function.
         *
         */
        static void Main(string[] args)
        {
            DeleteNode(new ListNode(4) { Next = new ListNode(5) { Next = new ListNode(1) { Next = new ListNode(9) } } });
        }

        public static void DeleteNode(ListNode node)
        {
            node.Val = node.Next.Val;
            node.Next = node.Next.Next;
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
