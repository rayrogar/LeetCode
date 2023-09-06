namespace LeetCode
{
    class No_717
    {
        /// <summary>
        /// Runtime: 70ms Beats: 98.80%, Memory: 40.86mb Beats: 28.92% 
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        public bool IsOneBitCharacter(int[] bits)
        {
            int i = bits.Length - 2, output = 0;
            while (i >= 0 && bits[i--] != 0)
                output++;
            return output % 2 == 0;
        }
        /// <summary>
        /// Runtime: 81ms Beats: 90.36%, Memory: 40.6mb Beats: 66.26%
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        public bool IsOneBitCharacter1(int[] bits)
        {
            bool output = true;
            int i = bits.Length - 2;
            while (i >= 0 && bits[i--] != 0)
                output = !output;
            return output;
        }
    }
}