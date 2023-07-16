namespace LeetCode
{
    class No_443
    {
        public int Compress(char[] chars)
        {
            int p = 0, l = 0, t = 0, c = 0;

            while (t < chars.Length)
            {
                if (p < chars.Length && chars[p] == chars[t])
                { c++; p++; }
                else
                {
                    chars[l] = chars[t];
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