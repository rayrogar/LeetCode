namespace LeetCode
{
    class No_790
    {
        public int NumTilings(int n)
        {
            //1 Domino Shape
            if (n == 1)
                return 1;
            //2 Domino Shapes and rotate
            if (n == 2)
                return 2;
            //Combination of the cases before plus 2 Tromino Shapes and reflex
            if (n == 3)
                return 5;

            var MOD = 1000000007;
            //Since now and for all N the answer will be a combination of two answer before this
            // and its reflexion
            //For example N=4
            //      NT(4) = 2 x NT(3) + NT(1) = 2 x 5 + 1 = 11
            // N = 5
            //      NT(5) = 2 x NT(4) + NT(2) = 2 * 11 + 2 = 24
            // N = 6
            //      NT(6) = 2 x NT(5) + NT(3) = 2 * 24 + 5 = 53
            // N = 7
            //      NT(7) = 2 x NT(6) + NT(4) = 2 * 53 + 11 = 117
            // N = 8
            //      NT(8) = 2 x NT(7) + NT(5) = 2 * 117 + 24 = 258
            decimal[] output = { 1, 2, 5 };

            for (int i = 4; i <= n; i++)
            {
                var t = (2 * output[2] + output[0]) % MOD;
                output[0] = output[1];
                output[1] = output[2];
                output[2] = t;
            }
            return (int)output[2] % MOD;

        }
    }
}