namespace LeetCode
{
    class No_199
    {
        public IList<int> RightSideView(TreeNode root)
        {

            List<int> output = new List<int>();
            if (root != null)

            {
                Queue<TreeNode> tree = new Queue<TreeNode>();
                tree.Enqueue(root);
                int length = 1;

                while (length != 0)
                {
                    TreeNode cur = tree.Dequeue();

                    if (cur.left != null)
                    {
                        tree.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        tree.Enqueue(cur.right);
                    }

                    if (--length == 0)
                    {
                        output.Add(cur.val);
                        length = tree.Count;
                    }
                }
            }
            return output;
        }
    }
}