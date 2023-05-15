namespace LeetCode
{
    public class No_704
    {
        public int Search(int[] nums, int target)
        {
            int i = 0, d = nums.Length - 1;
            while (i < d)
            {
                int m = i + (d - i) / 2;
                if (nums[m] == target)
                    return m;
                if (nums[m] > target)
                    d = m - 1;
                else
                    i = m + 1;
            }
            return nums[i] == target ? i : -1;
        }
    }
}