namespace LeetCode
{
    public class No_9{
        public bool IsPalindrome(int x)
        {
            char[] entrada = x.ToString().ToCharArray();
            bool palindromo = true;

            for (int i = 0; i < entrada.Length / 2; i++)
            {
                int j = entrada.Length - 1 - i;

                if (entrada[i] != entrada[j])
                {
                    palindromo = false;
                    break;
                }
            }
            return palindromo;
        }
    }
    
}