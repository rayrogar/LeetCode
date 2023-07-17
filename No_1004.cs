namespace LeetCode
{
    public class No_1004
    {
        public int LongestOnes(int[] nums, int k)
        {
            int c = 0, wi = 0, we = 0;

            while (wi <= we && we < nums.Length)
            {
                while (we < nums.Length && (nums[we] == 1 || k > 0))
                {
                    if (nums[we] == 0 && k > 0)
                        k--;
                    we++;
                }
                c = Math.Max(c, we - wi);
                while ((we < nums.Length && nums[we] != 1))
                {
                    if (we == wi)
                    {
                        we++;
                        wi++;
                    }
                    else
                    {
                        if (nums[wi] == 0 && k == 0)
                            k++;
                        wi++;
                    }
                    if (k > 0)
                        break;
                }
            }
            return Math.Max(c, we - wi);
        }
    }
}