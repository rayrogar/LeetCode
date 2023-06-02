using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;

namespace LeetCode
{
    public class No_1091
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {


            if (grid[0][0] != 0 || grid[grid.Length - 1][grid[0].Length - 1] != 0)
                return -1;
            if (grid.Length == 1 && grid[0][0] == 0)
                return 1;

            Queue<(int, int)> vecinos = new Queue<(int, int)>();
            Queue<(int, int)> candidatos = new Queue<(int, int)>();
            HashSet<(int, int)> visitados = new HashSet<(int, int)>();
            visitados.Add((0, 0));
            getVecinos((0, 0), grid, candidatos, visitados);

            int steps = 1;

            while (candidatos.Count != 0)
            {
                var next = candidatos.Dequeue();
                if (visitados.Add(next))
                {

                    if (grid[next.Item1][next.Item2] == 0 && next == (grid.Length - 1, grid.Length - 1))
                        return steps + 1;
                    getVecinos(next, grid, vecinos, visitados);
                }
                if (candidatos.Count == 0 && vecinos.Count != 0)
                {
                    steps++;
                    candidatos = vecinos;
                    vecinos = new Queue<(int, int)>();
                    GC.Collect();
                }
            }

            return -1;
        }

        private Queue<(int, int)> getVecinos((int, int) cur, int[][] grid, Queue<(int, int)> vecinos, HashSet<(int, int)> visitados)
        {
            if (cur.Item1 - 1 >= 0)
            {
                if (!vecinos.Contains((cur.Item1 - 1, cur.Item2)) && !visitados.Contains((cur.Item1 - 1, cur.Item2)) && grid[cur.Item1 - 1][cur.Item2] == 0)
                    vecinos.Enqueue((cur.Item1 - 1, cur.Item2));
                if (cur.Item2 + 1 < grid[0].Length && !vecinos.Contains((cur.Item1 - 1, cur.Item2 + 1)) && !visitados.Contains((cur.Item1 - 1, cur.Item2 + 1)) && grid[cur.Item1 - 1][cur.Item2 + 1] == 0)
                    vecinos.Enqueue((cur.Item1 - 1, cur.Item2 + 1));
                if (cur.Item2 - 1 >= 0 && !vecinos.Contains((cur.Item1 - 1, cur.Item2 - 1)) && !visitados.Contains((cur.Item1 - 1, cur.Item2 - 1)) && grid[cur.Item1 - 1][cur.Item2 - 1] == 0)
                    vecinos.Enqueue((cur.Item1 - 1, cur.Item2 - 1));
            }

            if (cur.Item2 - 1 >= 0 && !vecinos.Contains((cur.Item1, cur.Item2 - 1)) && !visitados.Contains((cur.Item1, cur.Item2 - 1)) && grid[cur.Item1][cur.Item2 - 1] == 0)
                vecinos.Enqueue((cur.Item1, cur.Item2 - 1));

            if (cur.Item2 + 1 < grid[0].Length && !vecinos.Contains((cur.Item1, cur.Item2 + 1)) && !visitados.Contains((cur.Item1, cur.Item2 + 1)) && grid[cur.Item1][cur.Item2 + 1] == 0)
                vecinos.Enqueue((cur.Item1, cur.Item2 + 1));

            if (cur.Item1 + 1 < grid.Length)
            {
                if (cur.Item2 - 1 >= 0 && !vecinos.Contains((cur.Item1 + 1, cur.Item2 - 1)) && !visitados.Contains((cur.Item1 + 1, cur.Item2 - 1)) && grid[cur.Item1 + 1][cur.Item2 - 1] == 0)
                    vecinos.Enqueue((cur.Item1 + 1, cur.Item2 - 1));
                if (!vecinos.Contains((cur.Item1 + 1, cur.Item2)) && !visitados.Contains((cur.Item1 + 1, cur.Item2)) && grid[cur.Item1 + 1][cur.Item2] == 0)
                    vecinos.Enqueue((cur.Item1 + 1, cur.Item2));
                if (cur.Item2 + 1 < grid[0].Length && !vecinos.Contains((cur.Item1 + 1, cur.Item2 + 1)) && !visitados.Contains((cur.Item1 + 1, cur.Item2 + 1)) && grid[cur.Item1 + 1][cur.Item2 + 1] == 0)
                    vecinos.Enqueue((cur.Item1 + 1, cur.Item2 + 1));
            }
            return vecinos;
        }


    }
}
