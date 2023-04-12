/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.
*/
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace LeetCode
{
    public class No_383{

        public No_383(){
            Console.WriteLine("Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.");
            Console.WriteLine("Each letter in magazine can only be used once in ransomNote.");
            Console.WriteLine("Example 1:");
            Console.WriteLine();
            Console.WriteLine("Input: ransomNote = 'a', magazine = 'b'");
            Console.WriteLine("Output: false");
            Console.WriteLine("Real: " + CanConstruct("a", "b"));

            ///===================================================////========================================================///
            Console.WriteLine();
            Console.WriteLine("Example 2:");
            Console.WriteLine();
            Console.WriteLine("Input: ransomNote = 'aa', magazine = 'ab'");
            Console.WriteLine("Output: false");
            Console.WriteLine("Real: " + CanConstruct("aa", "ab"));

            ///===================================================////========================================================///
            Console.WriteLine();
            Console.WriteLine("Example 3:");
            Console.WriteLine();
            Console.WriteLine("Input: ransomNote = 'aa', magazine = 'aab'");
            Console.WriteLine("Output: true");
            Console.WriteLine("Real: " + CanConstruct("aa", "aab"));

            ///===================================================////========================================================///
            Console.WriteLine();
            Console.WriteLine("Example 41/128:");
            Console.WriteLine();
            Console.WriteLine("Input: ransomNote = 'bg', magazine = 'efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj'");
            Console.WriteLine("Output: true");
            Console.WriteLine("Real: " + CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));

            ///===================================================////========================================================///
            Console.WriteLine();
            Console.WriteLine("Example 126 / 128:");
            Console.WriteLine();
            Console.WriteLine("Input: ransomNote = 'fihjjjjei', magazine = 'hjibagacbhadfaefdjaeaebgi'");
            Console.WriteLine("Output: false");
            Console.WriteLine("Real: " + CanConstruct("fihjjjjei", "hjibagacbhadfaefdjaeaebgi"));

            Console.ReadKey();
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            if(ransomNote.Length > magazine.Length)
                return false;
            char[] rasom_note = ransomNote.ToCharArray();
            char[] _magazine = magazine.ToCharArray();
            Array.Sort(rasom_note);
            Array.Sort(_magazine);
            int p = -1;
            for (int i = 0; i < rasom_note.Length; i++)
            { bool f = false;
                while ( p < _magazine.Length-1)
                    {
                        p++;
                        if(rasom_note[i]==_magazine[p])
                            {
                                f = true;
                                break;
                            }
                    }
                if (!f)
                    return false;
            }

            return true;

        }
    }
    
}