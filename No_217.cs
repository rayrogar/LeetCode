namespace LeetCode
{
    public class No_217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> map = new HashSet<int>(nums);
            return map.Count != nums.Length;
        }
    }
}