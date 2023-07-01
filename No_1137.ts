namespace Leetcode{
    export class No_1137 {
        tribonacci = function (n) {
            if (n === 0)
                return 0;
            if (n <= 2)
                return 1;
            //Works until tribonacci 34, then TLE
            //return tribonacci(n-1)+tribonacci(n-2)+tribonacci(n-3);
            if (n === 3)
                return 2;
            if (n === 4)
                return 4;
            let n2 = 1, n3 = 2, n4 = 4, ans = 0;
            for (let i = 5; i <= n; i++) {
                ans = n2 + n3 + n4;
                n2 = n3;
                n3 = n4;
                n4 = ans;
            }
            return ans
        };
    }
}