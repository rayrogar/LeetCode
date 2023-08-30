using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Name;

namespace LeetCode
{
    #pragma warning disable
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
            #region No_934
            //Console.WriteLine("3[a]1[b] => " +new No_934().DecodeString("3[a]1[b]"));
            //Console.WriteLine("3[a]1b]] => " +new No_934().DecodeString("3[a1[b]]"));
            //Console.WriteLine("3[a]b1[5[c]]1[d] => " +new No_934().DecodeString("3[a]b1[5[c]]1[d]"));
            #endregion
            #region No_399
            //No_399 _399 = new No_399();

            // Console.WriteLine(string.Join(",", _399.CalcEquation(new List<List<string>> { new List<string> { "x1", "x2" }
            //                                                     , new List<string> { "x2", "x3" }
            //                                                     , new List<string> { "x3", "x4" }
            //                                                     , new List<string> { "x4", "x5" }
            //                                                     }.ToArray()
            //                                     , new double[] { 3.0, 4.0, 5.0, 6.0 }
            //                                     , new List<List<string>> { new List<string> { "x1", "x5" }
            //                                                              , new List<string> { "x5", "x2" }
            //                                                              , new List<string> { "x2", "x4" }
            //                                                              , new List<string> { "x2", "x2" }
            //                                                              , new List<string> { "x2", "x9" }
            //                                                      }.ToArray())));
            // Console.WriteLine(string.Join(",", _399.CalcEquation(new List<List<string>> { new List<string> { "a", "b" }, new List<string> { "b", "c" } }.ToArray()
            //                                     , new double[] { 2.0, 3.0 }
            //                                     , new List<List<string>> { new List<string> { "a", "c" },new List<string> { "b", "a" }
            //                                     ,new List<string> { "a", "e" },new List<string> { "a", "a" },new List<string> { "x", "x" } }.ToArray())));

            // Console.WriteLine(string.Join(",", _399.CalcEquation(new List<List<string>> { new List<string> { "a", "b" }, new List<string> { "b", "c" } }.ToArray()
            //                                     , new double[] { 2.0, 3.0 }
            //                                     , new List<List<string>> { new List<string> { "b", "a" } }.ToArray())));
            #endregion
            #region No_1926



            //No_1926 _1926 = new No_1926();

            //test case 1
            // char[][] maze = {new char[]{'+','.','+','+','+'}
            //                 ,new char[]{'+','.','.','.','+'}
            //                 ,new char[]{'+','.','.','.','+'}
            //                 ,new char[]{'+','+','+','.','+'}};

            //test case 2
            //  char[][] maze = {new char[]{'+','.','+','+','+'}
            //                 ,new char[]{'+','.','.','.','+'}
            //                 ,new char[]{'.','.','.','.','+'}
            //                 ,new char[]{'+','+','+','+','+'}};

            // char[][] maze = new char[100][];

            // for (int i = 0; i < 100; i++){
            //     maze[i] = new char[100];
            //     for (int j = 0; j < 100; j++)
            //         maze[i][j] = '.';
            // }
            //     // Console.WriteLine($"Leetcode challenge No: 1926 \n TestCase: \n{string.Join("\n", maze.Select(x =>
            //     // {
            //     //     return string.Join(" ", x);
            //     // }))}");

            // Console.WriteLine($"Entrando en [50 , 50], Answer: {_1926.NearestExit(maze, new int[] { 50, 50 })}");
            // Console.ReadKey();
            // Console.WriteLine($"Entrando en [50 , 50], Answer: {_1926.NearestExit1(maze, new int[] { 50, 50 })}");


            //  List<int[]> a = new List<int[]>() { new int[] { 1, 2 }, new int[] { 3, 4 } };
            //  int[] b = { 1, 2 };
            //  int[] c = { 5, 6 };
            // Console.WriteLine($"a.Find(b): {a.Find(x => x[0] == b[0] && x[1] == b[1]) == null} A.Find(c): {a.Find(x => x[0] == c[0] && x[1] == c[1]) == null}");
            // Console.WriteLine($"a.Find(b): {a.First(x => x[0] == b[0] && x[1] == b[1]) == null} A.Find(c): {a.First(x => x[0] == c[0] && x[1] == c[1]) == null}");

            // Queue<int[]> z = new Queue<int[]>();
            //  z.Enqueue(new int[] { 9, 8 });

