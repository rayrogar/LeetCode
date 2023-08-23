using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode
{
    public class No_2542
    {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            Array.Sort(nums2, nums1, Comparer<int>.Create((x, y) => x.CompareTo(y) * -1));
            long max = int.MinValue, sum = 0;

            PriorityQueue<int, int> K_arrayNums1 = new PriorityQueue<int, int>(k);

            for(int i = 0; i < k; i++){
                sum += nums1[i];
                K_arrayNums1.Enqueue(nums1[i], nums1[i]);
            }

            max = sum * nums2[k - 1];

            for(int i = k; i < nums1.Length; i++){
                if(nums1[i] > K_arrayNums1.Peek()){
                    sum += nums1[i] - K_arrayNums1.Dequeue();
                    K_arrayNums1.Enqueue(nums1[i], nums1[i]);
                    max = Math.Max(max, sum * nums2[i]);
                }
            }

            return max;
        }

    }
}