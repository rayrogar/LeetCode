using System.ComponentModel.DataAnnotations;
using System.Formats.Tar;

namespace LeetCode
{
    /**
     *
     * Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.

        There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed). It is -1 if there is no cycle. Note that pos is not passed as a parameter.

        Do not modify the linked list.
     *
     * Input: head = [3,2,0,-4], pos = 1
     * Output: true
     * Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
     *
     * Input: head = [1,2], pos = 0
     * Output: true
     * Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
     *
     *
     * Input: head = [1], pos = -1
     * Output: false
     * Explanation: There is no cycle in the linked list.
     *
     * Constraints:
     *
     * The number of the nodes in the list is in the range [0, 104].
     * -105 <= Node.val <= 105
     * pos is -1 or a valid index in the linked-list.
     *
     *
     * Follow up: Can you solve it using O(1) (i.e. constant) memory?
     * 
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) {
     *         val = x;
     *         next = null;
     *     }
     * }
     */
    public class No_142
    {

        public ListNode? DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return null;
            
            ListNode f = head.next;

            if (head == f)
                return head;

            while ( f.next != null && f.next.next != null)
            {
                head = head.next;
                if(f.next==head) return head;
                
                if(f.next.next==head)
                    return f.next;
                f = f.next.next;

            }
            return null;

        }

        public ListNode? DetectCycle2(ListNode head)
        {
            if (head == null || head.next == null)
                return null;

            ListNode f = head.next;

            if (head == f)
                return head;

            List<ListNode> index = new List<ListNode>();
            index.Add(head);
            while (f.next != null && f.next.next != null)
            {
                if (index.Contains(f.next)) return f.next;
                f = f.next.next;
                if (index.Contains(f))
                    return f;
                head = head.next;
                if (index.Contains(head))
                    return head;
                index.Add(head);
            }
            return null;

        }


        /// <summary>
        /// Devuelve la posicion;
        /// </summary>
        public int  DetectCycle1(ListNode head)
        {
            
            if (head == null || head.next == null)
                return -1;
            ListNode f = head.next;

            if (head == f)
                return 0;

            List<ListNode> index = new List<ListNode>();
            index.Add(head);

            while (f.next != null && f.next.next != null)
            {
                f = f.next.next;
                if(index.Contains(f))
                    return index.IndexOf(f);
                if(index.Contains(head.next))
                    return index.IndexOf(head.next);
                head = head.next;
            }
            return -1;
        }
    }
}