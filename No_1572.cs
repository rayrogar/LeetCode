namespace LeetCode
{
    public class No_1572
    {
        public int DiagonalSum(int[][] mat)
        {

            int s = 0, r = mat.Length - 1;
            if (r == 0)
                return mat[0][0];

            for (int i = 0; i < mat.Length; i++)
            {
                Console.Write("s += mat[{0}][{0}] + mat[{0}][{1} - {0}] = {2} + {3} = ", i, r, mat[i][i].ToString(), mat[i][r - i].ToString());
                s += mat[i][i] + mat[i][r - i];
                Console.WriteLine(s);
                Console.ReadKey();
            }

            Console.WriteLine("  if (mat.Length % 2 != 0): " + (mat.Length % 2 != 0));
            Console.ReadKey();
            if (mat.Length % 2 != 0)
            {
                Console.WriteLine("s -= mat[r / 2][r / 2] = mat[{0}][{0}]={1}", r / 2, mat[r / 2][r / 2].ToString());
                s -= mat[r / 2][r / 2];
                Console.ReadKey();
            }

            return s;
        }

    }
}