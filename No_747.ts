namespace Leetcode{
    export class No_747 {
    dominantIndex(nums: number[]): number {

        let max = 0; let maxless = 0; let pos = -1;
        if (nums[0] > nums[1]) {
            max = nums[0];
            maxless = nums[1];
            pos = 0;
        }
        else {
            max = nums[1];
            maxless = nums[0];
            pos = 1;
        }

        for (let i = 2; i < nums.length; i++) {
            if (nums[i] > max) {
                maxless = max;
                max = nums[i];
                pos = i;
            }
            else if (nums[i] > maxless)
                maxless = nums[i];
        }
        return max >= maxless * 2 ? pos : -1;

        };
    }
}