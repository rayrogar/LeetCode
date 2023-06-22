namespace Leetcode {
    type Fn = (...params: any) => any

    export class No_2623 {
        memoize(fn: Fn): Fn {
            let memo = new Map();
   
            return function (...args) {
                if (memo[args] == null)
                    memo[args] = fn(...args);
                return memo[args];
            };
        }
    }
}