            // Console.WriteLine($"Queue contains [9,8] {z.Contains(new int[] { 9, 8 })} contains [7,8] {z.Contains(new int[] { 7, 8 })} ");
            #endregion
            #region No_957
            //No_957 _957 = new No_957();
            //Console.WriteLine(string.Join(",",_957.PrisonAfterNDays(new int[] { 1,1,0,1,1,0,0,1}, 14)));
            #endregion
            #region No_2542

            //No_2542 _2542 = new No_2542();
            //Console.WriteLine($"Test case : nums1: [2,1,14,12] nums2: [11,7,13,6]=> {_2542.MaxScore(new int[] { 2,1,14,12}, new int[] { 11,7,13,6 }, 3)} Expected : 168");
            //Console.WriteLine($"Test case : nums1: [4,2,3,1,1] nums2: [7,5,10,9,6]=> {_2542.MaxScore(new int[] { 4, 2, 3, 1, 1 }, new int[] { 7, 5, 10, 9, 6 }, 1)} Expected : 30");
            //Console.WriteLine($"Test case : nums1: [1,3,3,2] nums2: [2,1,3,4]=> {_2542.MaxScore(new int[] { 1,3,3,2}, new int[] { 2,1,3,4 }, 3)} Expected : 12");

            #endregion
            #region No_944

            // No_994 _994 = new No_994();
            // List<int[][]> testCases = new List<int[][]>{
            //     //TestCase 0
            //     new int[][]{new int[]{0}},
            //     //TestCase 1
            //     new int[][]{new int[]{1}},
            //     //TestCase 2
            //     new int[][]{new int[]{2}},
            //     //TestCase3x3Isla
            //     new int[][] { new int[] { 2, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } },
            //     //TestCase3x3ceros 
            //     new int[][]{ new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } },
            //     //TestCase3x3unos 
            //     new int[][]{ new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 } },
            //     //TestCase3x3dos 
            //     new int[][]{ new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 } },
            //     //TestCase3x3OK 
            //     new int[][]{ new int[] { 1, 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 1, 1, 1 } },
            //     //TestMultipleRott 
            //     new int[][]{new int[]{2,1,0,1,2},new int[]{1,0,0,0,1},new int[]{0,0,0,0,0},new int[]{1,0,0,0,1},new int[]{2,1,0,1,2}},
            //     //TestCaseWrongAnswer
            //     new int[][]{new int[]{2,2},new int[]{1,1},new int[]{0,0},new int[]{2,0}}};

            // foreach (var test in testCases)
            // {

            //     Console.WriteLine($"Test Case: \n{string.Join("\n", test.Select(x => string.Join(",", x)))}");
            //     Console.WriteLine($"Ans: {_994.OrangesRotting(test)}");
            //     //Console.ReadKey();
            // }

            #endregion
            #region No_2462
            // List<((int[], int), int)> testCases = new List<((int[], int), int)>{
            //     ((new int[]{211,169,4359,2335,3956,658,1371,1516,4637,2588,4166,250,4866,3122,1197,61,292,1616,4857,4067,1428,4912,3071,3108,2221,1932,4183,4101,727,
            //                 2715,64,357,1186,2444,3766,3978,1962,1648,871,2961,1164,4792,1528,2064,2653,179,2780,3732,2881,1165,623,362,2371,1353,4219,4438,3765,4567,
            //                 1372,4669,1496,3353,4147,33,4378,4634,1331,3014,3723,3271,433,1065,2345,4445,4077,2708,1303,2666,3311,1546,3078,4467,1683,414,4282,3510,478,
            //                 2858,4805,1113,783,3999,2685,1025,3111,2394,2985,2693,1068,1806,690,4867,4178,1726,1680,1860,155,96,1500,4250,286,4145,771,1728,2677,353,
            //                 1163,4876,2066,3910,2578,1298,3321,3236,1152,3140,2294,2200,69,3027,3675,3594,74,3575,2279,4874,1071,3085,1786,4596,1584,42,411,3962,2704,
            //                 4411,1926,1300,4533,2119,3924,1034,128,911,4717,4767,1669,3669,2936,2099,3395,2487,2539,4722,122,642,4680,4813,708,4938,4156,1152,2789,699,
            //                 4724,4159,1766,2662,492,2612,330,2010,458,161,794,2062,4281,717,3486,3331,474,4734,1869,4817,2796,1511,146,3857,3471,3674,45,519,3035,3830,
            //                 4566,957,4705,3194,1524,2668,903,2833,2118,929,266,1177,3297,1681,400,2635,1962,1682,2116,603,1521},222),2),

