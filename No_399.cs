using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode
{
    class No_399
    {
      public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {

           List<double> output = new List<double>();
             Dictionary<string, Dictionary<string, double>> graph = new Dictionary<string, Dictionary<string, double>>();
            

            for (int i = 0; i < equations.Count; i++){
                //Console.WriteLine(string.Join(",",graph.Keys));
                if(!graph.ContainsKey(equations[i][0]))
                    graph[equations[i][0]] = new Dictionary<string, double>();
                graph[equations[i][0]].Add(equations[i][1], values[i]);

                if(!graph.ContainsKey(equations[i][1]))
                    graph[equations[i][1]] = new Dictionary<string, double>();
                graph[equations[i][1]].Add(equations[i][0], 1 / values[i]);
            }

                // Console.WriteLine(string.Join("\n", graph
                // .Select(x => { 
                //   return $"{x.Key} \n  --> [{string.Join(",", x.Value.Select(y => { return $"{y.Key} : {y.Value}"; }))}]"; })));
            

            for (int i = 0; i < queries.Count; i++)
            {
                //Console.WriteLine(string.Join(",",queries[i]));
                double temp = -1;
                if (!graph.ContainsKey(queries[i][0]) || !graph.ContainsKey(queries[i][1]))
                    output.Add(temp);
                else if (queries[i][0] == queries[i][1])
                    output.Add(1);
                else
                {
                    temp = FindPath(graph, queries[i], new List<string>(){queries[i][0]});
                    output.Add(temp);
                }
            }

            return output.ToArray();
        }

        public double FindPath(Dictionary<string,Dictionary<string,double>> set, IList<string> q, List<string> visited){

            //Console.WriteLine(string.Join(",", q));
            //Console.ReadKey();
            double output = -1;

            if(set[q[0]].ContainsKey(q[1]))
                return set[q[0]][q[1]];

            foreach (var cur in set[q[0]])
            {
                if (!visited.Contains(cur.Key))
                {
                    visited.Add(cur.Key);
                    double t = FindPath(set, new List<string> { cur.Key, q[1] }, visited);
                    if (t != -1)
                    {
                        set[q[0]][q[1]] = cur.Value * t;
                        set[q[1]][q[0]] = 1 / (cur.Value * t);
                    }
                    if(t!=-1)
                        return  cur.Value * t;
                }
            }
            
            return output;
        }
    }
}