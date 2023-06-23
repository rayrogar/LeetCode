namespace Leetcode {
    export class No_2715 {
        cancellable(fn: Function, args: any[], t: number): Function {
            let ID = setTimeout(() => fn(...args), t);
            return () => clearTimeout(ID);
        };
    }
 }
