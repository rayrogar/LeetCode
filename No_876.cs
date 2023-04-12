/*

Given the head of a singly linked list, return the middle node of the linked list.
If there are two middle nodes, return the second middle node.

Example 1:
    Input: head = [1,2,3,4,5]
    Output: [3,4,5]
    Explanation: The middle node of the list is node 3.

Example 2:
    Input: head = [1,2,3,4,5,6]
    Output: [4,5,6]
    Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.

Constraints:

    The number of nodes in the list is in the range [1, 100].
    1 <= Node.val <= 100

========================Definition for singly-linked list.================================================

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
     }
  }
*/

using System.Runtime.InteropServices;

namespace LeetCode
{
    public class No_876{
        public No_876() {

            Console.WriteLine("Given the head of a singly linked list, return the middle node of the linked list.");
            Console.WriteLine("If there are two middle nodes, return the second middle node.");
            Console.WriteLine("");
            Console.WriteLine("Example 1:");
            Console.WriteLine("Input: head = [1,2,3,4,5]");
            Console.WriteLine("Output: [3,4,5]");
            Console.WriteLine("Explanation: The middle node of the list is node 3.");
            casoEstudio(5);

            //===================================================////========================================================///
            Console.WriteLine("Example 2:");
            Console.WriteLine("Input: head = [1,2,3,4,5,6]");
            Console.WriteLine("Output: [4,5,6]");
            Console.WriteLine("Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.");
            casoEstudio(6);

            Console.ReadKey();



        }
        public ListNode MiddleNode(ListNode head)
        {
            List<ListNode> split = new List<ListNode>();
            while (head !=null)
            {
                split.Add(head);
                head = head.next;
            }
            Console.WriteLine(split.Count);
            return split[split.Count / 2];
        }

        public void casoEstudio(int cant)
        {

            ListNode head = new ListNode(cant, null);
            while (cant > 1)
            {
                cant--;
                ListNode temp = new ListNode(cant, head);
                head = temp;
            }
            ListNode salida = MiddleNode(head);

            string cadena = "";
            do
            {
                cadena += (salida.next != null) ? salida.val + "," : salida.val;
                salida = salida.next;
            }
            while (salida != null);
            Console.WriteLine(cadena);

        }

    }

    public partial class ListNode{
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}