using System.Text;

namespace LeetCode{
    public class No_1071
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string s = str1.Length > str2.Length ? str2 : str1,
            b = str1.Length > str2.Length ? str1 : str2;

            if(new StringBuilder(b.Length / s.Length).Insert(0,s,b.Length / s.Length).ToString() == b)
                return s;

            string sl = s.Substring(0, s.Length / 2);

            do
            {
                if (new StringBuilder(s.Length / sl.Length).Insert(0, sl, s.Length / sl.Length).ToString() == s &&
                        new StringBuilder(b.Length / sl.Length).Insert(0, sl, b.Length / sl.Length).ToString() == b)
                    return sl;
                sl = sl.Substring(0, sl.Length - 1);
                //GC.Collect(); //Costosísimo en tiempo
            } while (sl.Length >= 1);
            return "";
        }
    }
}