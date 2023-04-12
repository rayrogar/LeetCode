/*
Given an array of integers arr, return true if and only if it is a valid mountain array.

Recall that arr is a mountain array if and only if:

arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i] 
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]

Example 1:

Input: arr = [2,1]
Output: false
Example 2:

Input: arr = [3,5,5]
Output: false
Example 3:

Input: arr = [0,3,2,1]
Output: true
*/

namespace LeetCode
{
    public class No_941{
        public bool ValidMountainArray(int[] arr)
        {
            int length = arr.Length;
            if (length < 3)
                return false;
            for (int i = 1; i < length - 1; i++)
            {
                int l = i - 1, r = i + 1;
                bool ll = false, rr = false;

                while (l >= 0)
                {
                    if (arr[l] == arr[l + 1])
                        return false;
                    if (arr[l] > arr[l + 1])
                        break;
                    l--;
                    if (l < 0)
                        ll = true;

                }

                while (r <= length - 1)
                {
                    if (arr[r] == arr[r - 1])
                        return false;
                    if (arr[r] > arr[r - 1])
                        break;
                    r++;
                    if (r > length - 1)
                        rr = true;
                }

                if (ll && rr)
                    return true;
            }
            return false;
        }
    }
}