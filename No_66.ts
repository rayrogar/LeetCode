namespace Leetcode{
    export class No_66 {
        plusOne(digits: number[]): number[] {
            let res = 1;
            for (let i = digits.length - 1; i >= 0; i--)
                if ((digits[i] + res) > 9)
                    digits[i] = 0;
                else {
                    digits[i] += res;
                    res = 0;
                    break;
                }
            if (res > 0)
                digits.unshift(res);
  
            return digits;
        };
    }
}