using System.Globalization;

namespace LeetCode
{
    public class No_649
    {
        public No_649()
        {
            Console.WriteLine(PredictPartyVictory("RDDRD"));
            Console.WriteLine(PredictPartyVictory("RD"));
        }

        public string PredictPartyVictory(string senate)
        {
            int i = 0;
            if (senate.Length > 1)
            {
                char[] sen = senate.ToCharArray();
                int j = -1;
                while (i != j)
                {
                    Console.WriteLine("1- i: {0}, sen: {1}", i, string.Join(string.Empty, sen));
                    Console.ReadKey();

                    while (sen[i] != 'D' && sen[i] != 'R')
                        i = i != sen.Length - 1 ? i + 1 : 0;

                    Console.WriteLine("2- i: {0}, sen: {1}", i, string.Join(string.Empty, sen));
                    Console.ReadKey();

                    //j = i < sen.Length - 2 ? i + 1 : 0;
                    j = i;
                    while (sen[i] == sen[j] || (sen[j] != 'D' && sen[j] != 'R'))
                    {
                        j = j != sen.Length - 1 ? j + 1 : 0;
                        if (j == i)
                            return senate[i] == 'D' ? "Dire" : "Radiant";

                    }

                    Console.WriteLine("3- i: {0}, j:{2}, sen: {1}", i, string.Join(string.Empty, sen), j);
                    Console.ReadKey();

                    sen[j] = (char)(sen[j] + 32);
                    i = i != sen.Length - 1 ? i + 1 : 0;
                    j = -1;

                    Console.WriteLine("4- i: {0}, j:{2}, sen: {1}", i, string.Join(string.Empty, sen), j);
                    Console.ReadKey();
                }
            }

            return senate[i] == 'D' ? "Dire" : "Radiant";
        }

        public string PredictPartyVictory1(string senate)
        {

            List<char> sen = senate.ToList();
            bool win = false;

            while (!win)
            {
                win = true;
                for (int i = 0; i < sen.Count; i++)
                {
                    for (int j = (i == sen.Count - 1 && i != 0) ? 0 : i + 1; j < sen.Count; j++)
                    {
                        if (sen[i] == 'D' && sen[j] != 'D' || sen[i] == 'R' && sen[j] != 'R')
                        {
                            win = false;
                            //sen.RemoveAt(j);
                            sen[j] = 'd';
                            break;
                        }
                    }
                    if (win && i == 0)
                        break;
                    else win = false;

                }

                //return string.Format("win: {0}, sen: {1}", win, string.Join(string.Empty, sen));
            }

            return sen[0] == 'D' ? "Dire" : "Radiant";
        }
    }
}