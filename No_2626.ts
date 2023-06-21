namespace Leetcode {
    type Fn = (accum: number, curr: number) => number;
 
    export class No_2626 {
        reduce(nums: number[], fn: Fn, init: number): number {
    
            if (nums.length == 0) return init;
    
            nums[0] = fn(init, nums[0]);
            for (let i = 1; i < nums.length; i++)
                nums[0] = fn(nums[0], nums[i]);
            return nums[0];
        };
    }
}