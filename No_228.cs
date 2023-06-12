namespace LeetCode
{
    public class No_228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> ans = new List<string>();
            int s = 0, e = 0;

            while (e < nums.Length)
            {

                if (e == nums.Length - 1 || nums[e + 1] != nums[e] + 1)
                {
                    ans.Add(e != s ? nums[s] + "->" + nums[e] : nums[s].ToString());
                    s = e = e + 1;
                }
                else
                    e++;
            }
            return ans;

        }
    }
}