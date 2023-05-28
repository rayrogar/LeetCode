namespace LeetCode
{
    public class No_152
    {
        /// <summary>
        /// Out of memory
        /// </summary>
        public int MaxProduct1(int[] nums)
        {
            int[][] rec = new int[nums.Length][];
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
                rec[i] = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                rec[i][i] = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (rec[i][j] == 0)
                    {
                        rec[i][j] = nums[i] * rec[i][j - 1];
                        rec[j][i] = rec[i][j];
                        max = Math.Max(max, rec[i][j]);
                    }
                }
                Console.WriteLine(string.Join(',', rec[i]));
            }
            return max;
        }

        public int MaxProduct(int[] nums)
        {
            int[] min = new int[nums.Length];
            int max = nums[0];
            min[0] = nums[0];
            //Console.WriteLine("i: {2}, Max: {0}, Min: {1}, max: {3}",min[0],nums[0],0,max);
            for (int i = 1; i < nums.Length; i++)
            {
                int a = min[i - 1] * nums[i], b = nums[i] * nums[i - 1];
                min[i] = Math.Min(nums[i], Math.Min(a, b));
                nums[i] = Math.Max(nums[i], Math.Max(a, b));
                max = Math.Max(max, nums[i]);
                //Console.WriteLine("i: {2}, Max: {0}, Min: {1}, max: {3}",nums[i],min[i],i,max);
            }
            GC.Collect();
            return max;
        }
    }
}