namespace LeetCode
{
    public class No_1351
    {
        /// <summary>
        /// O(n+m) Solution. Acepted 
        /// </summary>
        public int CountNegative(int[][] grid)
        {
            int ans = 0;

            int r = grid.Length, c = 0;

            while (r >= 0 && c < grid[0].Length)
            {
                if (grid[r][c] < 0)
                {
                    ans += grid[c].Length - c;
                    r--;
                }
                else
                    c++;
            }

            return ans;

        }


        /// <summary>
        /// Brute Forse. Acepted
        /// </summary>
        public int CountNegatives1(int[][] grid)
        {
            int c = 0;
            for (int i = grid.Length - 1; i >= 0; i--)
                for (int j = grid[i].Length - 1; j >= 0; j--)
                {
                    if (grid[i][j] < 0)
                        c++;
                    else
                        break;
                }
            return c;
        }
    }
}