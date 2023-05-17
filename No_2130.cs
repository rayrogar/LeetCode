namespace LeetCode
{
    public class No_2130
    {
        public int PairSum(ListNode head)
        {
            List<int> valNodes = new List<int>();
            int ans = 0;
            while (head != null)
            {
                valNodes.Add(head.val);
                head = head.next;
            }

            for (int i = 0; i < valNodes.Count / 2; i++)
            {
                int t = valNodes[i] + valNodes[valNodes.Count - i-1];
                if (t > ans)
                    ans = t;
            }
            return ans;
        }
    }
}