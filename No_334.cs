namespace LeetCode
{
    public class No_334
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int min = nums[0], max = int.MaxValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                { min = nums[i]; }
                else if (nums[i] < max && nums[i] != min)
                { max = nums[i]; }
                else if (nums[i] > max)
                    return true;
            }
            return false;
        }
    }


}