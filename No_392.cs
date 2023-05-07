using System.Security.Cryptography;

namespace LeetCode
{
    public class No_392
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length > t.Length)
                return false;
            int p = 0, p1 = 0;

            while (p1 < s.Length && p < t.Length)
            {
                if (s[p1] == t[p])
                    p1++;
                p++;
            }
            return p1 == s.Length;
        }
    }
}