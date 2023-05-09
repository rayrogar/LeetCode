using System.Drawing;

namespace LeetCode
{
    public class No_1964
    {
        public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
        {
            List<int> bs = new List<int>();

            for (int i = 0; i < obstacles.Length; i++)
            {
                Console.WriteLine("obs: " + string.Join(',', obstacles) + " list: " + string.Join(',', bs));
                Console.ReadKey();
                Console.Write("i: {0} ", i);
                int p = fIndex(bs, obstacles[i]);

                if (bs.Count == p)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    bs.Add(obstacles[i]);
                    Console.Write("bs: " + string.Join(',', bs));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    bs[p] = obstacles[i];
                }
                obstacles[i] = p + 1;
                Console.Write(" obs: " + string.Join(',', obstacles) + "\n");
                Console.ResetColor();
                Console.ReadKey();
            }

            return obstacles;
        }

        public int fIndex(IList<int> list, int t)
        {
            Console.Write("t: {0} ", t);

            if (list.Count == 0)
            {
                Console.WriteLine("list.Count == 0 = " + (list.Count == 0).ToString() + "\n return 0");
                return 0;
            }
            int l = 0, r = list.Count - 1;
            Console.Write("l: {0}, r: {1} ", l, r);
            while (l < r)
            {
                int m = l + (r - l) / 2;
                Console.Write("l: {0}, r: {1}, m: {2} \n", l, r, m);
                Console.ReadKey();

                if (list[m] <= t)
                    l = m + 1;
                else
                    r = m - 1;
            }
            Console.WriteLine("return l: {0}", l);
            Console.ReadKey();

            if (list[l] > t)
                return l;
            return l + 1;
        }

    }
}