            //      ((new int[]{17,12,10,2,7,2,11,20,8},3),4),

            //     ((new int[]{1,2,4,1},3),3),

            //     ((new int[]{31,25,72,79,74,65,84,91,18,59,27,9,81,33,17,58}
            //                                                         ,11),2) };
            // No_2462 _2462 = new No_2462();
            // foreach (var test in testCases)
            // {
            //     Console.WriteLine($"Test Case: {string.Join(",", test.Item1.Item1)}, "
            //     +$"K = {test.Item1.Item2}, C = {test.Item2},"
            //     +$" Ans: {_2462.TotalCost(test.Item1.Item1, test.Item1.Item2, test.Item2)}");
            // }
            #endregion
            #region No_2300

            // List<(int[], (int[], int))> TestCases = new List<(int[], (int[], int))>{
            //     (new int[]{5,1,3},(new int[]{1,2,3,4,5},7)),
            //     (new int[]{3,1,2},(new int[]{8,5,8},16))
            // };

            // for (int i = 0; i < TestCases.Count; i++)
            // {
            //     Console.WriteLine($"spells: {string.Join(",", TestCases[i].Item1)},"
            //     + $" potions: {string.Join(",", TestCases[i].Item2.Item1)}"
            //     + $" Success: {TestCases[i].Item2.Item2}");
            //     Console.WriteLine($"Output: {string.Join(",", new No_2300().SuccessfulPairs(TestCases[i].Item1
            //                                                                                 , TestCases[i].Item2.Item1,
            //                                                                                 TestCases[i].Item2.Item2))}");
            //}
            #endregion
            #region No_162
            //     List<int[]> TestCases = new List<int[]>{new int[]{1,2,1,3,5,6,4},new int[]{2,1,3,1},
            //                                         new int[]{1,2,3,4,5},new int[]{5,4,3,2,1},
            //                                         new int[]{5,4,3,2,3,4,5}};

            // for (int i = 0; i < TestCases.Count; i++)
            // {
            //     Console.WriteLine($"Test Case : {string.Join(",", TestCases[i])}");
            //     Console.WriteLine($"Output: {new No_162().FindPeakElement(TestCases[i])}");
            // }
            #endregion
            #region No_875
                List<(int[],int)> TestCases = new List<(int[],int)>{(new int[]{873375536,395271806,617254718,970525912,634754347,824202576,694181619,20191396,886462834,442389139,572655464,438946009,791566709,776244944,694340852,419438893,784015530,588954527,282060288,269101141,499386849,846936808,92389214,385055341,56742915,803341674,837907634,728867715,20958651,167651719,345626668,701905050,932332403,572486583,603363649,967330688,484233747,859566856,446838995,375409782,220949961,72860128,998899684,615754807,383344277,36322529,154308670,335291837,927055440,28020467,558059248,999492426,991026255,30205761,884639109,61689648,742973721,395173120,38459914,705636911,30019578,968014413,126489328,738983100,793184186,871576545,768870427,955396670,328003949,786890382,450361695,994581348,158169007,309034664,388541713,142633427,390169457,161995664,906356894,379954831,448138536},943223529),
                                                        (new int[]{3,6,7,11},8),(new int[]{30,11,23,4,20},5),(new int[]{30,11,23,4,20},6)};

            foreach (var testData in TestCases)
            {
                Console.WriteLine($"Test case: {string.Join(",", testData.Item1)} h: {testData.Item2}");
                Console.WriteLine($"Output: {new No_875().MinEatingSpeed(testData.Item1, testData.Item2)}");
            }
            #endregion


            #region Otros

           // var test = new List<(int, int)> { (0, 0), (0, 1), (1, 0), (1, 1) };
           // Console.WriteLine($"Find (0,0): R/{test.IndexOf((0, 0))}, find (1,1) R/{test.IndexOf((1, 1))} find (2,2) R/{test.IndexOf((2, 2))}");

            //  int[] arr1 = { 3, 1, 4 };
            // Array.Sort(arr1, Comparer<int>.Create((x, y) => x.CompareTo(y) * -1));
            // Console.Write($"{string.Join(",", arr1)}");
            // Array.Sort(arr1);
            // Console.WriteLine($"=>{string.Join(",", arr1)}");
            // int[] arr2 = { 2, 5, 6 };

            // Console.WriteLine(string.Join(",", arr1) + " " + string.Join(",", arr2));

            // Array.Sort(arr1, arr2, Comparer<int>.Create((x, y) => x.CompareTo(y)));

