namespace LeetCode
{
    class No_2390
    {
        public string RemoveStars(string s)
        {
            Stack<char> output = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
                if (s[i] != '*')
                {
                    output.Push(s[i]);
                }
                else
                {
                    output.Pop();
                }
            return string.Join("", output.Reverse());

        }
    }
}