using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;

namespace LeetCode
{
    public class No_1376
    {


        public int NumOfMinutes1(int n, int headID, int[] manager, int[] informTime)
        {
            int max = informTime[headID];

            Queue<int> q = new Queue<int>();
            q.Enqueue(headID);
            while (q.Count != 0)
            {

                int cur = q.Dequeue();
                if (informTime[cur] != 0)
                {

                    for (int i = 0; i < manager.Length; i++)
                        if (manager[i] == cur && informTime[i] != 0)
                        {
                            q.Enqueue(i);
                            informTime[i] += informTime[cur];
                            max = Math.Max(max, informTime[i]);
                        }

                }
            }

            return max;
        }
        /// <summary>
        /// Acortando el tiempo de mi BFS, solo para hojas que importen, las otras se desechan
        /// </summary>
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {

            int max = informTime[headID];
            Dictionary<int, List<int>> Tree = new Dictionary<int, List<int>>();
            for (int i = 0; i < manager.Length; i++)
                if (informTime[i] != 0 && manager[i] != -1)
                {
                    Console.WriteLine(string.Join(',', Tree));
                    if (!Tree.ContainsKey(manager[i]))
                    {
                        Tree.Add(manager[i], new List<int>());
                        Tree[manager[i]].Add(i);
                    }
                    else
                        Tree[manager[i]].Add(i);
                }
            Console.WriteLine(string.Join(',', Tree));
            

            Queue<int> q = new Queue<int>();
            q.Enqueue(headID);
            while (q.Count != 0)
            {
                int cur = q.Dequeue();
                if (informTime[cur] != 0)
                {

                    for (int i = 0; i < Tree[cur].Count; i++)
                    {
                        q.Enqueue(Tree[cur][i]);
                        informTime[Tree[cur][i]] += informTime[cur];
                        max = Math.Max(max, informTime[Tree[cur][i]]);
                    }



                    //             if (manager[tree[i]] == cur)
                    //             {
                    //                 q.Enqueue(tree[i]);
                    //                 informTime[tree[i]] += informTime[cur];
                    //                 max = Math.Max(max, informTime[tree[i]]);
                    //                 tree.RemoveAt(i);
                    //             }

                }
            }

            return max;
        }

    }

}