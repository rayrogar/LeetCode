namespace LeetCode
{
    using LeetCode1;
    public class No_430
    {
        public LeetCode1.Node? Flatten(LeetCode1.Node head)
        {
            if (head == null)
                return null;
            LeetCode1.Node? ans = head, next = null;

            while (ans != null && (ans.next != null || ans.child != null))
            {
                if (ans.child != null)
                {
                    next = ans.next;
                    ans.next = Flatten(ans.child);
                    ans.child = null;
                    ans.next.prev = ans;

                    while (ans.next != null)
                        ans = ans.next;

                    if (next != null)
                    {
                        next.prev = ans;
                        ans.next = next;
                    }
                }

                ans = ans.next;

            }

            return head;
        }
    }
}

namespace LeetCode1
{

    public class Node
    {
        public int val;
        public Node? prev;
        public Node? next;
        public Node? child;
    }

}