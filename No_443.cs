namespace LeetCode
{
    class No_443
    {
        public int Compress(char[] chars)
        {
            string cad = string.Join("", chars);
            int p = 0, l = 0, t = 0, c = 0;

            while (t < cad.Length)
            {
                if (p < cad.Length && cad[p] == cad[t])
                {
                    c++;
                    p++;
                }
                else
                {
                    chars[l] = cad[t];
                    l++;
                    if (c > 1)
                    {
                        Array.Copy(c.ToString().ToCharArray(), 0, chars, l, c.ToString().Length);
                        l += c.ToString().Length;
                    }
                    c = 0;
                    t = p;
                }
            }
            return l;
        }
    }
}