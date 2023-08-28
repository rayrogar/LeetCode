using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode
{
    class No_2462
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {

           var frontheap = new PriorityQueue<int, int>();
            var backHeap = new PriorityQueue<int, int>();
            int i = 0, e = costs.Length - 1, n = Math.Min(candidates, costs.Length);
            long output = 0;
            for (int j = 0; j < n; j++)
            {
                if (n <= e)
                    backHeap.Enqueue(e, costs[e--]);
                frontheap.Enqueue(i, costs[i++]);
            }
            for (int l = 0; l < k; l++)
            {
                if (frontheap.Count != 0 && backHeap.Count != 0)
                {
                    if (costs[frontheap.Peek()] <= costs[backHeap.Peek()])
                    {
                        output += costs[frontheap.Dequeue()];
                        if (i <= e)
                            frontheap.Enqueue(i, costs[i++]);
                    }
                    else
                    {
                        output += costs[backHeap.Dequeue()];
                        if (e >= i)
                            backHeap.Enqueue(e, costs[e--]);
                    }
                }
                else if (frontheap.Count != 0)
                    output += costs[frontheap.Dequeue()];
                else output += costs[backHeap.Dequeue()];

            }
            return output;
        }
    }
}