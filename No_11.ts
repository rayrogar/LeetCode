namespace Leetcode{
    export class No_11 {

        maxArea(height: number[]): number {
            let a = 0, i = 0, e = height.length - 1;
            while (i < e) {
                a = Math.max(a, Math.min(height[i], height[e]) * (e - i));
                if (height[i] > height[e])
                    e--;
                else
                    i++;

            }
            return a;
        };
    }
}