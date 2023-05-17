namespace LeetCode
{
    public class No_700
    {
        public TreeNode? SearchBST(TreeNode root, int val)
        {
            while (root.left != null || root.right != null)
            {
                if (root.val == val)
                    return root;
                if (root.val > val && root.left != null)
                    root = root.left;
                else
                    root = root.right;
            }
            return null;
        }
    }
}