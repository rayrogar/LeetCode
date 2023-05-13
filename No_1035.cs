using System.Globalization;

namespace LeetCode
{
    public class No_1035
    {
        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            int n = nums1.Length + 1, m = nums2.Length + 1;
            int[] rec = new int[m], rec1 = new int[m];


            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    rec1[j] = nums1[i - 1] == nums2[j - 1] ? 1 + rec[j - 1] : Math.Max(rec1[j - 1], rec[j]);
                }
                rec1.CopyTo(rec, 0);
            }
            return rec1[m - 1];
        }
        public int MaxUncrossedLines1(int[] nums1, int[] nums2)
        {
            int n = nums1.Length, m = nums2.Length;
            int[,] rec = new int[n + 1, m + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    rec[i, j] = nums1[i - 1] == nums2[j - 1] ? 1 + rec[i - 1, j - 1] : Math.Max(rec[i, j - 1], rec[i - 1, j]);
                }
            }
            return rec[n, m];
        }
    }
}