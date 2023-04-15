/*
Given a string s, find the longest palindromic subsequence's length in s.

A subsequence is a sequence that can be derived from another sequence by deleting some or no elements without changing the order of the remaining elements.

 

Example 1:

Input: s = "bbbab"
Output: 4
Explanation: One possible longest palindromic subsequence is "bbbb".

Example 2:

Input: s = "cbbd"
Output: 2
Explanation: One possible longest palindromic subsequence is "bb".
 

Constraints:

1 <= s.length <= 1000
s consists only of lowercase English letters.
*/
using System.Formats.Tar;

namespace LeetCode
{
    public class No_516
    {

        public No_516()
        {
             Console.WriteLine("Given a string s, find the longest palindromic subsequence's length in s.\nA subsequence is a sequence that can be derived from another sequence by deleting some or no elements without changing the order of the remaining elements.\n\nExample 1:\n\nInput: s = 'bbbab'\nOutput: 4\nExplanation: One possible longest palindromic subsequence is 'bbbb'.");
             Console.WriteLine("Real: " + LongestPalindromeSubseq("bbbab"));

            // Console.WriteLine("\nExample 2:\n\nInput: s = 'cbbd'\nOutput: 2\nExplanation: One possible longest palindromic subsequence is 'bb'.\n");
            // Console.WriteLine("Real: " + LongestPalindromeSubseq("cbbd"));

            // Console.WriteLine("\nExample 3:\n\nInput: s = 'abcabcdcbadcba'\nOutput: 13");
            // Console.WriteLine("Real: " + LongestPalindromeSubseq("abcabcdcbadcba"));

            // Console.WriteLine("\nExample 4:\n\nInput: s = 'caabaab'\nOutput: 5");
            // Console.WriteLine("Real: " + LongestPalindromeSubseq("caabaab"));

            //Console.WriteLine("\nExample 5:\n\nInput: s = 'xaabacxcabaaxcabaax'\nOutput: 17");
            //Console.WriteLine("Real: " + LongestPalindromeSubseq("xaabacxcabaaxcabaax"));

            Console.WriteLine("\nExample 5:\n\nInput: s = 'euazbipzncptldueeuechubrcourfpftcebikrxhybkymimgvldiwqvkszfycvqyvtiwfckexmowcxztkfyzqovbtmzpxojfofbvwnncajvrvdbvjhcrameamcfmcoxryjukhpljwszknhiypvyskmsujkuggpztltpgoczafmfelahqwjbhxtjmebnymdyxoeodqmvkxittxjnlltmoobsgzdfhismogqfpfhvqnxeuosjqqalvwhsidgiavcatjjgeztrjuoixxxoznklcxolgpuktirmduxdywwlbikaqkqajzbsjvdgjcnbtfksqhquiwnwflkldgdrqrnwmshdpykicozfowmumzeuznolmgjlltypyufpzjpuvucmesnnrwppheizkapovoloneaxpfinaontwtdqsdvzmqlgkdxlbeguackbdkftzbnynmcejtwudocemcfnuzbttcoew'\nOutput: 159");
            Console.WriteLine("Real: " + LongestPalindromeSubseq("euazbipzncptldueeuechubrcourfpftcebikrxhybkymimgvldiwqvkszfycvqyvtiwfckexmowcxztkfyzqovbtmzpxojfofbvwnncajvrvdbvjhcrameamcfmcoxryjukhpljwszknhiypvyskmsujkuggpztltpgoczafmfelahqwjbhxtjmebnymdyxoeodqmvkxittxjnlltmoobsgzdfhismogqfpfhvqnxeuosjqqalvwhsidgiavcatjjgeztrjuoixxxoznklcxolgpuktirmduxdywwlbikaqkqajzbsjvdgjcnbtfksqhquiwnwflkldgdrqrnwmshdpykicozfowmumzeuznolmgjlltypyufpzjpuvucmesnnrwppheizkapovoloneaxpfinaontwtdqsdvzmqlgkdxlbeguackbdkftzbnynmcejtwudocemcfnuzbttcoew"));

        }


        public int LongestPalindromeSubseq(string s){

            int[,] matriz = new int[s.Length,s.Length];

            for (int i = s.Length-1; i >= 0; i--)
            {
                matriz[i, i] = 1;

                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        matriz[i, j] = matriz[i + 1, j - 1] + 2;
                        else matriz[i, j] = (matriz[i + 1, j] > matriz[i, j - 1]) ? matriz[i + 1, j] : matriz[i, j - 1];
                }

            }

            return matriz[0, s.Length - 1];

        }
        
        public int LongestPalindromeSubseq2(string s)
        {
            int c = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                int start = i, end = s.Length - 1, c1 = 0;
                int start1 = s.Length - 1, end1 = i, c2 = 0;

                while (start <= end)
                {
                   // Console.WriteLine("i: {0},s: {1}, e: {2}, c1: {3}, c: {4}", i, start, end, c1, c);
                    //Console.ReadKey();
                    if (s[start] == s[end])
                    {
                        c1 += (start == end) ? 1 : 2;
                        start++;
                        end--;
                    }
                    else {
                            start1 = start;
                            end1 = end;

                            while (start <= end1)
                            {
                                if(s[start] != s[end1])
                                    end1--;
                                    else break;

                        } 
                            while (start1 <= end)
                            {
                                if(s[start1] !=s [end])
                                    start1++;
                                    else break;
                        }

                            if((end - end1) < (start1 - start))
                                end = end1;
                            else
                                start = start1;
                    }

                }
                if(c1 > c)
                    c = c1;

            }

            return c;
        }

        public int LongestPalindromeSubseq1(string s)
        {
            int c = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                int start = i, end = s.Length - 1, c1 = 0;

                while (start <= end)
                {
                    //Console.WriteLine("i: {0},s: {1}, e: {2}, c1: {3}, c: {4}", i, start, end, c1, c);
                    //Console.ReadKey();
                    if (s[start] == s[end])
                    {
                        c1 += (start == end) ? 1 : 2;
                        start++;
                        end--;
                    }
                    else
                    {
                        end--;
                       
                    }
                }
                if (c1 > c)
                    c = c1;

            }

            for (int i = s.Length - 1; i > 0; i--)
            {
                int start = i, end = 0, c1 = 0;

                while (start >= end)
                {

                   // Console.WriteLine("i: {0},s: {1}, e: {2}, c1: {3}, c: {4}", i, start, end, c1, c);
                   // Console.ReadKey();
                    if (s[start] == s[end])
                    {
                        c1 += (start == end) ? 1 : 2;
                        start--;
                        end++;
                    }
                    else
                    {
                        end++;
                       
                    }
                }
                if (c1 > c)
                    c = c1;

            }


            return c;
        }
    }

}