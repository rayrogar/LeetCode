namespace LeetCode
{
    public class No_206
    {
        public ListNode? ReverseList(ListNode head)
        {
            if (head ==null || head.next == null)
                return head;
            ListNode p = new ListNode(int.MinValue), p1 = new ListNode(int.MinValue, head);

            while (head.next != null)
            {
                p.next = head.next;
                head.next = head.next.next;
                p.next.next = p1.next;
                p1.next = p.next;
            }

            return p.next;
        }
    }
}