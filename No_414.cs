/*
Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

 

Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.
Example 2:

Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.
Example 3:

Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
 

Follow up: Can you find an O(n) solution?
*/

namespace LeetCode
{
    public class No_414{

        public int ThirdMax(int[] nums)
        {
            int f = -1, s = -1, t = -1;
            if (nums.Length == 1)
                return nums[0];
            else if (nums.Length == 2)
                return (nums[0] > nums[1] ? nums[0] : nums[1]);
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (f == -1)
                        f = i;
                    else
                    {
                        if (nums[i] > nums[f])
                        {
                            t = s;
                            s = f;
                            f = i;
                        }
                        else if (nums[i] != nums[f])
                        {
                            if (s == -1)
                                s = i;
                            else
                            {
                                if (nums[i] > nums[s])
                                {
                                    t = s;
                                    s = i;
                                }
                                else if (nums[i] != nums[s])
                                {
                                    if (t == -1)
                                        t = i;
                                    else if (nums[i] > nums[t])
                                        t = i;
                                }
                            }
                        }
                    }
                }
            }

            if (t != -1)
                return nums[t];
            else return nums[f];
        }

    }
}