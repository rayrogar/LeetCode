namespace LeetCode
{
    class No_198
    {
        public int Rob(int[] nums)
        {

            int[] output = new int[nums.Length];
            nums.CopyTo(output, 0);

            for (int i = 2; i < nums.Length; i++)
                output[i] = Math.Max(output[i - 2], output[i - 1] - nums[i - 1]) + nums[i];

            return output.Max();
        }
    }
}