namespace LeetCode
{
    #pragma warning disable
    public class No_703
    {
        //List<int> arr = new List<int>();
        PriorityQueue<int, int> arr = new PriorityQueue<int, int>();
        int _k = 0;
        public void KthLargest(int k, int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                arr.Enqueue(nums[i], nums[i]);
            }
            while (k < arr.Count)
            {
                arr.Dequeue();
            }
        }
        /// <summary>
        /// Runtime: 2457ms Beats: 5.4%, Memory: 59.7mb Beats: 8.14%
        /// </summary>
        public int Add(int val)
        {
            arr.EnqueueDequeue(val, val);
            return arr.Peek();
        }
    }

/// <summary>
/// Second Implementation a few mounth later
/// Runtime: 123ms Beats: 97.28%, Memory: 60.9mb Beats: 15.76%
/// </summary>
    public class KthLargest
    {
        PriorityQueue<int, int> arr;
        int Kcount = 0;

        public KthLargest(int k, int[] nums)
        {
            arr = new PriorityQueue<int, int>();
            Kcount = k;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < k)
                    arr.Enqueue(nums[i], nums[i]);
                else
                    arr.EnqueueDequeue(nums[i], nums[i]);
            }
        }

        public int Add(int val)
        {
            if (arr.Count < Kcount)
                arr.Enqueue(val, val);
            else
                arr.EnqueueDequeue(val, val);
            return arr.Peek();

        }
    }
}