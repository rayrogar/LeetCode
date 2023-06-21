namespace Leetconde {
    type F = (x: number) => number;
    export class No_2629 {
        compose(functions: F[]): F {
            return function (x) {
                //for(let i = functions.length - 1; i >= 0; i--)
                //x = functions[i](x);
                functions.reverse().forEach(f => { x = f(x) });
                return x;
            }
        };
    }
}