namespace LeetCode
{
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
}