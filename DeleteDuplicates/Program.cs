namespace DeleteDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DeleteDuplicates(new ListNode(1) { Next = new ListNode(1) { Next = new ListNode(1) } });
            var result2 = DeleteDuplicates(new ListNode(1) { Next = new ListNode(1) { Next = new ListNode(2) { Next = new ListNode(3) { Next = new ListNode(3) } } } });
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            var currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Next != null && currentNode.Val == currentNode.Next.Val)
                {
                    currentNode.Next = currentNode.Next.Next;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }

            return head;
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
