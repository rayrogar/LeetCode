namespace LeetCode{
    class No_1679
    {
        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            
            int s = 0, e = nums.Length - 1, c = 0;
            while (s < e)
            {
                int sum = nums[s] + nums[e];
                if (sum == k)
                {
                    c++;
                    s++;
                    e--;
                }
                else if (sum < k)
                    s++;
                else
                    e--;
            }

            return c;
        }
    }
}