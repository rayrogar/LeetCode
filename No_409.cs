namespace LeetCode
{
    public class No_409
    {
        public int LongestPalindrome(string s)
        {
            char[] s_arr = s.ToCharArray();
            Dictionary<int, int> rec = new Dictionary<int, int>();

            for (int i = 0; i < s_arr.Length; i++)
                rec[s_arr[i]] = rec.ContainsKey(s_arr[i]) ? rec[s_arr[i]] + 1 : 1;
            bool odd = false;
            int ans = 0;
            foreach (var r in rec)
            {
                if (r.Value % 2 != 0)
                {
                    ans += r.Value - 1;
                    if (!odd)
                        odd = true;
                }
                else
                    ans += r.Value;
            }
            if (odd)
                ans++;

            return ans;
        }
    }
}