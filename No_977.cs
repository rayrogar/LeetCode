/*
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

 

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in non-decreasing order.
 

Follow up: Squaring each element and sorting the new array is very trivial, could you find an O(n) solution using a different approach?
*/

namespace LeetCode{
    public class No_977{
        public int[] SortedSquares(int[] nums)
        {
            int pmax = nums.Length - 1, p = nums.Length - 1, pmin = 0;
            int[] sqr_sort_nums = new int[nums.Length];

            while (pmax != pmin)
            {
                int f = (int)Math.Pow(nums[pmax], 2);
                int i = (int)Math.Pow(nums[pmin], 2);
                if (f >= i)
                {
                    sqr_sort_nums[p] = f;
                    pmax--;
                }
                else
                {
                    sqr_sort_nums[p] = i;
                    pmin++;
                }
                p--;
            }
            sqr_sort_nums[p] = (int)Math.Pow(nums[pmax], 2);

            return sqr_sort_nums;
        }
    }
}