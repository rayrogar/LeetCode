namespace LeetCode
{
    public class No_234
    {
        /// <summary>
        /// Runtime: 260ms Beats: 21.39%, Memory: 62.3mb Beats: 19.60%
        /// </summary>
        public bool IsPalindrome(ListNode head)
        {
            List<int> copy = new List<int>();

            while (head != null)
            {
                copy.Add(head.val);
                head = head.next;
            }


            for (int i = 0; i < copy.Count / 2; i++)
            {
                if (copy[i] != copy[copy.Count - i - 1])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Readtime: 239ms Beats: 77.23%, Memory: 62mb Beats: 52.87%
        /// </summary>
        public bool IsPalindrome1(ListNode head)
        {

            if (head == null || head.next == null)
                return true;

            //Find the middle
            ListNode s = head, f = head;
            while (f.next != null && f.next.next != null)
            {
                s = s.next;
                f = f.next.next;
            }

            //Reverse the second half
            ListNode t = new ListNode(0, s.next), t1 = new ListNode(0, s.next);
            while (t.next.next != null)
            {
                s.next = t.next.next;
                t.next.next = t.next.next.next;
                s.next.next = t1.next;
                t1.next = s.next;
            }

            //check first half with second half
            while (t1.next != null)
            {
                if (head.val != t1.next.val)
                    return false;
                head = head.next;
                t1.next = t1.next.next;
            }
            return true;
        }
    }
}