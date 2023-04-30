namespace LeetCode
{
    public class No_328
    {
        /// <summary>
        /// Runtime: 99ms Beats: 9.12%, Memory: 40.4mb Beats: 11.11%
        /// </summary>
        public ListNode? OddEvenList(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
                return head;

            ListNode odd = new ListNode(-1, head), even = new ListNode(0, head.next), lp = new ListNode(0, head.next);

            while (even.next != null && even.next.next != null)
            {
                odd.next.next = even.next.next;
                odd.next = odd.next.next;
                even.next.next = odd.next.next;
                even.next = even.next.next;
            }
            odd.next.next = lp.next;

            return head;

        }

        /// <summary>
        /// Runtime: 99ms, Beats: 9.12%, Memory: 40.1mb Beats: 23.8%
        /// </summary>
        public ListNode? OddEvenList1(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
                return head;

            ListNode odd = new ListNode(-1, head), even = new ListNode(0, head.next), lp = new ListNode(0, head.next);

            while (odd.next != null && even.next != null)
            {
                if (even.next.next != null)
                {
                    odd.next.next = even.next.next;
                    even.next.next = odd.next.next.next;
                    odd.next.next.next = lp.next;
                }

                odd.next = odd.next.next;
                even.next = even.next.next;

            }

            return head;

        }
    }
}