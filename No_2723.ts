namespace Leetcode{
    export class No_2723 {
        async addTwoPromises(promise1: Promise<number>, promise2: Promise<number>): Promise<number> {
            try {
                //let a = await promise1.then(), b = await promise2.then();
                //let [a,b] = await Promise.all([promise1,promise2]);
                //return a + b;
                return await promise1 + await promise2;
            }
            catch (error) { throw error; }
        };
    }
}