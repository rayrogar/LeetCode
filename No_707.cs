

using System.Diagnostics.CodeAnalysis;
/**
* Your MyLinkedList object will be instantiated and called as such:
* MyLinkedList obj = new MyLinkedList();
* int param_1 = obj.Get(index);
* obj.AddAtHead(val);
* obj.AddAtTail(val);
* obj.AddAtIndex(index,val);
* obj.DeleteAtIndex(index);
*/
namespace LeetCode
{
    /// <summary>
    /// Problem 707
    /// </summary>
    public class MyLinkedList
    {
        partial class node
        {

            public int data { get; set; }

            public node? Next { get; set; }

            public node? Prev { get; set; }
        }

        node raiz;
        /// <summary>
        ///  Initializes the MyLinkedList object.
        /// </summary>
        public MyLinkedList()
        {
        }
        /// <summary>
        /// Get the value of the indexth node in the linked list. If the index is invalid, return -1. 
        /// </summary>
        public int Get(int index)
        {
            node cur = raiz;
            if (cur == null)
                return -1;

            while (index-- > 0 && cur.Next != null)
            {
                cur = cur.Next;
            }
            if (index == -1)
                return cur.data;
            else
                return -1;
        }
        /// <summary>
        ///  Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
        /// </summary>
        public void AddAtHead(int val)
        {
            node cur = new node();
            cur.data = val;
            if (raiz != null)
            {
                cur.Next = raiz;
                raiz.Prev = cur;
                raiz = cur;
            }
            else
                raiz = cur;
        }
        /// <summary>
        /// Append a node of value val as the last element of the linked list.
        /// </summary>
        public void AddAtTail(int val)
        {
            node cur = new node();
            cur.data = val;

            if (raiz == null)
                raiz = cur;
                else{

                    node last = raiz;
                    while (last.Next != null)
                        last = last.Next;
                    cur.Prev = last;
                    last.Next = cur;
            }

        }
        /// <summary>
        /// Add a node of value val before the indexth node in the linked list. If index equals the length of the linked list, the node will be appended to the end of the linked list. If index is greater than the length, the node will not be inserted.
        /// </summary>
        public void AddAtIndex(int index, int val)
        {
            if (index == 0 && raiz == null)
                AddAtHead(val);
            else if(raiz!=null)
            {
                node cur = raiz;
                //Console.WriteLine(" 'AddAtIndex'-> cur.data {0}, cur.Prev: {1}, cur.Next: {2}", cur.data, cur.Prev?.data, cur.Next?.data);
                //Console.ReadKey();

                while (index > 0 && cur.Next != null)
                {
                    cur = cur.Next;
                    //Console.WriteLine(" 'AddAtIndex'-> cur.data {0}, cur.Prev: {1}, cur.Next: {2}", cur.data, cur.Prev?.data, cur.Next?.data);
                    //Console.ReadKey();
                    index--;
                    //Console.WriteLine("index: " + index);
                    //Console.ReadKey();
                }

                //Console.WriteLine(" 'AddAtIndex'-> cur.data {0}, cur.Prev: {1}, cur.Next: {2}", cur.data, cur.Prev?.data, cur.Next?.data);
               // Console.ReadKey();
                //Console.WriteLine("index: " + index);
                //Console.ReadKey();

                if (index == 0)
                {

                    node t = new node();
                    t.data = val;
                    // Console.WriteLine(" 'AddAtIndex'-> t.data {0}, t.Prev: {1}, t.Next: {2}", t.data, t.Prev?.data, t.Next?.data);
                    // Console.WriteLine(" 'AddAtIndex'-> cur.data {0}, cur.Prev: {1}, cur.Next: {2}", cur.data, cur.Prev?.data, cur.Next?.data);
                    // Console.ReadKey();
                    if (cur.Prev == null)
                    {
                        raiz.Prev = t;
                        t.Next = raiz;
                        raiz = t;
                    }
                    else
                    {
                        cur.Prev.Next = t;
                        t.Prev = cur.Prev;
                        cur.Prev = t;
                        t.Next = cur;

                    }
                }
                else if (index == 1)
                    AddAtTail(val);
            }
        }
        /// <summary>
        /// Delete the indexth node in the linked list, if the index is valid.
        /// </summary>
        public void DeleteAtIndex(int index)
        {
            node cur = raiz;
            while (index-- > 0 && cur.Next != null)
                cur = cur.Next;
            if (index == -1)
            {
                if (cur.Prev != null)
                {
                    cur.Prev.Next = cur.Next != null ? cur.Next : null;
                    if (cur.Next != null)
                        cur.Next.Prev = cur.Prev;
                }
                else if (cur.Next != null)
                {
                    cur.Next.Prev = cur.Prev;
                    raiz = cur.Next;
                }
                else raiz = null;
            }

        }
        public List<int> ReturnAsList()
        {
            List<int> salida = new List<int>();
            node cur = raiz;
            while (cur != null)
            {
                Console.WriteLine("'ReturnAsList'-> cur.data {0}, cur.Prev: {1}, cur.Next: {2}",cur.data, cur.Prev?.data, cur.Next?.data);
                salida.Add(cur.data);
                cur = cur.Next;

            }
            return salida;
        }
    }

}