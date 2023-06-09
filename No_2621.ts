namespace Leetcode{
    export class No_2621 {
        async sleep(millis: number): Promise<void> {
            try {
                return new Promise<void>(resolve => setTimeout(() => resolve(), millis))
            }
            catch (error) { throw error; }
        }
    }
}