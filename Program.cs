using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Globalization;
using Name;

namespace LeetCode
{
    public class Program{

        public static void Main(string[] args)
        {
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
            #region 839. Similar String Groups

            // char[] alf = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z' };

            // for (int i = 0; i < 10; i++)
            // {
            //     List<int> m = new List<int>();

            //     Random r = new Random();

            //     for (int j = 0; j < i + 4; j++)
            //     {
            //         m.Add(r.Next(25));
            //     }
            //     string reg = string.Format("i: {0} ", i);

            //     for (int j = 0; j < 13 - i; j++)
            //     {
            //         reg += "\"";
            //         List<int> n = new List<int>();
            //         for (int k = 0; k < i + 4; k++)
            //         {

            //             int rp = r.Next(i + 4 - k - 1);
            //             //Console.WriteLine("i: {0}, k: {1}, n: {2}, rp: {3}, m: {4}", i, k, string.Join(',', n), rp, string.Join(',', m));

            //             reg += alf[m[rp]];
            //             n.Add(m[rp]);
            //             m.RemoveAt(rp);

            //             //Console.WriteLine(reg);
            //             //Console.ReadKey();
            //         }
            //         reg += "\",";
            //         m = n;
            //     }

            //     Console.WriteLine(reg.TrimEnd(','));
            //     Console.ReadKey();

            //}


            #endregion
            #region 61. Rotate List
            //Console.WriteLine(2 % 5);
            #endregion
            #region No_724

            // Console.WriteLine("nums = [1,7,3,6,5,6] \n Expected: 3 \n " + string.Join(',', new No_724().PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 })));
            // Console.WriteLine("nums = [1,2,3] \n Expected: -1 \n " + string.Join(',', new No_724().PivotIndex(new int[] { 1, 2, 3 })));
            // Console.WriteLine("nums = [2,1,-1] \n Expected: 0 \n " + string.Join(',', new No_724().PivotIndex(new int[] { 2, 1, -1 })));
            // Console.WriteLine("nums = [-1,1,2] \n Expected: 2 \n " + string.Join(',', new No_724().PivotIndex(new int[] { -1, 1, 2 })));
            #endregion
            #region No_649


            //for (char c = 'A'; c <= 'Z'; c++)
            //{
            //    Console.Write("C:{0}-{1} c: {2} ", c, (int)c,(char)(c+32));
            // }
            // Console.WriteLine();
            // Console.ReadKey();
            //  for (char c = 'a'; c <= 'z'; c++)
            //  {
            //      Console.Write("{0}: {1} ", c, (int)c);
            //  }

            //No_649 a = new No_649();

            #endregion
            #region No_1498
            //int mod = (int)1e9 + 7;
            const int mod = 1_000_000_007;

            int[] arr = new int[] { 2, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7 };

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine("Normal: {0} int: {1} mod: {2}", Math.Pow(2, arr[i]), (int)Math.Pow(2, arr[i]), Math.Pow(2, arr[i]) * 2 % mod);
            // }

            // int[] pow2 = new int[arr.Length];
            // pow2[0] = 1;
            // int p = 0;
            // int m = 0;
            // for (int i = 1; i < arr.Length; i++)
            // {
            //     pow2[i] = (pow2[i - 1] * 2) % mod;

            //     //Console.WriteLine("i: {2}, n: {3}, pow2[i-1]: {0}, (pow2[i - 1] * 2) % mod: {1}, 2^{2}={4},2^{2} % mod={5} ", pow2[i - 1], pow2[i], i, arr.Length, Math.Pow(2, i), (int)(Math.Pow(2, i) % mod));
            //     Console.WriteLine("(pow2[i - 1] * 2) % mod: {1}, 2^{2}={4},2^{2} % mod={5} ", pow2[i - 1], pow2[i], i, arr.Length, Math.Pow(2, i), (int)(Math.Pow(2, i) % mod));
            //     p += (pow2[i - 1] + pow2[i]) % mod;
            //     m += (int)((Math.Pow(2, i - 1) % mod) + (Math.Pow(2, i) % mod)) % mod;
            //     Console.WriteLine("pow2[i-1] + pow2[i]= {0},(Math.Pow(2, i-1) % mod) + (Math.Pow(2, i) % mod) = {1}", p, m);
            //     Console.ReadKey();

            // }

            // No_1498 a = new No_1498();
            // int[] arrr = new int[] { 2, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7, 3, 3, 4, 6, 7 };

            // //Array.Sort(nums);
            // int modulo = 1000000007;

            // int[] pow2 = new int[arrr.Length];
            // pow2[0] = 1;
            // for (int i = 1; i < arrr.Length; i++)
            // {
            //     pow2[i] = (pow2[i - 1] * 2) % modulo;

            // }

            // int sum = 0;
            // int sum1 = 0;
            // for (int i = 0; i < arrr.Length; i++)
            // {
            //     for (int j = arrr.Length - 1; j >= i; j--)
            //     {
            //         if (arrr[i] + arrr[j] <= 100)
            //         {

            //             sum += (sum + pow2[j - i]) % mod;

            //             var doublenumber = Math.Pow(2, (j - i) + 1) / 2;


            //             sum1 = (int)(sum1 + (( % mod)) % mod;
            //             if (sum != sum1)
            //                 Console.ForegroundColor = ConsoleColor.Red;
            //             else
            //                 Console.ForegroundColor = ConsoleColor.Green;
            //             Console.WriteLine("sum=sum1: {0}={1}", sum, sum1);
            //             Console.ResetColor();
            //             Console.ReadKey();

            //             break;
            //         }
            //     }
            // }



            // Console.WriteLine(a.NumSubseq(arrr, 100));
            // Console.WriteLine(a.NumSubseq1(arrr, 100));



            #endregion
            #region No_1
            // int a = -1000000000;
            // Console.WriteLine(a+a);
            #endregion
            #region No_1964
            // No_1964 bb = new No_1964();
            // Console.WriteLine("[1,2,3,2] = {0}", string.Join(',', bb.LongestObstacleCourseAtEachPosition(new int[] { 1, 2, 3, 2 })));
            // Console.WriteLine("[ 1, 2, 2, 2, 2, 2, 2, 2] = {0}", string.Join(',', bb.LongestObstacleCourseAtEachPosition(new int[] { 1, 2, 2, 2, 2, 2, 2, 2 })));
            //Console.WriteLine("[2,2,1] = {0}", string.Join(',', bb.LongestObstacleCourseAtEachPosition(new int[] { 2, 2, 1 })));

            #endregion
            #region No_1572
            // No_1572 a = new No_1572();
            // var mat = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            // Console.WriteLine("new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } ");
            // Console.WriteLine(a.DiagonalSum(mat));
            // mat = new int[][] { new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 } };
            // Console.WriteLine("new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }");
            // Console.WriteLine(a.DiagonalSum(mat));
            // mat = new int[][] { new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 } };
            // Console.WriteLine("new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1 } ");
            // Console.WriteLine(a.DiagonalSum(mat));
            // mat = new int[][] { new int[] { 1, 1 }, new int[] { 1, 1 } };
            // Console.WriteLine("new int[] { 1, 1 }, new int[] { 1, 1 }");
            // Console.WriteLine(a.DiagonalSum(mat));
            #endregion
            #region No_54
            // var mat = new int[][] { new int[] { 1 }, new int[] { 4 }, new int[] { 8 } };
            // No_54 a = new No_54();
            // Console.WriteLine(string.Join(',', a.SpiralOrder(mat)));
            // Console.ReadKey();
            // mat = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
            // Console.WriteLine(string.Join(',', a.SpiralOrder(mat)));
            // Console.ReadKey();
            // mat = new int[][] { new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 7, 8, 9, 10, 11, 12 }, new int[] { 13, 14, 15, 16, 17, 18 }, new int[] { 19, 20, 21, 22, 23, 24 }, new int[] { 25, 26, 27, 28, 29, 30 }, new int[] { 31, 32, 33, 34, 35, 36 } };
            // Console.WriteLine(string.Join(',', a.SpiralOrder(mat)));
            // Console.ReadKey();
            // mat = new int[][] { new int[] { 7, 8, 9, 10, 11, 12 }, new int[] { 13, 14, 15, 16, 17, 18 }, new int[] { 19, 20, 21, 22, 23, 24 }, new int[] { 25, 26, 27, 28, 29, 30 }, new int[] { 31, 32, 33, 34, 35, 36 } };
            // Console.WriteLine(string.Join(',', a.SpiralOrder(mat)));
            // Console.ReadKey();
            // mat = new int[][] { new int[] { 25, 26, 27, 28, 29, 30 }, new int[] { 31, 32, 33, 34, 35, 36 } };
            // Console.ReadKey();
            // Console.WriteLine(string.Join(',', a.SpiralOrder(mat)));
            // Console.ReadKey();
            // mat = new int[][] { new int[] { 1, 1 }, new int[] { 1, 2 } };
            // Console.WriteLine(string.Join(',', a.SpiralOrder(mat)));
            // Console.ReadKey();
            // mat = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 }, new int[] { 9, 10 }, new int[] { 11, 12 }, new int[] { 13, 14 }, new int[] { 15, 16 } };
            // Console.WriteLine(string.Join(',', a.SpiralOrder(mat)));
            // Console.ReadKey();
            // mat = new int[][] { new int[] { 1 } };
            // Console.WriteLine(string.Join(',', a.SpiralOrder(mat)));
            // Console.ReadKey();

            #endregion
            #region No_1035
            // No_1035 aaa = new No_1035();
            // // Console.WriteLine("nums1: {0}, nums2: {1}", string.Join(',', new int[] { 2, 5, 1, 2, 5 }), string.Join(',', new int[] { 10, 5, 2, 1, 5, 2 }));
            // // int m = aaa.MaxUncrossedLines(new int[] { 2, 5, 1, 2, 5 }, new int[] { 10, 5, 2, 1, 5, 2 });
            // // Console.WriteLine("ans: " + m);

            // Console.WriteLine("nums1: {0}, nums2: {1}", string.Join(',', new int[] { 4, 1, 5, 2, 1, 1, 1, 5, 3, 1, 1, 1, 2, 3, 1, 4, 3, 5, 5, 3, 1, 2, 3, 2, 4, 1, 1, 1, 5, 3 }), string.Join(',', new int[] { 3, 1, 4, 1, 1, 3, 5, 1, 2, 2 }));
            // int m = aaa.MaxUncrossedLines(new int[] { 4, 1, 5, 2, 1, 1, 1, 5, 3, 1, 1, 1, 2, 3, 1, 4, 3, 5, 5, 3, 1, 2, 3, 2, 4, 1, 1, 1, 5, 3 }, new int[] { 3, 1, 4, 1, 1, 3, 5, 1, 2, 2 });
            // Console.WriteLine("ans: " + m);
            #endregion
            #region No_409
            // string s = "utaliquampurussitametluctusvenenatislectusmagnafringillaurnaporttitorrhoncusdolorpurusnonenimpraesentelementumfacilisisleovelfringillaestullamcorperegetnullafacilisietiamdignissimdiamquisenimlobortisscelerisquefermentumduifaucibusinornarequamviverraorcisagittiseuvolutpatodiofacilisismaurissitametmassavitaetortorcondimentumlaciniaquisvelerosdonecacodiotempororcidapibusultricesiniaculisnuncsedauguelacusviverravitaecongueeuconsequatacfelisdonecetodiopellentesquediamvolutpatcommodosedegestasegestasfringillaphasellusfaucibusscelerisqueeleifenddonecpretiumvulputatesapiennecsagittisaliquammalesuadabibendumarcuvitaeelementumcurabiturvitaenuncsedvelitdignissimsodalesuteusemintegervitaejustoegetmagnafermentumiaculiseunondiamphasellusvestibulumloremsedrisusultriciestristiquenullaaliquetenimtortoratauctorurnanuncidcursusmetusaliquameleifendmiinnullaposueresollicitudinaliquamultricessagittisorciascelerisquepurussemperegetduisattellusaturnacondimentummattispellentesqueidnibhtortoridaliquetlectuspro";

            // No_409 ab = new No_409();

            // int a = ab.LongestPalindrome(s);
            // Console.WriteLine("ANS: " + a);

            #endregion
            #region No_733

            // No_733 cc = new No_733();
            // Console.WriteLine("image: [[1,1,1],[1,1,0],[1,0,1]]");

            // int[][] image = new int[][]{
            //                 new int[]{1,1,1},
            //                 new int[]{1,1,0},
            //                 new int[]{1,0,1}
            // };
            // imprimirMatrix(cc.FloodFill(image, 1, 1, 2));



            #endregion
            #region No_643
            // No_643 _no_643 = new No_643();
            //Console.WriteLine("Respuesta: " + _no_643.FindMaxAverage(testcase, 2));

            #endregion
            #region No_605
            // No_605 ab = new No_605();
            // Console.WriteLine("Input: flowerbed = [1,0,0,0,1], n = 1 " + ab.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1));
            // Console.WriteLine("Input: flowerbed = [1,0,0,0,1], n = 1 " + ab.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2));
            #endregion
            #region No_744
            // Console.WriteLine("!!!!PAR!!!");
            // Console.WriteLine(BinarySearch(new int[] { 1, 2 }, 1));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2 }, 2));
            // Console.WriteLine(BinarySearch(new int[] { 1, 3 }, 2));
            // Console.ReadKey();
            // Console.WriteLine("======////======////=====");
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4 }, 1));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4 }, 4));
            // Console.WriteLine(BinarySearch(new int[] { 1, 3, 3, 4 }, 3));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 4, 4 }, 4));
            // Console.WriteLine(BinarySearch(new int[] { 1, 1, 4, 4 }, 1));
            // // Console.WriteLine(BinarySearch(new int[] { 1, 1, 4, 4 }, 4));
            // Console.ReadKey();
            // Console.WriteLine("======////======////=====");
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 1));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 6));
            // Console.WriteLine(BinarySearch(new int[] { 1, 3, 3, 4, 5, 6 }, 3));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 4, 4, 4, 6 }, 4));
            // Console.WriteLine(BinarySearch(new int[] { 1, 1, 2, 4, 5, 6 }, 2));
            // Console.WriteLine(BinarySearch(new int[] { 1, 1, 2, 3, 5, 6 }, 3));
            // Console.ReadKey();
            // Console.WriteLine("!!!!IMPAR!!!");
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3 }, 1));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3 }, 3));
            // Console.WriteLine(BinarySearch(new int[] { 1, 3, 4 }, 3));
            // Console.ReadKey();
            // Console.WriteLine("======////======////=====");
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 1));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5 }, 5));
            // Console.WriteLine(BinarySearch(new int[] { 1, 3, 3, 4, 5 }, 3));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 4, 4, 6 }, 4));
            // Console.WriteLine(BinarySearch(new int[] { 1, 1, 4, 4, 5 }, 4));
            // Console.WriteLine(BinarySearch(new int[] { 1, 1, 2, 4, 5 }, 2));
            // Console.ReadKey();
            // Console.WriteLine("======////======////=====");
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 7));
            // Console.WriteLine(BinarySearch(new int[] { 1, 3, 3, 4, 5, 6, 7 }, 3));
            // Console.WriteLine(BinarySearch(new int[] { 1, 2, 4, 4, 4, 5, 7 }, 5));
            // Console.WriteLine(BinarySearch(new int[] { 1, 1, 2, 4, 5, 6, 7 }, 4));
            // Console.WriteLine(BinarySearch(new int[] { 1, 1, 2, 3, 5, 6, 7 }, 5));
            // Console.ReadKey();

            #endregion
            #region No_1802
            No_1802 _no1802 = new No_1802();
            // Console.WriteLine(_no1802.Sum(3, 2, 5));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(3, 2, 4));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(2, 2, 4));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(4, 2, 4));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(4, 0, 4));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(4, 3, 4));
            // Console.ReadKey();

            // Console.WriteLine(_no1802.Sum(10, 0, 3));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(17, 0, 3));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(21, 0, 3));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(20, 0, 3));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(5, 0, 3));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(100, 0, 3));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(22, 0, 3));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(35, 0, 3));
            // Console.ReadKey();

            // Console.WriteLine(_no1802.Sum(5, 0, 5));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(6, 5, 6));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(3, 0, 5));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(2, 4, 5));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(4, 3, 6));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(3, 3, 5));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(8, 3, 6));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(7, 3, 5));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(12, 2, 8));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(11, 6, 8));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(10, 3, 9));
            // Console.ReadKey();
            // Console.WriteLine(_no1802.Sum(11, 7, 9));
            // Console.ReadKey();


            #endregion

            // for (int i = 0; i < 10;i++)
            // Console.WriteLine(new string('+', 10));
            Console.WriteLine((" I Love you").Replace(" ", "").Length);
            Console.WriteLine((" ILove you").Replace(" ", "").Length);
            Console.WriteLine((" ILoveyou").Replace(" ", "").Length);
            Console.WriteLine(("ILoveyou").Replace(" ", "").Length);
        }

        // public static int BinarySearch(int[] arr, int target)
        // {
        //     Console.WriteLine();
        //     Console.WriteLine("arr: " + string.Join(',', arr) + " Target: " + target);
        //     int i = 0, e = arr.Length - 1, m = 0;
        //     while (i < e)
        //     {
        //         m = (i + e) / 2;
        //         Console.WriteLine("i: {0}, e: {1}, m: {2}", i, e, m);

        //         if (arr[m] == target)
        //             return m;
        //         if (arr[m] > target)
        //             e = m - 1;
        //         else
        //             i = m + 1;
        //     }
        //     Console.WriteLine("i: {0}, e: {1}, m: {2} end!!!", i, e, m);
        //     return -1;
        // }


    }
    
}