            // Console.WriteLine(string.Join(",", arr1) + " " + string.Join(",", arr2));


            // arr1 = new int[] { 3, 1, 1 };
            // arr2 = new int[] { 2, 6, 5 };
            // Console.WriteLine(string.Join(",", arr1) + " " + string.Join(",", arr2));
           
            // Array.Sort(arr1, arr2, Comparer<int>.Create((x, y) =>
            // {
            //     Console.Write($"x: {x}, y: {y}");
            //     int idx = Array.IndexOf(arr1, x), idy = Array.IndexOf(arr1, y);
            //     int result = x.CompareTo(y);
            //     Console.Write($" R\\{result}");
            //     if (result == 0)
            //     {
                    
            //         Console.Write($" => {idx}: arr2[idx]: {arr2[idx]}, {idy}: arr2[idy]: {arr2[idy]}");
            //         result = arr2[idx].CompareTo(arr2[idy]);
            //         Console.Write($" R\\{result}");
            //     }
            //     Console.WriteLine();
            //     return result;
            // }));

            // Console.WriteLine(string.Join(",", arr1) + " " + string.Join(",", arr2));

            // PriorityQueue<int, int> p= new PriorityQueue<int, int>(10);

            // for (int i = 0; i < 10; i++)
            //     p.Enqueue(i, 10-i);
            // Console.WriteLine(string.Join(",", p.UnorderedItems));
            // Console.ReadKey();

            // while (p.Count != 0)
            //     Console.WriteLine($" {p.Dequeue()} => {(p.Count !=0 ? p.Peek():null)}");
            // Console.ReadKey();


            
            // int[] testcase =  { 1, 3, 3, 3, 5, 8 };

            // Console.WriteLine($"Array: {string.Join(",", testcase)}");
            // //Console.WriteLine($"Insert 2 => {string.Join(",", BinaryInsertion(testcase.ToList(), 2))}");
            // //Console.WriteLine($"Insert 3 => {string.Join(",", BinaryInsertion(testcase.ToList(), 3))}");
            // Console.WriteLine($"Insert 9 => {string.Join(",", BinaryInsertion(testcase.ToList(), 9))}");
            // Console.WriteLine($"Insert 0 => {string.Join(",", BinaryInsertion(testcase.ToList(), 0))}");




            // int[] nums ={3,2,4};
            // int[] Indexs = new int[nums.Length];
            // for (int i = 0; i < Indexs.Length; i++)
            //     Indexs[i] = i;
            // Console.WriteLine($"{string.Join(",", nums)} => {string.Join(",", Indexs)}");
            // Array.Sort(nums, Indexs);
            // Console.WriteLine($"{string.Join(",", nums)} => {string.Join(",", Indexs)}");

            // for (int i = 0; i < 10;i++)
            // Console.WriteLine(new string('+', 10));
            // Console.WriteLine((" I Love you").Replace(" ", "").Length);
            // Console.WriteLine((" ILove you").Replace(" ", "").Length);
            // Console.WriteLine((" ILoveyou").Replace(" ", "").Length);
            // Console.WriteLine(("ILoveyou").Replace(" ", "").Length);

            // List<int[]> a = new List<int[]>() { new int[] { 1, 2 }, new int[] { 3, 4 } };
            // int[] b = { 1, 2 };
            // int[] c = { 5, 6 };
            // Console.WriteLine(a.Contains(b));
            // Console.WriteLine(a.Select(x => x[0] == b[0] && x[1] == b[1]).Count()!=0);
            // Console.WriteLine(a.Count(x => x[0] == b[0] && x[1] == b[1]));
            // Console.WriteLine(a.Count(x => x[0] == c[0] && x[1] == c[1]));
            // Queue<int[]> z = new Queue<int[]>();
            // z.Enqueue(new int[] { 9, 8 });
            // while(z.Count(x=>x[0]==9 && x[1]==8)!=0){
            //     Console.WriteLine(string.Join(",", z.Dequeue()));
            //     //z.Enqueue(new int[] { 9, 5 });
            // }
            // Console.ReadKey();

            #endregion

        }

        // public static int[] BinaryInsertion(List<int> arr, int value)
        // {
        //      int i = 0, e = arr.Count - 1;
        // while(i < e){
        //     int m = (i + e)/2;
        //     if(arr[m] >= value)
        //         e = m - 1;
        //     else
        //         i = m + 1; 
        // } 

        // arr[i] = value;
        //     return arr.ToArray();
        // }

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
