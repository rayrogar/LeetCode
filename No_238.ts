namespace Leetcode {
    export class No_238 {

        /*
        *
        * Runtime: 105ms Beats: 76.67%, Memory: 54.5mb Beats: 66.42%
        *
        */
        productExceptSelf1(nums: number[]): number[] {
            const ans = Array(nums.length);
            const aux = Array(nums.length);
            ans.fill(1, 0, nums.length);
            aux.fill(1, 0, nums.length);
        
            for (let i = 1; i < nums.length; i++) {
                ans[i] = ans[i - 1] * nums[i - 1];
                aux[nums.length - 1 - i] *= aux[nums.length - i] * nums[nums.length - i];
            }
          
            
            for (let i = 0; i < ans.length; i++)
                ans[i] *= aux[i];

            return ans;
        };
        
       /*
       *Runtime: 121ms Beats: 31.85%, Memory: 54.2mb Beats: 70.56%
       */
        productExceptSelf(nums: number[]): number[] {
            //Ojo Se basa en que A/B = A*B^-1
            let t = 1;
            let zero = 0;
                        
            for (let i = 0; i < nums.length; i++)
                if (nums[i] == 0)
                    zero++;
                else
                    t *= nums[i];
                    
            if (zero > 1)
                nums.fill(0);
            else
                for (let i = 0; i < nums.length; i++) {
                    if (zero != 0)
                        nums[i] = nums[i] == 0 ? t : 0;
                    else
                        nums[i] = t * Math.pow(nums[i], -1);
                }
            return nums;
        };
    }
}
