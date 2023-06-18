namespace Leetcode {
    export class No_498 {
        findDiagonalOrder(mat: number[][]): number[] {
            let ans = [];
            let i = 0; let j = 0; let up = true;
  
            while (i < mat.length && j < mat[0].length) {
   
                if (up) {
                    while (i >= 0 && j < mat[0].length)
                        ans.push(mat[i--][j++]);
                
                    if (j == mat[0].length) {
                        j--;
                        i += 2;
                    }
                    else if (i < 0) i++;
                }
                else {
                    while (i < mat.length && j >= 0)
                        ans.push(mat[i++][j--]);
      
                    if (i == mat.length) {
                        i--;
                        j += 2;
                    }
                    else if (j < 0) j++;
                }
   
                up = !up;
            }
  
            return ans;
        };
    }
}