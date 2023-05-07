namespace LeetCode
{
    public class No_350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> ans = new List<int>();
            int p = -1;

            if (nums1.Length <= nums2.Length)
            {
                for (int i = 0; i < nums1.Length; i++)
                    for (int j = p + 1; j < nums2.Length; j++)
                    {
                        if (nums2[j] == nums1[i])
                        {
                            ans.Add(nums1[i]);
                            p = j;
                            break;
                        }
                    }
            }
            else
            {
                for (int i = 0; i < nums2.Length; i++)
                    for (int j = p + 1; j < nums1.Length; j++)
                    {
                        if (nums2[i] == nums1[j])
                        {
                            ans.Add(nums2[i]);
                            p = j;
                            break;
                        }
                    }
            }
            return ans.ToArray();

        }
    }
}