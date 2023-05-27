namespace LeetCode
{
    public class No_151
    {
        public string ReverseWords(string s)
        {
            int i = 0, e = 0;
            Stack<string> ans = new Stack<string>();
            while (e < s.Length)
            {
                while (i < s.Length && s[i] == ' ')
                    i++;
                e = i;
                string temp = "";
                while (e < s.Length && s[e] != ' ')
                {
                    temp += s[e].ToString();
                    e++;
                }
                if(temp.Length!=0);
                ans.Push(temp);
                i = e;
            }
            return string.Join(' ', ans);
        }
    }
}