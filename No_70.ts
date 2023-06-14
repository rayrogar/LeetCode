namespace Leetcode{
    export class No_70 {
       climbStairs(n: number): number {

        if(n < 4)
            return n;
        let ans = 0;
        let a = 2;
        let b = 3;

        for(let i = 4; i <= n ; i++){
            ans = a + b;
            a = b;
            b = ans;
        }

        return ans;
};
    }
}