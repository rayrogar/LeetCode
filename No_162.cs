using System.Security.AccessControl;

namespace LeetCode
{
    class No_162
    {
        public int FindPeakElement(int[] nums)
        {
            return VerifyPos(nums, 0,nums.Length-1);
        }

        private int VerifyPos(int[] nums, int i, int e)
        {
            int m = i + (e - i) / 2;

            if (m == 0)
            {
                if (m == nums.Length - 1 || nums[m] > nums[m + 1])
                    return 0;
            }

            else if (m == nums.Length - 1 && nums[m] > nums[m - 1])
                return m;

            else if (m != nums.Length - 1 && nums[m] > nums[m - 1] && nums[m] > nums[m + 1])
                return m;

            var left = m != i ? VerifyPos(nums, i, m - 1) : -1;

            return left == -1 && m != e ? VerifyPos(nums, m + 1, e) : left;
        }
    }
}