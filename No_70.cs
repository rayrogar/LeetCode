namespace LeetCode
{
    public class No_70
    {
        public int ClimbStairs(int n)
        {
            if (n < 4) return n;
            int ans = 0, a = 2, b = 3;

            for (int i = 4; i <= n; i++)
            {
                ans = a + b;
                a = b;
                b = ans;
            }
            return ans;
        }
    }
}