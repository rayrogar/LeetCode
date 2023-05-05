namespace LeetCode
{
    public class No_1456
    {

        public int MaxVowels(string s, int k)
        {
            int max = 0;

            var cad = s.ToCharArray();

            for (int i = 0; i < k; i++)
                if (cad[i] == 'a' || cad[i] == 'e' || cad[i] == 'i' || cad[i] == 'o' || cad[i] == 'u')
                    max++;

            int e = k - 1, m = max;

            while (e < s.Length - 1)
            {
                e++;
                if (cad[e - k] == 'a' || cad[e - k] == 'e' || cad[e - k] == 'i' || cad[e - k] == 'o' || cad[e - k] == 'u')
                    m--;
                if (cad[e] == 'a' || cad[e] == 'e' || cad[e] == 'i' || cad[e] == 'o' || cad[e] == 'u')
                    m++;

                if (m > max)
                    max = m;
            }
            return max;
        }

        /// <summary>
        /// Time Limit Exceded
        /// </summary>
        public int MaxVowels1(string s, int k)
        {
            int max = 0;

            var cad = s.ToCharArray();

            for (int i = 0; i <= cad.Length - k; i++)
            {
                var c = 0;
                for (int j = i; j < i + k; j++)
                {
                    if (cad[j] == 'a' || cad[j] == 'e' || cad[j] == 'i' || cad[j] == 'o' || cad[j] == 'u')
                        c++;
                }
                if (c > max)
                    max = c;
            }
            return max;
        }
    }
}