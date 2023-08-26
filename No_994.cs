using System.Reflection.Metadata.Ecma335;

namespace LeetCode
{
    class No_994
    {
        public int OrangesRotting(int[][] grid)
        {
            Queue<(int, int)> tree = new Queue<(int, int)>();
            int chk = CheckGrid(grid, ref tree);
            if (chk == -1)
                return -1;

            return chk == 0 ? 0 : SimulateRotting(tree, grid);
        }

       

        private int SimulateRotting(Queue<(int, int)> tree, int[][] grid)
        {
            int output = 0, chields = tree.Count;
            while (tree.Count != 0)
            {
                var cur = tree.Dequeue();
                grid[cur.Item1][cur.Item2] = 2;

                if (cur.Item1 - 1 >= 0 && grid[cur.Item1 - 1][cur.Item2] == 1 && !tree.Contains((cur.Item1 - 1, cur.Item2)))
                {
                    tree.Enqueue((cur.Item1 - 1, cur.Item2));
                    grid[cur.Item1 - 1][cur.Item2] = 2;
                }

                if (cur.Item1 + 1 < grid.Length && grid[cur.Item1 + 1][cur.Item2] == 1 && !tree.Contains((cur.Item1 + 1, cur.Item2)))
                {
                    tree.Enqueue((cur.Item1 + 1, cur.Item2));
                    grid[cur.Item1 + 1][cur.Item2] = 2;
                }

                if (cur.Item2 - 1 >= 0 && grid[cur.Item1][cur.Item2 - 1] == 1 && !tree.Contains((cur.Item1, cur.Item2 - 1)))
                {
                    tree.Enqueue((cur.Item1, cur.Item2 - 1));
                    grid[cur.Item1][cur.Item2 - 1] = 2;
                }

                if (cur.Item2 + 1 < grid[cur.Item1].Length && grid[cur.Item1][cur.Item2 + 1] == 1 && !tree.Contains((cur.Item1, cur.Item2 + 1)))
                {
                    tree.Enqueue((cur.Item1, cur.Item2 + 1));
                    grid[cur.Item1][cur.Item2 + 1] = 2;
                }

                if (--chields == 0)
                {
                    output++;
                    chields = tree.Count;
                }

            }
            return output;
        }


        private int CheckGrid(int[][] grid, ref Queue<(int, int)> tree){
            List<(int, int)> adj = new List<(int, int)>();
            for (int i = 0; i < grid.Length; i++){
                for (int j = 0; j < grid[i].Length; j++){
                    if (grid[i][j] == 1 && !adj.Contains((i, j)) && !tree.Contains((i, j)))
                    {
                        if (CheckIsla(grid, (i, j), ref tree, ref adj))
                            return -1;
                    }
                }
            }
            return adj.Count != 0 ? 1 : 0;
        }


        private bool CheckIsla(int[][] grid, (int, int) value, ref Queue<(int, int)> tree, ref List<(int, int)> adj)
        {
            bool _2adj = true;
            adj.Add(value);
            int e = adj.Count, s = e - 1;

            while (s < e)
            {
                if (adj[s].Item1 - 1 >= 0)
                {
                    if (grid[adj[s].Item1 - 1][adj[s].Item2] == 2)
                    {
                        tree.Enqueue((adj[s].Item1, adj[s].Item2));
                        _2adj = false;
                    }
                    else if (grid[adj[s].Item1 - 1][adj[s].Item2] == 1 && !adj.Contains((adj[s].Item1 - 1, adj[s].Item2)))
                    {
                        adj.Add((adj[s].Item1 - 1, adj[s].Item2));
                        e++;
                    }
                }

                if (adj[s].Item1 + 1 < grid.Length)
                {
                    if (grid[adj[s].Item1 + 1][adj[s].Item2] == 2)
                    {
                        tree.Enqueue((adj[s].Item1, adj[s].Item2));
                        _2adj = false;
                    }
                    else if (grid[adj[s].Item1 + 1][adj[s].Item2] == 1 && !adj.Contains((adj[s].Item1 + 1, adj[s].Item2)))
                    {
                        adj.Add((adj[s].Item1 + 1, adj[s].Item2));
                        e++;
                    }
                }

                if (adj[s].Item2 - 1 >= 0)
                {
                    if (grid[adj[s].Item1][adj[s].Item2 - 1] == 2)
                    {
                        tree.Enqueue((adj[s].Item1, adj[s].Item2));
                        _2adj = false;
                    }
                    else if (grid[adj[s].Item1][adj[s].Item2 - 1] == 1 && !adj.Contains((adj[s].Item1, adj[s].Item2 - 1)))
                    {
                        adj.Add((adj[s].Item1, adj[s].Item2 - 1));
                        e++;
                    }
                }

                if (adj[s].Item2 + 1 < grid[adj[s].Item1].Length)
                {
                    if (grid[adj[s].Item1][adj[s].Item2 + 1] == 2)
                    {
                        tree.Enqueue((adj[s].Item1, adj[s].Item2));
                        _2adj = false;
                    }
                    else if (grid[adj[s].Item1][adj[s].Item2 + 1] == 1 && !adj.Contains((adj[s].Item1, adj[s].Item2 + 1)))
                    {
                        adj.Add((adj[s].Item1, adj[s].Item2 + 1));
                        e++;
                    }
                }
                s++;
            }

            return _2adj;
            //return chkadj == e && _2adj;
            //return _2adj ? chkadj == e : false;
        }  
    }
}