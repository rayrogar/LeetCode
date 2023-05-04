using System.Drawing;

namespace LeetCode
{
    public class No_724
    {
        /// <summary>
        /// Runtime: 1279 ms Beats: 5.5%, Memory: 45.8mb Beats: 61%
        /// </summary>
        public int PivotIndex1(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int a = 0, b = nums.Length - 1, dif = 0;
                while (a != i || b != i)
                {
                    dif += (a != i ? nums[a++] : 0) - (b != i ? nums[b--] : 0);
                }
                if (dif == 0)
                    return i;

            }
            return -1;
        }
    }
}