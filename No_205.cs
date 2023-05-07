using System.Buffers;

namespace LeetCode
{
    public class No_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> f = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (f.ContainsKey(s[i]))
                {
                    if (f[s[i]] != t[i])
                        return false;
                }
                else if (f.ContainsValue(t[i]))
                    return false;
                else
                    f.Add(s[i], t[i]);
            }
            return true;
        }
    }
}