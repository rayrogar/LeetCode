using System.Runtime.InteropServices;

namespace LeetCode
{
    public class No_21
    {
        /// <summary>
        /// Runtime: 90ms Beats: 43.6%, Memory: 40mb Beats: 12.30%
        /// </summary>
        public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            if (list1 == null || list2 == null)
                if (list1 == null) return list2;
                else
                    return list1;

            ListNode? head = new ListNode(-1), merger = new ListNode(-1, head);

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    merger.next.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    merger.next.next = list2;
                    list2 = list2.next;
                }

                merger.next = merger.next.next;

            }

            if (list1 == null)
            {
                merger.next.next = list2;
            }
            else if (list2 == null)
            {
                merger.next.next = list1;
            }

            return head.next;
        }
    }
}