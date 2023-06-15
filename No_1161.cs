namespace LeetCode
{
    public class No_1161
    {
        public int MaxLevelSum(TreeNode root)
        {
            int max = int.MinValue, actMax = 0, level = 1, actLevel = 1, numsChields = 1, nextChields = 0;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                TreeNode cur = q.Dequeue();
                actMax += cur.val;

                if (cur.left != null)
                {
                    nextChields++;
                    q.Enqueue(cur.left);
                }
                if (cur.right != null)
                {
                    nextChields++;
                    q.Enqueue(cur.right);
                }
                numsChields--;
                if (numsChields == 0)
                {
                    if (actMax > max)
                    {
                        level = actLevel;
                        max = actMax;
                    }
                    actMax = 0;
                    numsChields = nextChields;
                    nextChields = 0;
                    actLevel++;
                }
            }

            return level;
        }
    }
}