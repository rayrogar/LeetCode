namespace LeetCode{
    class No_1657
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();

            for (int i = 0; i < word1.Length; i++)
            {
                dic1[word1[i]] = !dic1.ContainsKey(word1[i]) ? 1 : dic1[word1[i]] + 1;
                dic2[word2[i]] = !dic2.ContainsKey(word2[i]) ? 1 : dic2[word2[i]] + 1;
            }
            // Console.WriteLine(string.Join(",", dic1.Values));
            //Console.WriteLine(string.Join(",",dic2.Values));
            int[] a = new int[dic1.Count];
            dic1.Values.CopyTo(a, 0);
            Array.Sort(a);
            int[] b = new int[dic2.Count];
            dic2.Values.CopyTo(b, 0);
            Array.Sort(b);
            //Console.WriteLine(string.Join(",", a));
            //Console.WriteLine(string.Join(",",b));

            return Enumerable.Sum(dic1.Keys, x => Convert.ToInt32(x)) == Enumerable.Sum(dic2.Keys, x => Convert.ToInt32(x)) && a.SequenceEqual(b);
        }
    }
}