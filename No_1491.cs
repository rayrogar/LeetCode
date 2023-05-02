namespace LeetCode
{
    public class No_1491
    {
        public double Average(int[] salary)
        {
            double max = salary[0], min = salary[0], ans = 0;

            for (int i = 0; i < salary.Length; i++)
            {
                if (salary[i] > max)
                    max = salary[i];
                if (salary[i] < min)
                    min = salary[i];
                ans += salary[i];
            }

            return (ans - max - min) / (salary.Length - 2);
        }
    }
}