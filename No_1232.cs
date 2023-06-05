namespace LeetCode
{
    public class No_1232
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            bool x = true, y = true, xy = true;
            //int m = 0;
            if (coordinates[0][0] == coordinates[1][0])
                xy = y = false;
            else if (coordinates[0][1] == coordinates[1][1])
                xy = x = false;
            else
            {
                x = y = false;
                // m = (double)(coordinates[1][1] - coordinates[0][1]) / (coordinates[1][0] - coordinates[0][0]);

            }

            for (int i = 2; i < coordinates.Length - 1; i++)
            {
                if (x)
                {
                    if (coordinates[i][0] != coordinates[i - 1][0])
                        return false;
                }
                else if (y)
                {
                    if (coordinates[i][1] != coordinates[i - 1][1])
                        return false;
                }
                else
                {

                    //if (m != (double)(coordinates[i][1] - coordinates[0][1]) / (coordinates[i][0] - coordinates[0][0]))

                    if ((coordinates[i][1] - coordinates[1][1]) * (coordinates[1][0] - coordinates[0][0]) != (coordinates[1][1] - coordinates[0][1]) * (coordinates[i][0] - coordinates[1][0]))
                        return false;
                }
            }

            return true;
        }
    }
}