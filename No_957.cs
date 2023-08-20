namespace LeetCode
{
    class No_957
    {
        public int[] PrisonAfterNDays(int[] cells, int n) {
            int c = n % 14;
          if(c == 0)
            c = 14;
            while(c-- > 0)
       {
           int i = 1,t = cells[0];
           while(i++ < 7){
                    int t1 = t;
                    t = cells[i - 1];
                    cells[i - 1] = cells[i] == t1 ? 1 : 0;
                }
                cells[0]=0;
                cells[7] = 0;
                Console.WriteLine($"n: {c} => {string.Join(",", cells)}");
            }
            
            return cells;
        }
    }
}