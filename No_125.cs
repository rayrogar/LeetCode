/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
 

Constraints:

1 <= s.length <= 2 * 105
s consists only of printable ASCII characters.
*/
namespace LeetCode
{
    public class No_125{
        public bool IsPalindrome(string s)
        {
            char[] entrada = s.ToLower().Replace(" ", String.Empty).Replace(":", String.Empty)
                             .Replace(",", String.Empty).Replace(";", String.Empty).Replace(".", String.Empty)
                             .Replace("-", String.Empty).Replace("*", String.Empty).Replace("+", String.Empty)
                             .Replace("/", String.Empty).Replace("@", String.Empty).Replace("!", String.Empty)
                             .Replace("#", String.Empty).Replace("$", String.Empty).Replace("%", String.Empty)
                             .Replace("^", String.Empty).Replace("&", String.Empty).Replace("(", String.Empty)
                             .Replace(@")", String.Empty).Replace("_", String.Empty).Replace("=", String.Empty)
                             .Replace(@"[", String.Empty).Replace(@"]", String.Empty).Replace(@"{", String.Empty)
                             .Replace(@"}", String.Empty).Replace("\"", String.Empty).Replace("\'", String.Empty)
                             .Replace("\\", String.Empty).Replace("|", String.Empty).Replace("?", String.Empty)
                             .Replace("<", String.Empty).Replace(">", String.Empty).Replace("¿", String.Empty)
                             .Replace("!", String.Empty).Replace("`", String.Empty).ToCharArray();


            bool palindromo = true;

            for (int i = 0; i < entrada.Length / 2; i++)
            {
                int j = entrada.Length - 1 - i;

                if (entrada[i] != entrada[j])
                {
                    palindromo = false;
                    break;
                }
                if (entrada.Length % 2 != 0 && i == j)
                    break;
                else if (entrada.Length % 2 == 0 && i == (j - 1))
                    break;
            }
            return palindromo;
        }
    }
    
}