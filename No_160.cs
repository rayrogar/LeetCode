using System.Reflection.Metadata.Ecma335;

namespace LeetCode
{/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public ListNode? GetIntersectionNode(ListNode headA, ListNode headB)
        {
            List<ListNode> mem = new List<ListNode>();
            while (headA != null || headB != null){
                if(headA==headB)
                    return headA;
                if(mem.Contains(headA))
                    return headA;
                    else if(headA!=null){
                        mem.Add(headA);
                    headA = headA.next;
                }
                if(mem.Contains(headB))
                    return headB;
                    else if(headB!=null){
                        mem.Add(headB);
                        headB = headB.next;
                    }
            }
            return null;
        }
        /// <summary>
        /// RUNTIME: 1488ms BEATS: 5.4%, MEMORY: 52.3MB BEATS: 22.61%
        /// </summary>
        public ListNode? GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            List<ListNode> mem = new List<ListNode>();
            while (headA != null || headB != null)
            {
                while (headA != null)
                {
                    mem.Add(headA);
                    headA = headA.next;
                }
                while (headB != null)
                {
                    if (mem.Contains(headB))
                    return headB;
                    headB = headB.next;
                }
            }
            return null;
        }
        /// <summary>
        /// RUNTIME: 118ms BEATS: 68.70%, MEMORY: 51.2MB BEATS: 93.91%
        /// </summary>
        public ListNode? GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> mem = new HashSet<ListNode>();
            while (headA != null)
            {
                mem.Add(headA);
                headA = headA.next;

            }

            while (headB != null)
            {
                if (!mem.Add(headB))
                    return headB;
                headB = headB.next;
            }
            return null;
        }
    }
}