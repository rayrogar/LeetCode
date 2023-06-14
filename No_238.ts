namespace Leetcode{
    export class No_238 {

        productExceptSelf1(nums: number[]): number[] {
            let ans: number[] = [];
            let aux: number[] = [];
            ans.fill(1, 0, nums.length);
            aux.fill(1, 0, nums.length);
        return ans;
            for (let i = 1; i < nums.length; i++) {
                ans[i] = ans[i - 1] * nums[i - 1];
                aux[nums.length - 1 - i] *= aux[nums.length - i] * nums[nums.length - i];
            }
            return ans;
            
            for (let i = 0; i < ans.length; i++)
                ans[i] *= aux[i];

            return ans;
            };
        
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
                            nums[i]=nums[i]==0?t:0;
                    else
                        nums[i] = t * Math.pow(nums[i], -1);
                }
                    return nums;
            };
        }
    }
