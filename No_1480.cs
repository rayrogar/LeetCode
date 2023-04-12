/*
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
Example 2:

Input: nums = [1,1,1,1,1]
Output: [1,2,3,4,5]
Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
Example 3:

Input: nums = [3,1,2,10,1]
Output: [3,4,6,16,17]
*/

namespace LeetCode
{
    public class No_1480
    {

        public No_1480(){
            Console.WriteLine("Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).");
            Console.WriteLine("Return the running sum of nums.");
            Console.WriteLine("Example 1");
            Console.WriteLine("Input: nums = [1,2,3,4]");
            Console.WriteLine("Output: [1,3,6,10]");
            Console.WriteLine("Real: " + string.Join(',', RunningSum(new int[] { 1, 2, 3, 4 })));
            Console.WriteLine("Real: " + string.Join(',', RunningSum1(new int[] { 1, 2, 3, 4 })));

            //===================================================////========================================================///
            Console.WriteLine("Example 2");
            Console.WriteLine("Input: nums = [1,1,1,1,1]");
            Console.WriteLine("Output: [1,2,3,4,5]");
            Console.WriteLine("Real: " + string.Join(',', RunningSum(new int[] { 1, 1, 1, 1, 1 })));
            Console.WriteLine("Real: " + string.Join(',', RunningSum1(new int[] { 1, 1, 1, 1, 1 })));

            //===================================================////========================================================///
            Console.WriteLine("Example 3");
            Console.WriteLine("Input: nums = [3,1,2,10,1]");
            Console.WriteLine("Output: [3,4,6,16,17]");
            Console.WriteLine("Real: " + string.Join(',', RunningSum(new int[] { 3, 1, 2, 10, 1 })));
            Console.WriteLine("Real: " + string.Join(',', RunningSum1(new int[] { 3, 1, 2, 10, 1 })));
            Console.ReadKey();

        }
        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = nums;

            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = nums[i] + runningSum[i - 1];
            }
            return runningSum;
        }
        public int[] RunningSum1(int[] nums)
        {

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }


    }

}