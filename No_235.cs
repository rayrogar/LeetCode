using System.Timers;

namespace LeetCode
{
    public class No_235
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> next = new Stack<TreeNode>();
            next.Push(root);
            Stack<TreeNode> lowers = new Stack<TreeNode>();
            List<TreeNode> visited = new List<TreeNode>();
            bool h1 = false;

            while (next.Count != 0)
            {
                TreeNode cur = next.Peek();


                // if (lowers.Count != 0 && lowers.Peek() == cur)
                // {
                //     lowers.Pop();
                //     next.Pop();
                // }
                // else 
                if (visited.Remove(cur))
                    next.Pop();
                else
                {
                    if (!h1)
                        lowers.Push(cur);
                    else
                        visited.Add(cur);

                    if (cur == p || cur == q)
                    {
                        if (h1) return lowers.Pop();
                        h1 = true;
                    }
                    if (cur.left == null && cur.right == null)
                    {
                        next.Pop();
                        if (lowers.Count != 0 && lowers.Peek() == cur)
                            lowers.Pop();

                    }
                    else
                    {

                        if (cur.right != null)
                            next.Push(cur.right);

                        if (cur.left != null)
                            next.Push(cur.left);
                    }
                }
            }
            return lowers.Pop();
        }
        public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode lower = root;
            Stack<TreeNode> next = new Stack<TreeNode>();
            next.Push(root);
            Stack<TreeNode> lowers = new Stack<TreeNode>();
            List<TreeNode> visited = new List<TreeNode>();
            bool h1 = false;
            while (next.Count != 0)
            {
                TreeNode cur = next.Pop();

                if (visited.Remove(cur))
                {
                    lower = lowers.Pop();
                }
                else
                {
                    if (!h1)
                    {
                        lowers.Push(lower);
                        lower = cur;
                    }
                    if (cur == p || cur == q)
                    {
                        if (h1) return lower;
                        h1 = true;
                    }
                    next.Push(cur);

                    if (cur.right != null)
                        next.Push(cur.right);

                    if (cur.left != null)
                        next.Push(cur.left);

                    visited.Add(cur);
                }
            }
            return lower;
        }
    }
}