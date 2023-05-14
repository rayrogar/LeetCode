namespace LeetCode
{
    public class No_509
    {
        public int Fib(int n)
        {
            int f = 0, f1 = 1;
            if (n == 0) return 0;
            if (n == 1) return 1;
            for (int i = 2; i < n; i++)
            {
                var t = f + f1;
                f = f1;
                f1 = t;
            }
            return f1;
        }
    }
}