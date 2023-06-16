namespace Leetcode{
    export class No_1161 {
         maxLevelSum(root: TreeNode | null): number {

            let level = 1 ; let ans = 1; let max = -Infinity; let actMax = 0; let numsChields = 1;

            let queueTree = [root];

            while(queueTree.length){
            
            const cur = queueTree.shift() as TreeNode;
            
            
            if(cur.left != null) queueTree.push(cur.left);
            if(cur.right != null) queueTree.push(cur.right);
            
            actMax += cur.val;
            numsChields--;

            if(numsChields == 0){
                if(max < actMax)
                {
                    max = actMax;
                    ans = level;
                }
                if(queueTree.length != 0){
                    actMax = 0;
                    level++;
                    numsChields = queueTree.length;
                }
            }
            }

            return ans;
};
    }

 
    export class TreeNode {
        val: number
        left: TreeNode | null
        right: TreeNode | null
        constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
            this.val = (val===undefined ? 0 : val)
            this.left = (left===undefined ? null : left)
            this.right = (right===undefined ? null : right)
        }
    }
 
}