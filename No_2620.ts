namespace Leetcode {
    export class No_2620 {
        createCounter(n: number): () => number {
            return function () {
                return n++;

                ;
            };
        }
    }
}
