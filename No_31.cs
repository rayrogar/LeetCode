namespace Leetcode
{
    class No_31
    {
        public void NextPermutation(int[] nums)
        {

            var swap = PermutacionPost(nums);

            if (swap.Item1 != -1)
            {
                Swaping(swap, nums);
                Array.Sort(nums, swap.Item2 + 1, nums.Length - (swap.Item2 + 1));
            }
            else
                Array.Reverse(nums);
        }

        public static (int, int) PermutacionPost(int[] arrayNums)
        {
            int dif = int.MaxValue, sel = -1, tar = -1;
            for (int i = arrayNums.Length - 1; i > tar; i--)
                for (int j = i - 1; j >= 0; j--)
                    if (arrayNums[i] > arrayNums[j] && i - j < dif)
                        if (sel == -1 || (arrayNums[sel] > arrayNums[i] || j > tar))
                        {
                            sel = i;
                            tar = j;
                            dif = i - j;
                            break;
                        }
            return (sel, tar);
        }

        public static void Swaping((int, int) positions, int[] arrayNums)
        {
            int t = arrayNums[positions.Item1];
            arrayNums[positions.Item1] = arrayNums[positions.Item2];
            arrayNums[positions.Item2] = t;
        }
    }

}