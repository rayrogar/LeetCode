namespace LeetCode
{
    class No_2300
    {
         public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {

           Array.Sort(potions);
            for (int i = 0; i < spells.Length; i++)
            {
                int val = spells[i];
                spells[i] = CountSuccess(val, potions, success);
            }
            return spells;
    }

        private int CountSuccess(int val, int[] potions, long success)
        {
            int i = 0, e = potions.Length-1, m = -1;

            while (i < e)
            {
                m = (e + i) / 2;
                
                if ((long)val * potions[m] >= success)
                    e = m - 1;
                else i = m + 1;
            }
            return potions.Length - i + ((long)val * potions[i] >= success ? 0 : -1);
        }
    }
}