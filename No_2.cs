using System.Formats.Asn1;

namespace LeetCode
{
    public class No_2
    {
        /// <summary>
        /// Runtime: 103ms Beats: 38.84%, Memory: 49.1mb Beats: 80.53%
        /// </summary>
        public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
        {
            if (l1 == null || l2 == null)
                if (l1 == null)
                    return l2;
                else return l1;

            ListNode ans = new ListNode(-1, l1), p = new ListNode(-1, ans);
            int m = 0;

            while (l1 != null || l2 != null)
            {

                int r = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + m;
                m = (int)r / 10;

                p.next.next.val = r % 10;
                p.next = p.next.next;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;

                if (l1 != null)
                    p.next.next = l1;
                else if (l2 != null)
                    p.next.next = l2;

            }

            if (m != 0)
                p.next.next = new ListNode(m);

            return ans.next;
        }
        /// <summary>
        /// Runtime: 124ms Beats: 5.33%, 49.5mb Beats: 31.14%
        /// </summary>
        public ListNode? AddTwoNumbers1(ListNode? l1, ListNode? l2)
        {
            if (l1 == null || l2 == null)
                if (l1 == null)
                    return l2;
                else return l1;

            ListNode ans = new ListNode(1), p = new ListNode(-1, ans);
            int m = 0;

            while (l1 != null || l2 != null)
            {

                int r = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + m;
                m = (int)r / 10;

                p.next.next = new ListNode(r % 10);
                p.next = p.next.next;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;

            }

            if (m != 0)
                p.next.next = new ListNode(m);

            return ans.next;
        }


    }
}