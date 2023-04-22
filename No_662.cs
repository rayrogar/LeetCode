using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace LeetCode
{
    public class No_662
    {

        public No_662()
        {
            TreeNode a = construirArbol(new[] { "1", "3", "2", "5", "null", "null", "9", "6", "null", "7" });
            Console.WriteLine("root = [1,3,2,5,null,null,9,6,null,7]");
            Console.WriteLine("Ancho del arbol: " + WidthOfBinaryTree(a));
            Console.ReadKey();

            // a = construirArbol(new[] { "1", "3", "2", "5", "3", "null", "9" });
            // Console.WriteLine("root = [1,3,2,5,3,null,9]");
            // Console.WriteLine("Ancho del arbol: " + WidthOfBinaryTree(a));
            // Console.ReadKey();

            // a = construirArbol(new[] { "1", "3", "2", "5" });
            // Console.WriteLine("root = [1,3,2,5]");
            // Console.WriteLine("Ancho del arbol: " + WidthOfBinaryTree(a));
            // Console.ReadKey();

            a = construirArbol(new[] { "0", "0", "0", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null","0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null", "null", "0", "0", "null" });
            Console.WriteLine("root = [[0,0,0,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0,null,null,0,0....]");
            Console.WriteLine("Ancho del arbol: " + WidthOfBinaryTree(a));
            Console.ReadKey();

        }
        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 1;

            Queue<TreeNode> niv_act, niv_prox = new Queue<TreeNode>();
            Queue<int> pos = new Queue<int>();


            niv_prox.Enqueue(root);
            pos.Enqueue(0);
            int c = 1;


            while (niv_prox.Count != 0)
            {
                niv_act = niv_prox;
                niv_prox = new Queue<TreeNode>();
                int ct = 0;

                while (niv_act.Count != 0)
                {
                    TreeNode node = niv_act.Dequeue();
                    int fpos = pos.Dequeue();
                    if (node.left != null)
                    {
                        niv_prox.Enqueue(node.left);
                        pos.Enqueue(fpos * 2 + 1);
                    }

                    if (node.right != null)
                    {
                        niv_prox.Enqueue(node.right);
                        pos.Enqueue(fpos * 2 + 2);
                    }
                }

                if(pos.Count!=0)
                    ct = pos.Last() - pos.Peek() + 1;
                if(ct > c)
                    c = ct;
            }

            return c;
        }

        public TreeNode construirArbol(string[] root)
        {
            List<TreeNode> tree = new List<TreeNode>();
            tree.Add(new TreeNode(int.Parse(root[0].ToString())));
            int raiz = 0, l = 1, r = 2;

            for (int i = 1; i < root.Length; i++)
            {
                if (l < root.Length)
                {
                    if (root[l] != "null")
                    {
                        TreeNode left = new TreeNode(int.Parse(root[l]));
                        tree.Add(left);
                        tree[raiz].left = left;

                    }
                }
                if (r < root.Length)
                {
                    if (root[r] != "null")
                    {
                        TreeNode right = new TreeNode(int.Parse(root[r].ToString()));
                        tree.Add(right);
                        tree[raiz].right = right;
                    }
                }
                l = r + 1;
                r = l + 1;
                Console.WriteLine("raiz: {0}, izq: {1}, der: {2}", tree[raiz].val, tree[raiz].left?.val, tree[raiz].right?.val);
                //Console.ReadKey();
                if (++raiz >= tree.Count)
                    break;

            }
            return tree[0];
        }

        public void imprimirArbol(TreeNode root)
        {

            Console.WriteLine(root.val);
            if (root.left != null)
                imprimirArbol(root.left);
            if (root.right != null)
                imprimirArbol(root.right);

        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}