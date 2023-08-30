namespace LeetCode
{
    class No_875
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
           if (h == piles.Length)
                return piles.Max();
            int i = 1, e = piles.Max();

            while (i <= e)
            {
                var target = (e + i) / 2;
                var cur = 0;
                var lapse = 0;
                while (cur < piles.Length && lapse < h)
                {
                    lapse +=( piles[cur] / target) + (piles[cur] % target == 0 ? 0 : 1);
                    cur++;
                }
                if (lapse <= h && cur==piles.Length)
                    e = target - 1;
                      else i = target + 1;

            }
            return i; 

        }

         public int MinEatingSpeed1(int[] piles, int h) {
           var l= 1;
        var r=piles.Max();
        while(l<=r){
            var m=(l+r)/2;
            if(CanEatAll(m))
                r=m-1;
            else
                l=m+1;
        }
        return l;

        bool CanEatAll(int k){
            long days=0;
            foreach(var pile in piles){
                days+=(int)Math.Ceiling((double)pile/k);
            }
            return days<=h;
        }
    }
    }
}