namespace Leetcode{
    export class No_238 {
         productExceptSelf(nums: number[]): number[] {
                const ans:number[]=[];
                    let t=1;
                    for (let i = 0; i < nums.length; i++){
                            t *= nums[i];
             }
             for (let i = 0; i < nums.length; i++) {
                 ans[i] = t * 1 / nums[i];
                
             }
                    return ans;
            };
        }
    }
