namespace Leetcode {
    type ToBeOrNotToBe = {
        toBe: (val: any) => boolean;
        notToBe: (val: any) => boolean;
    };
    
    export class No_2704 {
        expect(val: any): ToBeOrNotToBe {
            return {
                //equal
                toBe: (e: any): boolean => {
                    if (e === val) return true;
                    throw new Error("Not Equal");
                },
                //diferent
                notToBe: (d: any): boolean => {
                    if (d !== val) return true;
                    throw new Error("Equal");
                }
            };
        };
    }
}