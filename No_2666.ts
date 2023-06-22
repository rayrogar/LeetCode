namespace Leetcode{
    type Fn = (...args: any[]) => any

    export class No_2666 {
        once(fn: Fn): Fn {
            let cont = 1;
     
            return function (...args) {
                if (cont-- > 0)
                    return fn(...args);
            };
        }
    }
}