namespace LeetCode
{
    public class No_53
    {

        /// <summary>
        /// O(n/2) Divide and Conquer
        /// </summary>
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            if (nums.Length > 1)
            {

                int m = nums.Length % 2 == 0 ? nums.Length / 2 : nums.Length / 2 + 1, prev = 0;

                int[] ansArray = new int[m];



                for (int i = m - 1; i > 0; i--)
                {
                    int a = nums[i] + (m < nums.Length ? nums[m] : 0), b = nums[i - 1] + ((m + (m - i)) < nums.Length ? nums[m + (m - i)] : 0);

                    ansArray[i] = Math.Max((a + b), b + prev);
                    prev = ansArray[i];
                    max = Math.Max(prev, max);
                    m++;
                }

            }
            return max;
        }



        /// <summary>
        /// O(n) Runtime: 204ms Beats: 59.7%, Memory: 51.1mb Beats: 5.87%
        /// </summary>
        public int MaxSubArray1(int[] nums)
        {

            int max = nums[0];

            if (nums.Length > 1)
            {
                int[] ansArray = new int[nums.Length + 1];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    ansArray[i + 1] = Math.Max(Math.Max(ansArray[i] + nums[i + 1], nums[i] + nums[i + 1]), nums[i + 1]);
                    max = Math.Max(ansArray[i + 1], max);

                }
            }

            return max;
        }



        /// <summary>
        /// O(n^2) Time Limit Exceded
        /// </summary>
        public int MaxSubArray2(int[] nums)
        {
            int max = nums[0];
            int[] ansArray = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                ansArray[i] = 0;
                for (int j = i + 1; j < ansArray.Length; j++)
                {
                    ansArray[j] = ansArray[j - 1] + nums[j - 1];
                    max = Math.Max(ansArray[j], max);

                }
            }
            return max;
        }
    }
}