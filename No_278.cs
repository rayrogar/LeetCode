namespace LeetCode
{
    public class No_278 : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int i = 0, d = n;
            while (i <= d)
            {
                int m = i + (d - i) / 2;
                if (IsBadVersion(m))
                    d = m - 1;
                else
                    i = m + 1;
            }
            return i;
        }
    }

    public partial class VersionControl
    {
        public static bool IsBadVersion(int n)
        {
            return true;
        }
    }
}