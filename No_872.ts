namespace Leetcode{
    export class TreeNode {
     val: number
      left: TreeNode | null
    right: TreeNode | null
      constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
         this.val = (val===undefined ? 0 : val)
          this.left = (left===undefined ? null : left)
         this.right = (right===undefined ? null : right)
    }
    };
    export class No_872 {
        leafSimilar(root1: TreeNode | null, root2: TreeNode | null): boolean {
            var tree: TreeNode[] = [root1];
            let leafs: number[] = [];

            while (tree.length != 0) {
                var cur = tree.pop();
                if (!cur.left && !cur.right)
                    leafs.push(cur.val);
                else {
                    if (cur.left)
                        tree.push(cur.left);
                    if (cur.right)
                        tree.push(cur.right);
                }
            }
            
            tree = [root2];

            while (tree.length != 0) {
                var cur = tree.pop();
                if (!cur.left && !cur.right) {
                    if (leafs[0] != cur.val)
                        return false;
                    leafs.shift();
                
                }
                else {
                    if (cur.left)
                        tree.push(cur.left);
                    if (cur.right)
                        tree.push(cur.right);
                }
            }

            return leafs.length == 0;
        };
    }
}