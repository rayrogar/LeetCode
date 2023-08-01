using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCode
{
    class No_934
    {
        public string DecodeString(string s)
        {
            string output = "";
            int m = -1;
            if (s.Length == 1 && int.TryParse(s, out m) && m == 0)
                return output;
                
                for(int i = 0; i < s.Length; i++){
                    if(int.TryParse(s[i].ToString(), out m)){
                        string rep = s[i].ToString();
                        int j = ++i;
                        
                        while(int.TryParse(s[j].ToString(), out m))
                            rep += s[j++].ToString();
                        
                        m = int.Parse(rep);
                    int o = 1, c = 0;
                    i = ++j;

                    while (o > c)
                    {
                        //if(s[j] != '[' && s[j] != ']')
                        //  rep += s[j].ToString();
                        //else 
                        if (s[j] == '[')
                            o++;
                        else if (s[j] == ']')
                            c++;
                        j++;
                    }

                    string sub=DecodeString(s.Substring(i,j - (i + 1)));
                        for(int r = 0; r < m; r++)
                            output+= sub;
                      i = j - 1;  
                    }
                    else
                        output += s[i].ToString();
                }
           return output;
        }

        public string DecodeString1(string s)
        {
             int m = -1, o = 0;
            string output = "";
            if (s.Length == 1 && int.TryParse(s, out m) && m == 0)
                return output;
            for (int i = 0; i < s.Length; i++)
            {
                if (int.TryParse(s[i].ToString(), out m))
                {
                    o = s.IndexOf('[', o + 1);
                    int c = s.IndexOf(']', o);
                    string temp = DecodeString1(s.Substring(o + 1, c - (o + 1)));
                    for (int j = 0; j < m; j++)
                        output += temp;
                    i = c;
                    o = c;
                }
                else
                    output += s[i].ToString();
            }

            return output;
        }
    }
}