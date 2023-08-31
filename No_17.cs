namespace LeetCode
{
    class No_17
    {
        public IList<string> LetterCombinations(string digits)
        {

            List<string> output = new List<string>();
            List<string> temp = new List<string>();
            if (digits.Length != 0)
            {
                Dictionary<char, List<char>> clave = new Dictionary<char, List<char>>{
                {'2',new List<char>{'a','b','c'}},
                {'3',new List<char>{'d','e','f'}},
                {'4',new List<char>{'g','h','i'}},
                {'5',new List<char>{'j','k','l'}},
                {'6',new List<char>{'m','n','o'}},
                {'7',new List<char>{'p','q','r','s'}},
                {'8',new List<char>{'t','u','v'}},
                {'9',new List<char>{'w','x','y','z'}}};


                for (int i = 0; i < digits.Length; i++)
                {
                    clave[digits[i]].ForEach(x =>
                    {
                        output.ForEach(y => { temp.Add(y + x); });
                    });
                    output = temp;
                    temp = new List<string>();
                }
            }
            return output;
        }
    }
}