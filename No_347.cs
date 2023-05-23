using System.Diagnostics.Metrics;

namespace LeetCode
{
    public class No_347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> rec = new Dictionary<int, int>();
            PriorityQueue<int, int> q = new PriorityQueue<int, int>();
            int[] ans = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                if (rec.ContainsKey(nums[i]))
                    rec[nums[i]]++;
                else rec[nums[i]] = 1;
            }

            foreach (var item in rec)
                q.Enqueue(item.Key, item.Value);

            while (q.Count > k)
                q.Dequeue();

            for (int i = ans.Length - 1; i >= 0; i--)
                ans[i] = q.Dequeue();

            return ans;

            /*
            LINQ Solution
            return nums.GroupBy(x => x).OrderByDescending(y => y.Count()).Take(k).Select(z => z.Key).ToArray();
            */
        }
    }
}