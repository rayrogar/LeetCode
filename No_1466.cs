using System.Numerics;

namespace LeetCode
{
    class No_1466
    {
        public int MinReorder(int n, int[][] connections)
        {
            List<int> visited = new List<int>();
            Queue<int> check = new Queue<int>();
            Dictionary<int, List<(int, int)>> matriz = new Dictionary<int, List<(int, int)>>();
            int output = 0;
            check.Enqueue(0);

            for (int i = 0; i < connections.Length; i++)
            {
                if(!matriz.ContainsKey(connections[i][0]))
                    matriz[connections[i][0]] = new List<(int, int)>();
                matriz[connections[i][0]].Add((connections[i][1], 0));
                if(!matriz.ContainsKey(connections[i][1]))
                    matriz[connections[i][1]] = new List<(int, int)>();
                matriz[connections[i][1]].Add((connections[i][0], 1));
            }



            while (check.Count != 0)
            {
                int cur = check.Dequeue();
                if (!visited.Contains(cur))
                {
                    visited.Add(cur);
                    for (int i = 0; i < matriz[cur].Count; i++)
                    {
                        if(!visited.Contains(matriz[cur][i].Item1)){
                            check.Enqueue(matriz[cur][i].Item1);
                            output += matriz[cur][i].Item2;
                        }
                    }
                }
            }


            return output;
        }
    }
}