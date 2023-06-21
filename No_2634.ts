namespace Leetcode {
    export class No_2634 {
        filter(arr: number[], fn: (n: number, i: number) => any): number[] {

            let ans: number[] = [];
             

            for (let j = 0; j < arr.length; j++)
                if (fn(arr[j], j))
                    ans.push(arr[j]);
        
            return ans;
        };
    }
}