namespace LeetCode
{
    public class No_1721
    {
        public ListNode? SwapNodes(ListNode? head, int k)
        {
            if (head == null)
                return head;
            ListNode ka = new ListNode(-1), s = new ListNode(-1, head), f = new ListNode(-1, head);
            for (int i = 1; i < k; i++)
                f.next = f.next.next;
            ka.next = f.next;
            while (f.next.next != null)
            {
                f.next = f.next.next;
                s.next = s.next.next;
            }
            f.val = ka.next.val;
            ka.next.val = s.next.val;
            s.next.val = f.val;
            return head;
        }
    }
}