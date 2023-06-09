namespace LeetCode
{
    public class No_744
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int i = 0, e = letters.Length - 1, m = -1;
            while (i < e)
            {
                m = (i + e) / 2;

                if (letters[i] == target)
                    m = i;
                else if (letters[e] == target)
                    m = e;
                if (letters[m] == target)
                {
                    while (m + 1 < letters.Length && letters[m + 1] == target)
                        m++;
                    return m + 1 < letters.Length ? letters[m + 1] : letters[0];
                }
                if (letters[m] > target)
                    e = m - 1;
                else
                    i = m + 1;
            }
            //Console.WriteLine("i: " + i);
            if ((i == 0 || i == letters.Length - 1) && letters[i] > target)
                return letters[i];
            if (i < letters.Length - 1)
                return letters[i] < target ? letters[i + 1] : letters[i];
            return letters[0];

        }
    }
}
