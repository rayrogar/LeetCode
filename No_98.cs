using System.Collections;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class No_98
    {
        public bool IsValidBST(TreeNode root)
        {
            List<int> treeorder = new List<int>();
            treeorder = TreetoList(root);
            for (int i = 0; i < treeorder.Count - 1; i++)
                if (treeorder[i] > treeorder[i + 1])
                    return false;
            return true;
        }

        private List<int> TreetoList(TreeNode root)
        {
            List<int> ans = new List<int>();
            if (root.left != null)
                ans.AddRange(TreetoList(root.left));
            ans.Add(root.val);
            if (root.right != null)
                ans.AddRange(TreetoList(root.right));
            return ans;
        }

        /// <summary>
        /// Good Answer, but Out of memory!!!!
        /// </summary>
        public bool IsValidBST1(TreeNode root)
        {
            int last = int.MinValue;
            Stack<TreeNode> tree = new Stack<TreeNode>();
            tree.Push(root);

            while (tree.Count != 0)
            {
                TreeNode c = tree.Pop();
                if (c.right != null)
                    tree.Push(c.right);
                if (c.left != null)
                {
                    tree.Push(c);
                    tree.Push(c.left);
                }
                else
                {
                    if (last <= c.val)
                    {
                        last = c.val;
                        if (tree.Count != 0 && tree.Peek().val >= last)
                            last = tree.Pop().val;
                    }
                    else
                        return false;
                }
            }
            return true;
        }
    }
}