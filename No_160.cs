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
    }
}