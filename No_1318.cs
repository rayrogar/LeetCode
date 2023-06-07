using System.Numerics;

namespace LeetCode
{
    public class No_1318
    {
        /// <summary>
        /// Using Bit Manipulation. More Logical Solution
        /// </summary>
        public int MinFlips(int a, int b, int c)
        {
            int ans = 0;
            while (a != 0 | b != 0 | c != 0)
            {
                 if ((c & 1) == 1)
                {
                    if ((a & 1) != 1 && (b & 1) != 1)
                        ans++;
                }
                else
                {
                    if ((a & 1) != 0)
                        ans++;
                    if ((b & 1) != 0)
                        ans++;
                }
                a = a >> 1; b = b >> 1; c = c >> 1;
            }
            return ans;
        }
        public int MinFlips2(int a, int b, int c)
        {
            char[] _a = intTobinInverse(a), _b = intTobinInverse(b), _c = intTobinInverse(c);
            int count = 0, n = Math.Max(_c.Length, Math.Max(_a.Length, _b.Length));
            char target = '2';

            Console.WriteLine(string.Join(string.Empty, _a));
            Console.WriteLine(string.Join(string.Empty, _b));
            Console.WriteLine(string.Join(string.Empty, _c));

            for (int i = 0; i < n; i++)
            {
                if (i > _c.Length - 1) target = '0';
                else
                    target = _c[i];
                Console.Write(target + " : ");
                if (target == '1')
                {
                    if (i > _b.Length - 1 || _b[i] != '1')
                        if (i > _a.Length - 1 || _a[i] != '1')
                            count++;
                }
                else
                {
                    if (i < _a.Length && _a[i] != '0')
                        count++;
                    if (i < _b.Length && _b[i] != '0')
                        count++;
                }
                Console.WriteLine(count);
            }

            return count;
        }

        public char[] intTobinInverse(int num)
        {
            string cad = "";
            while (num > 0)
            {
                cad += (num % 2).ToString();
                num /= 2;
            }
            return cad.ToCharArray();
        }
    }
}