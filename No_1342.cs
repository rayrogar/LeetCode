/*
Given an integer num, return the number of steps to reduce it to zero.

In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.

 

Example 1:

Input: num = 14
Output: 6
Explanation: 
Step 1) 14 is even; divide by 2 and obtain 7. 
Step 2) 7 is odd; subtract 1 and obtain 6.
Step 3) 6 is even; divide by 2 and obtain 3. 
Step 4) 3 is odd; subtract 1 and obtain 2. 
Step 5) 2 is even; divide by 2 and obtain 1. 
Step 6) 1 is odd; subtract 1 and obtain 0.
Example 2:

Input: num = 8
Output: 4
Explanation: 
Step 1) 8 is even; divide by 2 and obtain 4. 
Step 2) 4 is even; divide by 2 and obtain 2. 
Step 3) 2 is even; divide by 2 and obtain 1. 
Step 4) 1 is odd; subtract 1 and obtain 0.
Example 3:

Input: num = 123
Output: 12
 

Constraints:

0 <= num <= 10^6
*/

namespace LeetCode{
    public class No_1342{

        public No_1342(){

            Console.WriteLine("Given an integer num, return the number of steps to reduce it to zero.");
            Console.WriteLine("In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.");
            Console.WriteLine("Example 1:");
            Console.WriteLine("Input: num = 14");
            Console.WriteLine("Output: 6");
            Console.WriteLine("Explanation:");
            Console.WriteLine("Step 1) 14 is even; divide by 2 and obtain 7.");
            Console.WriteLine("Step 2) 7 is odd; subtract 1 and obtain 6.");
            Console.WriteLine("Step 3) 6 is even; divide by 2 and obtain 3.");
            Console.WriteLine("Step 4) 3 is odd; subtract 1 and obtain 2.");
            Console.WriteLine("Step 6) 1 is odd; subtract 1 and obtain 0.");
            Console.WriteLine("Real: " + NumberOfSteps(14));
            Console.WriteLine("Real: " + NumberOfSteps1(14));

            //===================================================////========================================================///
            Console.WriteLine("Example 2:");
            Console.WriteLine("Input: num = 8");
            Console.WriteLine("Output: 4");
            Console.WriteLine("Real: " + NumberOfSteps(8));
            Console.WriteLine("Real: " + NumberOfSteps1(8));

            //===================================================////========================================================///
            Console.WriteLine("Example 3:");
            Console.WriteLine("Input: num = 123");
            Console.WriteLine("Output: 12");
            Console.WriteLine("Real: " + NumberOfSteps(123));
            Console.WriteLine("Real: " + NumberOfSteps1(123));

        }

        public int NumberOfSteps(int num)
        {
            int c = 0;
            while(num>0){
                num=(num % 2 == 0) ? num / 2 : num-1;
                c++;
            }
            return c;
        }
        public int NumberOfSteps1(int num)
        {
            int c = 0;
            while (num > 0)
            {
                if(num % 2 == 0)
                    num /= 2;
                    else
                     num --;
                c++;
            }
            return c;
        }
    }

}