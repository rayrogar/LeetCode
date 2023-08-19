using System.Diagnostics.Contracts;

namespace LeetCode
{
    class No_1926
    {
        /// <summary>
        /// Acepted: Runtime: 192ms Beats: 95.50%, Memory: 81mb Beats: 22%
        /// La estrategia es marcar las casillas por las que pase sin meterlas en una lista de visitados
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="entrance"></param>
        /// <returns></returns>
        public int NearestExit(char[][]maze, int[] entrance){
         
            Queue<int[]> next = new Queue<int[]>();
            next.Enqueue(entrance);
            int output = 0, neighbors = 1;

            while(next.Count!=0){
                var curStep = next.Dequeue();

                if(!curStep.Equals(entrance) && (curStep[0] == 0 || curStep[1] == 0 || curStep[0] == maze.Length - 1 || curStep[1] == maze[0].Length - 1))
                    return output;

                maze[curStep[0]][curStep[1]] = '*';

                //Move Up
                if(curStep[0] - 1 >= 0 && maze[curStep[0] - 1][curStep[1]] != '+' && maze[curStep[0] - 1][curStep[1]] != '*')
                        {
                            next.Enqueue(new int[] { curStep[0] - 1, curStep[1] });
                            maze[curStep[0] - 1][curStep[1]] = '*';
                    }
                //Move Down
                if(curStep[0] + 1 < maze.Length && maze[curStep[0] + 1][curStep[1]] != '+'  && maze[curStep[0] + 1][curStep[1]] != '*' )
                   { 
                       next.Enqueue(new int[] { curStep[0] + 1, curStep[1] });
                       maze[curStep[0] + 1][curStep[1] ] = '*';
                }
                //Move Left
                if(curStep[1] - 1 >= 0 && maze[curStep[0]][curStep[1] - 1] != '+'  && maze[curStep[0]][curStep[1] - 1] != '*' )
                   { 
                       next.Enqueue(new int[] { curStep[0], curStep[1] - 1});
                       maze[curStep[0]][curStep[1] - 1] = '*';
                }
                //Move Right
                if(curStep[1] + 1  < maze[0].Length && maze[curStep[0]][curStep[1] + 1] != '+'  && maze[curStep[0]][curStep[1] + 1] != '*' )
                    {
                        next.Enqueue(new int[] { curStep[0], curStep[1] + 1});
                        maze[curStep[0]][curStep[1] + 1] = '*';
}
                if (--neighbors == 0)
                {
                    neighbors = next.Count;
                    output++;
                }
            }
            return -1;
        }


        /// <summary>
        /// Acepted but, TLE!!!!!
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="entrance"></param>
        /// <returns></returns>
        public int NearestExit1(char[][] maze, int[] entrance)
        {
            List<int[]> visited = new List<int[]>();
            Queue<int[]> next = new Queue<int[]>();
            
            next.Enqueue(entrance);
            int output = 0, neighbors = 1, count = 0;

            while (next.Count != 0)
            {
                Console.WriteLine(++count + " : " + output + " => visited.Count: " + visited.Count + " Next.Count=> " + next.Count);
                int[] curStep = next.Dequeue();

                if (!curStep.Equals(entrance) && (curStep[0] == 0 || curStep[0] == maze.Length - 1 || curStep[1] == 0 || curStep[1] == maze[curStep[0]].Length - 1))
                    return output;

                visited.Add(curStep);

                //move up
                if (curStep[0] - 1 >= 0 && maze[curStep[0] - 1][curStep[1]] != '+' && next.Count(x => x[0] == curStep[0] - 1 && x[1] == curStep[1]) == 0)
                {
                    var newStep = new int[] { curStep[0] - 1, curStep[1] };
                    if (visited.Count(x => x[0] == newStep[0] && x[1] == newStep[1]) == 0)
                    {
                        next.Enqueue(newStep);
                    }
                }

                //move down
                if (curStep[0] + 1 < maze.Length && maze[curStep[0] + 1][curStep[1]] != '+' && next.Count(x => x[0] == curStep[0] + 1 && x[1] == curStep[1]) == 0)
                {
                    var newStep = new int[] { curStep[0] + 1, curStep[1] };
                    if (visited.Count(x => x[0] == newStep[0] && x[1] == newStep[1]) == 0)
                    {
                        next.Enqueue(newStep);
                    }
                }

                //move left
                if (curStep[1] - 1 >= 0 && maze[curStep[0]][curStep[1] - 1] != '+' && next.Count(x => x[0] == curStep[0] && x[1] == curStep[1] - 1) == 0)
                {
                    var newStep = new int[] { curStep[0], curStep[1] - 1 };
                    if (visited.Count(x => x[0] == newStep[0] && x[1] == newStep[1]) == 0)
                    {
                        next.Enqueue(newStep);
                    }
                }

                //move right
                if (curStep[1] + 1 < maze[curStep[0]].Length && maze[curStep[0]][curStep[1] + 1] != '+' && next.Count(x => x[0] == curStep[0] && x[1] == curStep[1] + 1) == 0)
                {
                    var newStep = new int[] { curStep[0], curStep[1] + 1 };
                    if (visited.Count(x => x[0] == newStep[0] && x[1] == newStep[1]) == 0)
                    {
                        next.Enqueue(newStep);
                    }
                }

                if (--neighbors == 0)
                {
                    neighbors = next.Count;
                    output++;
                }
            }
            return -1;
        }
    }
}