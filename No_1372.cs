namespace LeetCode
{
    class No_1372
    {
        public int LongestZigZag(TreeNode root)
        {

            Queue<TreeNode?> tree = new Queue<TreeNode?>();
            tree.Enqueue(root);
            Dictionary<(TreeNode?, bool), int> map = new Dictionary<(TreeNode?, bool), int>();

            int output = 0;
            while (tree.Count != 0)
            {

                TreeNode? cur = tree.Dequeue();

                output = Math.Max(output,
                Math.Max(map.ContainsKey((cur, true)) ? map[(cur, true)] : DFS(cur, true, 0, map),
                map.ContainsKey((cur, false)) ? map[(cur, false)] : DFS(cur, false, 0, map)));

                if (cur != null)
                {
                    tree.Enqueue(cur.left);
                    tree.Enqueue(cur.right);
                }

            }

            return output;
        }

        public int DFS(TreeNode? root, bool dir, int count, Dictionary<(TreeNode?, bool), int> map)
        {

            if (root == null)
                return 0;

            if (dir && root.right != null)
            {
                if (!map.ContainsKey((root.right, !dir)))
                    map[(root.right, !dir)] = DFS(root.right, !dir, ++count, map);
                return map[(root.right, !dir)];
            }

            if (!dir && root.left != null)
            {
                if (!map.ContainsKey((root.left, !dir)))
                    map[(root.left, !dir)] = DFS(root.left, !dir, ++count, map);
                return map[(root.left, !dir)];
            }
            return count;

        }
    }
}