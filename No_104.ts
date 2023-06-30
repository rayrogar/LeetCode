namespace Leetcode {
    export class TreeNode {
        val: number
        left: TreeNode | null
        right: TreeNode | null
        constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
            this.val = (val === undefined ? 0 : val)
            this.left = (left === undefined ? null : left)
            this.right = (right === undefined ? null : right)
        }
    };

    export class No_104 {
        maxDepth(root: TreeNode | null): number {
            if (root === null)
                return 0;
            let c = 1, l = 0;
            let tree: TreeNode[] = [root];
            while (tree.length != 0) {
   
                let cur = tree.shift();
    
                if (cur.left != null)
                    tree.push(cur.left);

                if (cur.right != null)
                    tree.push(cur.right);
    
                if (--c == 0) {
                    l++;
                    c = tree.length;
                }

            }
            return l;
        };

    }
}