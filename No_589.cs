namespace LeetCode
{
    public class No_589
    {
        public IList<int> Preorder(Node root)
        {
            if (root == null)
                return new int[] { };
            Stack<Node> tree = new Stack<Node>();
            List<int> s = new List<int>();
            tree.Push(root);
            while (tree.Count != 0)
            {
                Node n = tree.Pop();
                s.Add(n.val);
                for (int i = n.children.Count - 1; i >= 0; i--)
                    tree.Push(n.children[i]);

            }
            return s;
        }

        public partial class Node
        {
            public int val;
            public IList<Node>? children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}