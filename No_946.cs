/*
Given two integer arrays pushed and popped each with distinct values, return true if this could have been the result of a sequence of push and pop operations on an initially empty stack, or false otherwise.

 

Example 1:

Input: pushed = [1,2,3,4,5], popped = [4,5,3,2,1]
Output: true
Explanation: We might do the following sequence:
push(1), push(2), push(3), push(4),
pop() -> 4,
push(5),
pop() -> 5, pop() -> 3, pop() -> 2, pop() -> 1
Example 2:

Input: pushed = [1,2,3,4,5], popped = [4,3,5,1,2]
Output: false
Explanation: 1 cannot be popped before 2.
 

Constraints:

1 <= pushed.length <= 1000
0 <= pushed[i] <= 1000
All the elements of pushed are unique.
popped.length == pushed.length
popped is a permutation of pushed.
*/

using System.Collections;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

namespace LeetCode
{
    public class No_946{

        public No_946(){
            Console.WriteLine("Casos de estudio");
            Console.WriteLine("\nExample 1:\n\nInput: pushed = [1,2,3,4,5], popped = [4,5,3,2,1]\npush(1), push(2), push(3), push(4),pop()-> 4,push(5),pop()-> 5, pop()-> 3, pop()-> 2, pop()-> 1\nOutput: true");
            Console.WriteLine("Real: {0}", ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 }));
            Console.ReadKey();

            /////////===============================///////===============================================================////
            Console.WriteLine("Example 2:\nInput: pushed = [1,2,3,4,5], popped = [4,3,5,1,2]\nOutput: false\nExplanation: 1 cannot be popped before 2.");
            Console.WriteLine("Real: {0}", ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 1, 2 }));
            Console.ReadKey();

            /////////===============================///////===============================================================////
            Console.WriteLine("Example 2:\nInput: pushed = [1,2,3,4,1,5], popped = [4,3,5,1,2,1]\nOutput: false");
            Console.WriteLine("Real: {0}", ValidateStackSequences(new int[] { 1, 2, 3, 4, 1, 5 }, new int[] { 4, 3, 5, 1, 2, 1 }));
            Console.ReadKey();

            /////////===============================///////===============================================================////
            Console.WriteLine("Example 2:\nInput: pushed = [1,2,3,4,1,5], popped = [4,3,5,1,2,1]\nOutput: false");
            Console.WriteLine("Real: {0}", ValidateStackSequences(new int[] { 1, 2, 3, 4, 6, 5 }, new int[] { 4, 3, 5, 1, 2, 6 }));
            Console.ReadKey();

            /////////===============================///////===============================================================////
            Console.WriteLine("Example 2:\nInput: pushed = [0,2,1], popped = [0,1,2]\nOutput: true");
            Console.WriteLine("Real: {0}", ValidateStackSequences(new int[] { 0,2,1 }, new int[] { 0,1,2 }));
            Console.ReadKey();

            /////////===============================///////===============================================================////
            Console.WriteLine("Example 2:\nInput: pushed = [1,2,1,2,1,2], popped = [2,1,2,1,2,1]\nOutput: true");
            Console.WriteLine("Real: {0}", ValidateStackSequences(new int[] { 1, 2, 1, 2, 1, 2 }, new int[] { 2, 1, 2, 1, 2, 1 }));
            Console.ReadKey();
        }
        /// <summary>
        /// Runtime: 109ms Beats: 26.92% Memory: 42.1MB Beats: 88.46%
        /// </summary>
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            
            int i = -1, o = 0;
            for (int j = 0; j < pushed.Length; j++)
            {
              if(pushed[j]==popped[o])
                    o++;
                else {
                    i++;
                    pushed[i] = pushed[j];
                    
                }

                while (i > -1 && o < popped.Length && pushed[i] == popped[o] )
                {
                    o++;
                    i--;
                }
            }

            return o == popped.Length;
        }
        /// <summary>
        /// Runtime: 100ms Beats: 76.92% Memory: 42.2MB Beats: 88.46%
        /// </summary>
        public bool ValidateStackSequences1(int[] pushed, int[] popped)
        {
            List<int> tnq = new List<int>();
            int i = 0, o = 0;
            while (i < pushed.Length || o < popped.Length)
            {
                while (o < popped.Length && tnq.Count != 0)
                {
                            if(popped[o]==tnq[tnq.Count-1]){
                                tnq.RemoveAt(tnq.Count-1);
                                o++;
                                } else break;
                    }
                if(i < pushed.Length){
                     tnq.Add(pushed[i]);
                     i++;

                }else if(o < popped.Length)
                    return false;

            }
            return true;
        }

    }
    
}