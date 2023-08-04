namespace LeetCode
{
    class No_1448
    {
        public int GoodNodes(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return 1;
            return Dfs(root, 1);
        }

        public int Dfs(TreeNode root, int cont)
        {

            if (root.left != null)
            {
                if (root.left.val >= root.val)
                    cont++;
                else
                    root.left.val = root.val;
                if (root.left.left != null || root.left.right != null)
                    cont = Dfs(root.left, cont);
            }

            if (root.right != null)
            {

                if (root.right.val >= root.val)
                    cont++;
                else
                    root.right.val = root.val;
                if (root.right.left != null || root.right.right != null)
                    cont = Dfs(root.right, cont);
            }

            return cont;
        }
    }
}