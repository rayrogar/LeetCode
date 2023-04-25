using System.Runtime.InteropServices;

namespace LeetCode
{
    public class No_387
    {
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
    }
}