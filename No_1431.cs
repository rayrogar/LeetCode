namespace LeetCode
{
    public class No_1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            bool[] ans = new bool[candies.Length];
            for (int i = 0; i <= candies.Length / 2; i++)
            {
                ans[i] = candies[i] + extraCandies >= max;
                ans[candies.Length - i - 1] = candies[candies.Length - i - 1] + extraCandies >= max;
            }
            return ans;
        }
        /// <summary>
        /// Usando LINQ
        /// </summary>
        public IList<bool> KidsWithCandies1(int[] candies, int extraCandies)
        {
            var max = candies.Max() - extraCandies;
            return candies.Select(c => c >= max).ToList();
        }
    }
}