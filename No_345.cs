namespace LeetCode
{
    public class No_345
    {
        public string ReverseVowels(string s)
        {
            char[] vowels = new char[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'U', 'U' };
            char[] _s = s.ToArray();
            int i = 0, e = s.Length - 1;
            while (i < e)
            {
                if (vowels.Contains(s[i]))
                {
                    while (e > i)
                    {
                        if (vowels.Contains(_s[e]))
                        {
                            var t = _s[i];
                            _s[i] = _s[e];
                            _s[e] = t;
                            break;
                        }
                        e--;
                    }
                }
                i++;
            }
            return string.Join(string.Empty, _s);
        }
    }
}