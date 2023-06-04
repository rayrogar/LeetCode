namespace LeetCode
{
    public class No_547
    {
        public int FindCircleNum(int[][] isConnected)
        {
            int province = 0, n = isConnected.Length;
            Queue<int> neibours = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (visited.Add(i))
                {
                    province++;
                    for (int j = i; j < n; j++)
                        if (isConnected[i][j] == 1 && !visited.Contains(j))
                            neibours.Enqueue(j);

                    while (neibours.Count != 0)
                    {
                        int l = neibours.Dequeue();
                        if (visited.Add(l))
                        {
                            for (int k = 0; k < n; k++)
                                if (isConnected[l][k] == 1 && !visited.Contains(k))
                                    neibours.Enqueue(k);

                        }
                    }
                }
            }

            return province;
        }
    }
}