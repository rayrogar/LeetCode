namespace Leetcode{
    export class No_1207 {
        uniqueOccurrences(arr: number[]): boolean {
            let map = new Map<number, number>();

            arr.forEach(x => { if (!map.has(x)) map.set(x, 1); else map.set(x, map.get(x) + 1); });
            let sortedArray:number[] = [];
            for (const x of map.values())
                sortedArray.push(x);
            sortedArray.sort();
            let dif = Infinity;
            let ans = true;

            sortedArray.forEach(x => { if (x == dif) { ans = false; return; } dif = x; })
            return ans;
        };
    }
}