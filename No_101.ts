namespace Leetcode{
    export class TreeNode {
        val: number
        left: TreeNode | null
        right: TreeNode | null
        constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
            this.val = (val === undefined ? 0 : val)
            this.left = (left === undefined ? null : left)
            this.right = (right === undefined ? null : right)
        }
    }

    export class No_101 {
        isSymmetric(root: TreeNode | null): boolean {

            if (!root.left && !root.right)
                return true;
            if (!root.left || !root.right || root.left.val !== root.right.val)
                return false;
            let rtree: TreeNode[] = [], ltree: TreeNode[] = [];
            rtree.push(root.right);
            ltree.push(root.left);

            while (ltree.length > 0) {
      
                let mleft = ltree.shift(), mright = rtree.pop();
          
                if ((mleft.right && !mright.left || !mleft.right && mright.left) ||
                    ((mleft.right && mright.left && mleft.right.val !== mright.left.val ||
                        mleft.left && mright.right && mleft.left.val !== mright.right.val)))
                    return false;
        
                if (mleft.left)
                    ltree.push(mleft.left);
                if (mleft.right)
                    ltree.push(mleft.right);
        
                if (mright.right)
                    rtree.unshift(mright.right);
                if (mright.left)
                    rtree.unshift(mright.left);

                if (ltree.length != rtree.length)
                    return false;
            }
            return true;
        };
    }
}