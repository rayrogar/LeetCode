namespace Leetcode{
    export class No_374 {
        //Esto es solo para que no de error, no es necesario en el portal
        guess(n:number):number {
            return 1;
        }
        guessNumber(n: number): number {
            let i = 1, e = n, m = Math.floor(n / 2);
            while (i < e) {
                let g = this.guess(m);
                if (g == 0)
                    return m;
                g == 1 ? i = m + 1 : e = m - 1;
                m = Math.floor((i + e) / 2);
            }
            return i;
        };
    }
}