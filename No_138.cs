
using System.Data.Common;

namespace LeetCode
{
    public class No_138
    {
        public Node? CopyRandomList(Node? head)
        {
            if (head == null)
                return null;

            Dictionary<Node, Node> refer = new Dictionary<Node, Node>();
            Node? copy = new Node(head.val);
            Node? end = null;
            Node? p = copy;

            while (head != null)
            {
                if (head.next != null)
                {
                    if (refer.ContainsKey(head.next))
                        p.next = refer[head.next];
                    else
                    {
                        p.next = new Node(head.next.val);
                        //refer.Add(head.next, p.next);
                        refer[head.next] = p.next;
                    }
                }
                else
                    p.next = end;

                if (head.random != null && head.random != head)
                {
                    if (!refer.ContainsKey(head.random))
                    {
                        p.random = new Node(head.random.val);
                        //refer.Add(head.random, p.random);
                        refer[head.random] = p.random;
                    }
                    else p.random = refer[head.random];
                }
                else
                {
                    if (head.random == head)
                        p.random = p;
                    else p.random = end;


                }
                if (!refer.ContainsKey(head))
                    //refer.Add(head, p);
                    refer[head] = p;

                head = head?.next;
                p = p.next;
            }
            GC.Collect();

            return copy;
        }

    }
    public partial class Node
    {
        public int val;
        public Node? next;
        public Node? random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

}