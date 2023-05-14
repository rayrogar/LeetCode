namespace LeetCode
{
    public class No_102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> ans = new List<List<int>>();

            if (root == null)
                return ans.ToArray();
           
            Queue<TreeNode> next = new Queue<TreeNode>();
            next.Enqueue(root);

            while (next.Count != 0)
            {
                TreeNode[] n = new TreeNode[next.Count];
                next.CopyTo(n, 0);
                next.Clear();
                ans.Add(new List<int>());
                for (int i = 0; i < n.Length; i++)
                {
                    ans.Last().Add(n[i].val);
                    if (n[i].left != null)
                        next.Enqueue(n[i].left);
                    if (n[i].right != null)
                        next.Enqueue(n[i].right);
                }
            }
            return ans.ToArray();

        }
    }
}