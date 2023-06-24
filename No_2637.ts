namespace Leetcode {

    type Fn = (...params: any[]) => Promise<any>;

    export class No_2637 {
        timeLimit(fn: Fn, t: number): Fn {
            return async function (...args) {
                return Promise.race([fn(...args),
                new Promise((_, reject) => {
                    setTimeout(() => reject("Time Limit Exceeded"), t)
                })]);
            }
        };
    
    }
}

/**
 * const limited = timeLimit((t) => new Promise(res => setTimeout(res, t)), 100);
 * limited(150).catch(console.log) // "Time Limit Exceeded" at t=100ms

  const fns = fn(...args);
    const timeLimitPromise = new Promise((_, reject) => {
      setTimeout(() => {
        reject("Time Limit Exceeded");
      }, t);
    });

    return Promise.race([fns, timeLimitPromise]);


 let myPromise = new Promise(function(myResolve, myReject) {
// "Producing Code" (May take some time)

  myResolve(); // when successful
  myReject();  // when error
});

 return new Promise((resolve, reject) => {
            const timeout = setTimeout(() => {
                reject('Time Limit Exceeded'); }, t);
            fn(...args).then(resolve).catch(reject).finally(() => clearTimeout(timeout));
        });

// "Consuming Code" (Must wait for a fulfilled Promise)
myPromise.then(
  function(value) {  code if successful  },
  function(error) {  code if some error  }
);
 */