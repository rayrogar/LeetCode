
namespace LeetCode
{
    public class No_24
    {
        public ListNode? SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode? s = new ListNode(-1, head), f = new ListNode(-1, head.next),
            new_head = new ListNode(-1, head.next);
            s.next.next = f.next.next;
            f.next.next = s.next;
            f.next = s.next.next;

            while (f.next != null && f.next.next != null)
            {
                s.next.next = f.next.next;
                f.next.next = s.next.next.next;
                s.next.next.next = f.next;
                s.next = f.next;
                f.next = f.next.next;
            }
            return new_head.next;
        }
    }
}