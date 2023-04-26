namespace LeetCode
{
    public class No_258{
        public int AddDigits(int num)
        {
            if (num == 0)
                return 0;
            return num % 9 == 0 ? 9 : num % 9;
        }
    }
}