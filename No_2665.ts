namespace Leetcode {
    type ReturnObj = {
        increment: () => number,
        decrement: () => number,
        reset: () => number,
    }
    export class No_2665 {
    
        // Runtime: 60ms Beats: 95.69%, Memory: 44.9mb Beats: 95.31%
        createCounter(init: number): ReturnObj {
            let baseNumber = init;
            return {
                increment: (): number => { return ++baseNumber; },
                decrement: (): number => { return --baseNumber; },
                reset: (): number => { return baseNumber = init; }
            };
        };

        //Runtime: 72ms Beats: 57.41%, Memory: 44.9mb Beats: 97.93%
        createCounter1(init: number): ReturnObj {
            let baseNumber = init;
            return {
                increment: (): number => ++baseNumber,
                decrement: (): number => --baseNumber,
                reset: (): number => baseNumber = init,
            };

        };

        //Runtime: 78ms Beats: 26.72% Memory: 45.6mb Beats: 52.60%
        createCounter2(init: number): ReturnObj {
            let baseNumber = init;
            return {
                increment: () => ++baseNumber,
                decrement: () => --baseNumber,
                reset: () => baseNumber = init,
            };
        };
    }
}