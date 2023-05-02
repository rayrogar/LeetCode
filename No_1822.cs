using System.Reflection.Metadata.Ecma335;

namespace LeetCode
{
    public class No_1822
    {

        public int ArraySign(int[] nums)
        {
            int c = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    return 0;
                if (nums[i] < 0)
                    c++;
            }
            return c % 2 == 0 ? 1 : -1;
        }

    }
}