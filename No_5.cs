namespace LeetCode
{
    public class No_5
    {
        public No_5(){

            Console.WriteLine("babad");
            Console.WriteLine(LongestPalindrome("babad"));
            Console.WriteLine("cbbd");
            Console.ReadKey();
            Console.WriteLine(LongestPalindrome("cbbd"));
            Console.ReadKey();
            Console.WriteLine("caabaab");
            Console.WriteLine(LongestPalindrome("caabaab"));
            Console.ReadKey();
            Console.WriteLine("xaabacxcabaaxcabaax");
            Console.WriteLine(LongestPalindrome("xaabacxcabaaxcabaax"));
            Console.ReadKey();
            Console.WriteLine("babaddtattarrattatddetartrateedredividerb");
            Console.WriteLine(LongestPalindrome("babaddtattarrattatddetartrateedredividerb"));
            Console.ReadKey();
        }

        /// <summary>
        /// Recursivo, se va en tiempor
        /// </summary>
        public string LongestPalindrome1(string s)
        { 
            if(s.Length==1)
                return s;

            bool pal = true;
            for (int i = 0; i < s.Length; i++)
                    {
                        if(s[i] != s[s.Length-1-i])
                         {
                            pal = false;
                            break;
                         }
                    }
            if(pal)
                return s;
            else{
                string a = LongestPalindrome1(s.Substring(1));
                string b = LongestPalindrome1(s.Substring(0, s.Length - 1));

                return (a.Length > b.Length) ? a : b;
            }
        }

        /// <summary>
        /// Variante iterativa con una matriz
        /// </summary>
        public string LongestPalindrome(string s)
        {
            int max = 0, a = 0, b = s.Length - 1;

            for (int i = 0; i < s.Length; i++)
            {
                if(max > s.Length-i)
                    break;
                for (int j = s.Length - 1; j >= i; j--)
                {
                    int c = 0, a1 = i, b1 = j;
                    while (a1 <= b1)
                    {
                        if (s[a1] == s[b1])
                        {
                            c += a1 == b1 ? 1 : 2;
                            a1++;
                            b1--;
                        }
                        else
                        {
                            c = 0;
                            break;
                        }
                    }
                    if (c > max)
                    {
                        max = c;
                        a = i;
                        b = j;
                    }
                }
            }

            return s.Substring(a, b - a + 1);
        }
    }
}