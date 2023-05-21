namespace LeetCode
{
    public class No_643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double ans = 0, average = 0;
            int i = 0;
            for (; i < k; i++)
            {
                average += nums[i];
            }
            ans = average / k;

            while (i < nums.Length)
            {
                Console.WriteLine(i + " " + average + " average: " + average / k + " " + ans);
                average += nums[i] - nums[i - k];
                ans = Math.Max(ans, average / k);
                i++;
            }

            return ans;
        }
    }
}