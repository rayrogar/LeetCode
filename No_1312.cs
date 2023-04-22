namespace LeetCode
{
    public class No_1312{

        public int MinInsertions(string s)
        {
            int[,] matriz = new int[s.Length, s.Length];

            for (int i = s.Length - 1; i >= 0; i--)
            {
                matriz[i, i] = 1;

                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        matriz[i, j] = matriz[i + 1, j - 1] + 2;
                    else matriz[i, j] = (matriz[i + 1, j] > matriz[i, j - 1]) ? matriz[i + 1, j] : matriz[i, j - 1];
                }

            }

            return s.Length - matriz[0, s.Length - 1];
        }
        public int MinInsertions2(string s)
        {
            int c = 0, c1 = 0, i = 0, f = s.Length - 1;

            while (i<f)
            {
                if (s[i] != s[f])
                    c++;
                else
                    f--;
                i++;
            }
            i = s.Length;
            f = 0;
            while (i < f)
            {
                if (s[i] != s[f])
                    c1++;
                else
                    f++;
                i--;
            }

            return c > c1 ? c : c1;
        }

        public int MinInsertions1(string s)
        {
            Dictionary<char, int> r = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (r.ContainsKey(s[i]))
                    r[s[i]]++;
                else r.Add(s[i], 1);
            }

            int c = 0;

            foreach (var item in r)
                if (item.Value % 2 != 0)
                    c++;

            return c - 1;
        }
    }
}