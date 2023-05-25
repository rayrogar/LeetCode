namespace Name
{
    public class No_1768
    {
        public string MergeAlternately(string word1, string word2)
        {
            int i = 0;
            string ans = "";
            while (i < word1.Length && i < word2.Length)
                ans += word1[i].ToString() + word2[i++].ToString();
            
            return i < word1.Length ? ans + word1.Substring(i) : i < word2.Length ? ans + word2.Substring(i) : ans;
        }
    }
}