namespace LeetCode
{
    public class No_234
    {
        public bool IsPalindrome(ListNode head)
        {
            List<int> copy = new List<int>();

            while (head != null)
            {
                copy.Add(head.val);
                head = head.next;
            }
            

            for (int i = 0; i < copy.Count / 2; i++)
            {
                if (copy[i] != copy[copy.Count - i - 1])
                    return false;
            }

            return true;
        }
    }
}