namespace LeetCode
{
    public class No_1502
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            if (arr.Length <= 2)
                return true;
            int dif = arr[1] - arr[0];
            for (int i = 2; i < arr.Length; i++)
                if (arr[i] - arr[i - 1] != dif)
                    return false;
            return true;
        }
    }
}