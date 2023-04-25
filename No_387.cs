using System.Runtime.InteropServices;

namespace LeetCode
{
    public class No_387
    {
        /// <summary>
        /// Runtime: 89 ms Beats: 43.41%, Memory: 47 MB Beats: 17.27%
        /// </summary>
        public int FirstUniqChar(string s)
        {

            int pos = -1;
            char[] s_array = s.ToCharArray();

            for (int i = 0; i < s_array.Length; i++)
            {
                if (s_array[i] != ' ')
                {
                    pos = i;
                    for (int j = i + 1; j < s_array.Length; j++)
                    {
                        if (s_array[i] == s_array[j])
                        {
                            pos = -1;
                            s_array[j] = ' ';
                        }
                    }
                    if (pos != -1)
                        return pos;
                }
            }
            return pos;
        }
        /// <summary>
        /// Runtime: 84ms Beats: 58.39%, Memory: 45.5mb Beats: 42.21%
        /// </summary>
        public int FirstUniqChar1(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                    map[s[i]]++;
                else
                    map.Add(s[i], 1);
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }
}