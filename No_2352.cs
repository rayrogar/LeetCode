namespace LeetCode
{
    class No_2352
    {
        public int EqualPairs(int[][] grid)
        {
            int c = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    int p = 0;
                    while (p < grid.Length)
                    {
                        if (grid[i][p] != grid[p][j])
                            break;
                        else
                            p++;
                    }
                    if (p == grid.Length)
                        c++;
                }
            }
            return c;
        }
    }
}