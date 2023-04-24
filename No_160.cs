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

        public ListNode? GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            List<ListNode> memA = new List<ListNode>();
            List<ListNode> memB = new List<ListNode>();
            ListNode a, a1, b, b1;
            if (headA != null && headB != null)
            {
                a = headA;
                a1 = headA.next;
                b = headB;
                b1 = headB.next;

                while (a != null || b != null)
                {
                    if(a==b || a==b1 || memB.Contains(a))
                        return a;
                        else if(a1==b ||a1==b1 || memB.Contains(a1))
                            return a1;
                            else if(memA.Contains(b))
                                return b;
                                else if(memA.Contains(b1))
                                    return b1;
                                    else{
                                            if (a != null)
                                            {
                                                a = a.next;
                                                if (!memA.Contains(a)) 
                                                    memA.Add(a); 
                                            }

                                            if (b != null){
                                                b = b.next;
                                                if (!memB.Contains(b)) 
                                                memB.Add(b); 
                                            }
                                        }
                }
            }
            return null;
        }
    }
}