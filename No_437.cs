namespace LeetCode
{
    class No_437
    {
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return 0;

            int output = 0;
            Queue<TreeNode> tree = new Queue<TreeNode>();
            tree.Enqueue(root);

            while (tree.Count != 0)
            {
                var cur = tree.Dequeue();
                output += DFS(cur, targetSum, 0);

                if (cur.left != null)
                    tree.Enqueue(cur.left);

                if (cur.right != null)
                    tree.Enqueue(cur.right);
            }
            return output;
        }

        public int DFS(TreeNode root, int targetSum, long actSum)
        {
            int count = 0;
            if (root.val + actSum == targetSum)
                count++;

            if (root.left != null)
                count += DFS(root.left, targetSum, root.val + actSum);

            if (root.right != null)
                count += DFS(root.right, targetSum, root.val + actSum);

            return count;
        }
    }
}