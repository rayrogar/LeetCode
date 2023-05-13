namespace LeetCode
{
    public class No_1143
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int n = text1.Length + 1, m = text2.Length + 1;
            int[] rec = new int[m], rec1 = new int[m];
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                    rec1[j] = text1[i - 1] == text2[j - 1] ? 1 + rec[j - 1] : Math.Max(rec1[j - 1], rec[j]);
                rec1.CopyTo(rec, 0);
            }

            return rec1[m - 1];

        }




        /// <summary>
        /// Recursive solution, Answer ok!! Out of memory, Time Limit exceded too. Find a way to acomplice
        /// </summary>
        public int LongestCommonSubsequence1(string text1, string text2)
        {
            Dictionary<int[,], int> rec = new Dictionary<int[,], int>();
            return LCS(text1, text2, 0, 0, rec);
        }

        public int LCS(string text1, string text2, int idxText1, int idxText2, Dictionary<int[,], int> memo)
        {
            int[,] k = { { idxText1 }, { idxText2 } };
            if (memo.ContainsKey(k))
                return memo[k];
            if (idxText1 == text1.Length || idxText2 == text2.Length)
                return 0;

            if (text1[idxText1] == text2[idxText2])
                memo[k] = 1 + LCS(text1, text2, idxText1 + 1, idxText2 + 1, memo);
            else
                memo[k] = Math.Max(LCS(text1, text2, idxText1 + 1, idxText2, memo), LCS(text1, text2, idxText1, idxText2 + 1, memo));


            return memo[k];
        }
    }
}