namespace LeetCode
{
    class No_1493
    {
        public int LongestSubarray(int[] nums)
        {
            if (nums.Sum() == nums.Length)
                return nums.Length - 1;
            int r = 1, wi = 0, we = wi, w = 0, w1 = 0;

            while (we < nums.Length)
            {
                if (nums[we] == 1)
                {
                    w1++;
                    we++;
                }
                else if (r > 0)
                {
                    r--;
                    we++;
                }
                else
                {
                    w = Math.Max(w, w1);
                    while (wi < we && r == 0)
                    {
                        if (nums[wi] == 0)
                            r++;
                        else
                            w1--;
                        wi++;
                    }
                }
            }
            return Math.Max(w, w1);
        }
    }
}