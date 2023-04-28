namespace LeetCode
{
    public class No_203
    {
        public ListNode? RemoveElements2(ListNode head, int val)
        {
            if (head == null)
                return null;

            ListNode? s = head;
            ListNode? f = head.next;

            while (s != null)
            {
                if (head.val == val && head.next == null)
                    return null;
                else if (head.val == val)
                {
                    head = head.next;
                    s = head;
                }
                else if (s != null)
                {
                    if (s.next != null && s.next.val == val)
                        s.next = s.next.next;
                    else s = s.next;
                }


                if (f != null)
                {
                    if (f.next != null && f.next.val == val)
                    {
                        f.next = f.next.next;
                        //f = f.next.next;
                    }
                    else
                        f = f.next.next;

                }
            }

            return head;

        }

        public ListNode RemoveElements1(ListNode head, int val)
        {
            if (head == null)
                return null;

            ListNode? f = head.next;

            while (head != null && head.val == val)
            {
                if (head.next != null)
                    head = head.next;
                else return null;

                if (f != null)
                {
                    if (f.next != null && f.next.val == val)
                        f.next = f.next.next;
                    else if (f.next != null)
                        f = f.next.next;

                }
            }

            ListNode? s = head;


            while (s != null && s.next != null)
            {
                if (s.next.val == val)
                    s.next = s.next.next;
                else s = s.next;

                if (f != null)
                {
                    if (f.next != null && f.next.val == val)
                        f.next = f.next.next;
                    else if (f.next != null)
                        f = f.next.next;

                }
            }

            return head;

        }
    }
}