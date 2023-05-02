namespace LeetCode
{
    public class No_61
    {
        public ListNode? RotateRight(ListNode? head, int k)
        {
            if (head == null)
                return null;

            ListNode? p = new ListNode(-1, head), s = new ListNode(-1, head);
            int mov = 1;

            //Look in for the end of the list
            while (p.next.next != null)
            {
                if (p.next.next.next != null)
                {
                    p.next = p.next.next.next;
                    mov += 2;
                }
                else
                {
                    p.next = p.next.next;
                    mov += 1;
                }
            }

            k = k % mov;
            mov -= k;

            while (mov-- > 0)
            {
                p.next.next = s.next;
                s.next = s.next.next;
                p.next = p.next.next;
                p.next.next = null;
            }


            return s.next;
        }
    }
}