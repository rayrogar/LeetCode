namespace Leetcode{
    export class No_933 {
        counter: number[];

        constructor() {
            this.counter = [];
        }

        ping(t: number): number {
            
            this.counter.push(t);
            while (t - this.counter[0] > 3000)
                this.counter.shift();
            return this.counter.length;
        }
    }
}