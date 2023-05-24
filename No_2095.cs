namespace LeetCode
{
    public class No_2095
    {
        public ListNode? DeleteMiddle(ListNode head)
        {
            if (head.next == null)
                return null;
            if (head.next.next == null)
            {
                head.next = null;
                return head;
            }
            else
            {
                ListNode s = new ListNode(-1, head.next), f = new ListNode(-1, head.next), p = new ListNode(-1, head);

                while (f.next != null && f.next.next != null)
                {
                    s.next = s.next.next;
                    p.next = p.next.next;
                    f.next = f.next.next.next;
                }

                p.next.next = s.next.next;
                s.next.next = null;
                GC.Collect();
            }
            return head;
        }
    }
}