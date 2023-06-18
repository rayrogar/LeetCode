namespace Leetcode{
    export class No_54 {
        spiralOrder(matrix: number[][]): number[] {

            let up = 0, down = matrix.length, left = 0, rigth = matrix[0].length, nm = down * rigth, x = -1, y = 0;
            let ans = [];
  
            while (nm > 0) {
    
                //move rigth  
                while (x < rigth - 1 && nm > 0) {
                    ans.push(matrix[y][++x]);
                    nm--;
                }
                up++;
    
                //move down
                while (y < down - 1 && nm > 0) {
                    ans.push(matrix[++y][x]);
                    nm--;
                }
                rigth--;
    
                //move left
                while (x > left && nm > 0) {
                    ans.push(matrix[y][--x]);
                    nm--;
                }
                down--;
    
                //move up
                while (y > up && nm > 0) {
                    ans.push(matrix[--y][x]);
                    nm--;
                }
    
                left++;
            }
            return ans;
        };
    }
}