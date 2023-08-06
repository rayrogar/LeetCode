
using System.Text.Json;

namespace LeetCode
{
    class No_450
    {
        public TreeNode? DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return root;
            Queue<TreeNode> tree = new Queue<TreeNode>();
            TreeNode output = new TreeNode(0, root);
            tree.Enqueue(output);

            while (tree.Count != 0)
            {
                TreeNode p = tree.Dequeue();

                if (p.left != null && p.left.val == key)
                {
                    if (p.left.right != null && p.left.left != null)
                    {
                        var p1 = p.left.right;
                        while (p1.left != null)
                            p1 = p1.left;
                        p1.left = p.left.left;
                        p.left = p.left.right;
                    }
                    else if (p.left.right != null)
                        p.left = p.left.right;
                    else if (p.left.left != null)
                        p.left = p.left.left;
                    else p.left = null;

                    GC.Collect();
                    break;
                }
                else if (p.right != null && p.right.val == key)
                {
                    if (p.right.right != null && p.right.left != null)
                    {
                        var p1 = p.right.right;
                        while (p1.left != null)
                            p1 = p1.left;
                        p1.left = p.right.left;
                        p.right = p.right.right;
                    }
                    else if (p.right.left != null)
                        p.right = p.right.left;
                    else if (p.right.right != null)
                        p.right = p.right.right;
                    else p.right = null;

                    GC.Collect();
                    break;
                }
                else
                {
                    if (p.left != null)
                        tree.Enqueue(p.left);
                    if (p.right != null)
                        tree.Enqueue(p.right);
                }

            }

            return output.left;
        }
    }
}