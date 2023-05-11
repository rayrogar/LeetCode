using System.Security.Cryptography.X509Certificates;

namespace LeetCode
{
    public class No_59
    {
        public int[][] GenerateMatrix(int n)
        {
            int i = 0, m = n, c = n, x = -1, y = 0, s = 0;
            int[][] ans = new int[n][];
            for (int j = 0; j < n; j++)
            {
                ans[j] = new int[n];
            }

            while (i <= n * n)
            {
                //Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                //Console.ReadKey();

                if (x < c)
                {
                    while (x < c - 1)
                    {
                        x++;
                        i++;
                        ans[y][x] = i;

                        //Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                        //Console.ReadKey();
                    }
                    c--;
                }
                if (y < m)
                {
                    while (y < m - 1)
                    {

                        i++;
                        y++;
                        ans[y][x] = i;


                        //Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                        //Console.ReadKey();
                    }
                    m--;
                }
                if (x > s || y > s)
                {
                    while (x > s)
                    {
                        x--;
                        i++;
                        ans[y][x] = i;

                        // Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                        // Console.ReadKey();
                    }


                    while (y > s + 1)
                    {
                        i++;
                        y--;
                        ans[y][x] = i;

                        // Console.WriteLine("i: {0}, y: {2}, m {5},x: {3},n {6}, s: {4}, ans: {1}", i, string.Join(',', ans), y, x, s, m, n);
                        // Console.ReadKey();
                    }
                }
                if (s < c) s++;

            }
            return ans;
        }
    }
}