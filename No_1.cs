namespace LeetCode
{
    public class No_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> val_i = new Dictionary<int, int>();
            int max_less = nums[0];

            for (int i = 0; i < nums.Length; i++)
                val_i[nums[i]] = i;



            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };

                }
            }
            return new int[] { 0, 0 };

        }
    }
}