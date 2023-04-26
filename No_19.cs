using System.Net.Http.Headers;

namespace LeetCode
{
    public class No_19
    {
        public ListNode? RemoveNthFromEnd(ListNode head, int n)
        {

            if (head.next == null)
                return null;

            int c = 1;
            ListNode p = head;
            while (p.next != null)
            {
                c++;
                p = p.next;

            }
            if (c != n)
            {
                p = head;
                for (int i = 1; i < c - n; i++)
                    p = p.next;

                p.next = p.next.next;
                return head;
            }
            return head.next;

        }
    }
}