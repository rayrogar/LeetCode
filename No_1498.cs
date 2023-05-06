namespace LeetCode
{
    public class No_1498
    {
        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);
            int mod = 1000000007;

            int[] sq = new int[nums.Length];
            sq[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                sq[i] = (sq[i - 1] * 2) % mod;

            }

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] * 2 > target)
                    break;
                for (int j = nums.Length - 1; j >= i; j--)
                {
                    if (nums[i] + nums[j] <= target)
                    {

                        sum = (sum + sq[j - i]) % mod;
                        break;
                    }
                }
            }

            return sum;
        }

        public int NumSubseq1(int[] nums, int target)
        {
            Array.Sort(nums);
            int mod = 1000000007;

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; j >= i; j--)
                {
                    if (nums[i] + nums[j] <= target)
                    {

                        sum += (int)((Math.Pow(2, (j - i) + 1) / 2) % mod);
                        break;
                    }
                }
            }

            return sum;
        }
    }
}