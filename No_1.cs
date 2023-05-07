using System.Collections;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices.Marshalling;

namespace LeetCode
{
    public class No_1
    {
        /// <summary>
        /// Runtime: 168ms Beats: 51.92%, Memory: 44.5mb Beats: 28.84%
        /// </summary>
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> map = new List<int>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                var ans = target - nums[i];
                if (map.Contains(ans))
                    return new int[] { i, map.IndexOf(ans) };
                else map.Add(nums[i]);
            }
            return new int[] { 0, 0 };

        }

        /// <summary>
        /// Runtime: 175ms Beats: 42.21%, Memory: 44.5mb Beats: 35.15%
        /// </summary>
        public int[] TwoSum1(int[] nums, int target)
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