namespace Leetcode{
    export class No_2725 {
        cancellable(fn: Function, args: any[], t: number): Function {
            fn(...args);
            let ID = setInterval(() => fn(...args), t);
            return () => clearTimeout(ID);
        };



    
        /*
        cancellable(fn: Function, args: any[], t: number): Function {
        let is_cancel = false
    
        function inner_call() {
            if (!is_cancel) {
                setTimeout(inner_call, t)
                return fn(...args)
            }
        }
        
        function cancel_call() {
            is_cancel = true
        }
    
        inner_call()
    
        return cancel_call
        }*/
    }
}