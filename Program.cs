using System.Diagnostics.Tracing;

namespace LeetCode
{
    public class Program{

        public static void Main(string[] args){
            //No_1480 a = new No_1480();
            //No_1672 a = new No_1672();
            //No_412 a = new No_412();
            //No_1342 a = new No_1342();
            //No_876 a = new No_876();
            //No_383 a = new No_383();
            //No_71 a = new No_71();
            //No_946 a = new No_946();
            //No_516 a = new No_516();
            //No_5 a = new No_5();
            //No_977 a = new No_977();
            //tema_arrays a = new tema_arrays();

            // Console.WriteLine("['MyLinkedList','addAtHead','addAtTail','addAtIndex','get','deleteAtIndex','get']\n[[],[1],[3],[1,2],[1],[1],[1]]");

            // MyLinkedList obj = new MyLinkedList();
            // Console.WriteLine("obj.AddAtHead(1): ");
            // obj.AddAtHead(1);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.AddAtTail(3): ");
            // obj.AddAtTail(3);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.AddAtIndex(1, 2): ");
            // obj.AddAtIndex(1, 2);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.Get(1): " + obj.Get(1));
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.DeleteAtIndex(1): ");
            // obj.DeleteAtIndex(1);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.Get(1): " + obj.Get(1));
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.WriteLine("Expected: [null,null,null,null,2,null,3]");
            // Console.ReadKey();


            // Console.WriteLine("['addAtHead','addAtTail','addAtIndex','addAtIndex','get','deleteAtIndex','get','deleteAtIndex','get']"+
            // "\n[[1],[3],[2,8],[1,2],[1],[1],[1],[0],[1]]");
            // obj = new MyLinkedList();

            // Console.WriteLine("obj.AddAtHead(1)");
            // obj.AddAtHead(1);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.AddAtTail(3)");
            // obj.AddAtTail(3);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.AddAtIndex(2, 8)");
            // obj.AddAtIndex(2, 8);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.AddAtIndex(1, 2)");
            // obj.AddAtIndex(1, 2);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.Get(1): " + obj.Get(1));
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.DeleteAtIndex(1)");
            // obj.DeleteAtIndex(1);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.Get(1): " + obj.Get(1));
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.DeleteAtIndex(0)");
            // obj.DeleteAtIndex(0);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.Get(1): " + obj.Get(1));
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.WriteLine("Expected: [null,null,null,null,null,2,null,3,null,8]");
            // Console.ReadKey();

            // Console.WriteLine("['MyLinkedList','addAtIndex','addAtIndex','addAtIndex','get']" +
            // "\n[[0,10],[0,20],[1,30],[0]]");
            // MyLinkedList obj = new MyLinkedList();

            // Console.WriteLine("obj.AddAtIndex(0, 10)");
            // obj.AddAtIndex(0, 10);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.AddAtIndex(0, 20)");
            // obj.AddAtIndex(0, 20);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.AddAtIndex(1, 30)");
            // obj.AddAtIndex(1, 30);
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            // Console.WriteLine("obj.Get(0): " + obj.Get(0));
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.WriteLine("Expected: [null,null,null,null,20]");
            // Console.ReadKey();

            //     Console.WriteLine("['MyLinkedList','addAtHead','addAtHead','addAtHead','addAtIndex','deleteAtIndex','addAtHead','addAtTail','get','addAtHead','addAtIndex','addAtHead']" +
            //    "\n[[],[7],[2],[1],[3,0],[2],[6],[4],[4],[4],[5,0],[6]]");
            //     MyLinkedList obj = new MyLinkedList();

            //     Console.WriteLine("obj.AddAtHead(7)");
            //     obj.AddAtHead(7);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.AddAtHead(2)");
            //     obj.AddAtHead(2);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.AddAtHead(1)");
            //     obj.AddAtHead(1);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.AddAtIndex(3, 0)");
            //     obj.AddAtIndex(3, 0);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.DeleteAtIndex(2)");
            //     obj.DeleteAtIndex(2);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.AddAtHead(6)");
            //     obj.AddAtHead(6);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.AddAtTail(4)");
            //     obj.AddAtTail(4);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.Get(4): " + obj.Get(4));
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.AddAtHead(4)");
            //     obj.AddAtHead(4);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.AddAtIndex(5, 0)");
            //     obj.AddAtIndex(5, 0);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("obj.AddAtHead(6)");
            //     obj.AddAtHead(6);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            //     Console.WriteLine("['MyLinkedList','addAtTail','get']" +
            //    "\n[[],[1],[0]]");
            //      MyLinkedList obj = new MyLinkedList();

            //     Console.WriteLine("obj.AddAtTail(1)");
            //     obj.AddAtTail(1);
            //     Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            //     Console.ReadKey();

            // Console.WriteLine("obj.Get(0): " + obj.Get(0));
            // Console.WriteLine(String.Join(',', obj.ReturnAsList()));
            // Console.ReadKey();

            //No_662 a = new No_662();
            //No_2336 a = new No_2336();

            #region 319. Bulb Switcher
            // for (int i = 0; i < 150; i++)
            // {
            //     int[] mem = new int[i];
            //     for (int j = 0; j < i; j++)
            //     {
            //         for (int k = j; k < i; k += j + 1)
            //         {
            //             mem[k] = mem[k] == 0 ? 1 : 0;
            //         }
            //         //Console.WriteLine("i: {0}, j: {1}, mem: {2}", i, j, string.Join(string.Empty, mem));
            //         //Console.ReadKey();
            //     }
            //     int c = 0;
            //     List<int> pos = new List<int>();
            //     for (int l = 0; l < mem.Length; l++)
            //     {
            //         if (mem[l] == 1)
            //         {
            //             c++;
            //             pos.Add(l);

            //         }
            //     }
            //     if (i % 2 == 0)
            //         Console.ForegroundColor = ConsoleColor.Red;
            //     Console.WriteLine("i: {0}, mem: {1}, cant 1: {2}, pos: {3}", i, string.Join(string.Empty, mem), c, string.Join(',', pos));
            //     Console.ReadKey();
            //     Console.ResetColor();
            // }
            #endregion


        }



    }
    
}
