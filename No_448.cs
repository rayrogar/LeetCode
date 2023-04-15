using System.Runtime.CompilerServices;

namespace LeetCode
{
    public class No_448{

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> salida = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                salida.Add(nums[i]);

            }
            
             for (int i = 0; i < salida.Count; i++)
            {
                nums[salida[i] - 1] = 0;
            }
            salida.Clear();
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]!=0)
                    salida.Add(i + 1);
            }
            return salida;
        }

    }
    
}