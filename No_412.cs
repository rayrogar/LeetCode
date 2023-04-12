/*
Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.
 

Example 1:

Input: n = 3
Output: ["1","2","Fizz"]
Example 2:

Input: n = 5
Output: ["1","2","Fizz","4","Buzz"]
Example 3:

Input: n = 15
Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 

Constraints:

1 <= n <= 104
*/


namespace LeetCode { 

    public class No_412{
        public No_412(){

            Console.WriteLine("Given an integer n, return a string array answer(1 - indexed) where:");
            Console.WriteLine("FizzBuzz if i is divisible by 3 and 5.");
            Console.WriteLine("Fizz if i is divisible by 3.");
            Console.WriteLine("Buzz if i is divisible by 5.");
            Console.WriteLine("i (as a string) if none of the above conditions are true.");

            Console.WriteLine("Example 1:");
            Console.WriteLine("Input: n = 3");
            Console.WriteLine("Output: [1, 2, Fizz]");
            Console.WriteLine("Real: " + string.Join(',', FizzBuzz(3)));
            Console.WriteLine("Real: " + string.Join(',', FizzBuzz1(3)));

            //===================================================////========================================================///
            Console.WriteLine("Example 2:");
            Console.WriteLine("Input: n = 5");
            Console.WriteLine("Output: [1,2,Fizz,4,Buzz]");
            Console.WriteLine("Real: " + string.Join(',', FizzBuzz(5)));
            Console.WriteLine("Real: " + string.Join(',', FizzBuzz1(5)));

            //===================================================////========================================================///
            Console.WriteLine("Example 3:");
            Console.WriteLine("Input: n = 15");
            Console.WriteLine("Output: [1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz]");
            Console.WriteLine("Real: " + string.Join(',', FizzBuzz(15)));
            Console.WriteLine("Real: " + string.Join(',', FizzBuzz1(15)));

            Console.ReadKey();

        }

        public IList<string> FizzBuzz(int n)
        {
            string[] salida = new string[n];
            for (int i = 0; i < n;  i++){
                if((i + 1) % 3 == 0 && (i + 1) % 5 == 0){
                    salida[i] = "FizzBuzz";
                }
                else if((i + 1) % 3 == 0){
                    salida[i] = "Fizz";
                }
                else if((i + 1) % 5 == 0){
                    salida[i] = "Buzz";
                }
                else
                    salida[i] = (i + 1).ToString();
            }

            return salida;
        }

        public IList<string> FizzBuzz1(int n)
        {
            string[] salida = new string[n];
            for (int i = 0; i < n; i++)
            {
                salida[i] = ((i + 1) % 15 == 0) ? "FizzBuzz" : ((i + 1) % 3 == 0) ? "Fizz" : ((i + 1) % 5 == 0) ? "Buzz" : (i + 1).ToString();

            }

            return salida;
        }

    }
}