namespace LeetCode
{
    class No_735
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
                Stack<int> output = new Stack<int>();

            for (int i = 0; i < asteroids.Length; i++)
            {
                if (output.Count() == 0 || asteroids[i] > 0)
                output.Push(asteroids[i]);
                else{
                  while(output.Count > 0 && Math.Sign(output.Peek()) != Math.Sign(asteroids[i])
                    && Math.Abs(asteroids[i]) > Math.Abs(output.Peek()))
                    output.Pop();
                    if(output.Count > 0  && Math.Sign(output.Peek()) != Math.Sign(asteroids[i])
                        && Math.Abs(asteroids[i]) == Math.Abs(output.Peek()))
                        output.Pop();
                        else if (output.Count == 0 || output.Peek() < 0)
                            output.Push(asteroids[i]);
                }
                    
           // Console.WriteLine($"{asteroids[i]} => {string.Join(",",output.Reverse().ToArray())}");
            }
            return output.Reverse().ToArray();
        }
    }
}