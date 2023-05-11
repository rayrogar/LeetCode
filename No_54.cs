using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace LeetCode
{
    public class No_54
    {
        /// <summary>
        /// brute forse
        /// </summary>
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int i = 0, m = matrix.Length, n = matrix[0].Length, x = 0, y = 0, s = 0;
            int[] ans = new int[m * n];
            ans[i] = matrix[y][x];

            while (i < ans.Length - 1)
            {
                Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                Console.ReadKey();

                if (x < n)
                {
                    while (x < n - 1)
                    {
                        x++;
                        i++;
                        ans[i] = matrix[y][x];
                        Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                        Console.ReadKey();
                    }
                    n = n - 1;
                }
                if (y < m)
                {
                    while (y < m - 1)
                    {
                        y++;
                        i++;
                        ans[i] = matrix[y][x];
                        Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                        Console.ReadKey();
                    }
                    m = m - 1;
                }
                if (x > s && i < ans.Length - 1)
                {
                    while (x > s)
                    {
                        x--;
                        i++;
                        ans[i] = matrix[y][x];
                        Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                        Console.ReadKey();
                    }
                }
                if (y > s && i < ans.Length - 1)
                {
                    while (y > s + 1)
                    {
                        i++;
                        y--;
                        ans[i] = matrix[y][x];
                        Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                        Console.ReadKey();
                    }
                }
                if (s < n) s++;

            }

            return ans;
        }
    }
}