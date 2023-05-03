namespace LeetCode
{
    public class No_2215
    {
        public IList<IList<int>>? FindDifference(int[] nums1, int[] nums2)
        {
            return new[] { nums1.Except(nums2).ToArray(), nums2.Except(nums1).ToArray() };

        }

        public IList<IList<int>>? FindDifference1(int[] nums1, int[] nums2)
        {
            HashSet<int> nums1hash = new HashSet<int>();
            HashSet<int> nums2hash = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
                nums1hash.Add(nums1[i]);

            for (int i = 0; i < nums2.Length; i++)
                nums2hash.Add(nums2[i]);

            return new[] { nums1hash.Except(nums2hash).ToList(), nums2hash.Except(nums1hash).ToList() };

        }
    }
}