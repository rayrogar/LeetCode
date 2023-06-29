namespace Leetcode{
    export class No_1732 {
        largestAltitude(gain: number[]): number {
            let p = gain[0], h = Math.max(0, p);
            for (let i = 1; i < gain.length; i++)
                h = Math.max(p += gain[i], h);
            return h;
        };
    }
}