namespace LeetCode
{
    public class No_1572
    {
        public int DiagonalSum(int[][] mat)
        {
            int s = 0, r = mat.Length - 1;
            for (int i = 0; i < mat.Length; i++)
                s += mat[i][i] + (i != (r - i) ? mat[i][r - i] : 0);

            return s;
        }

    }
}