namespace LeetCode
{
    class No_62
    {
        public int UniquePaths(int m, int n)
        {
            int[] Path = new int[n];

            Array.Fill(Path, 1);


            for (int i = 1; i < m; i++)
                for (int j = 1; j < Path.Length; j++)
                    Path[j] += Path[j - 1];
            return Path[n - 1];
        }
    }
}