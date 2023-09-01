using System.Globalization;

namespace LeetCode
{
    class No_216
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<List<int>> output  = new();

            return GenerateConbinations(output, new List<int>(), 1, k, n).ToArray();
            
        }

        private List<List<int>> GenerateConbinations(List<List<int>> output, List<int> current,int startIndex, int combLength, int sumTarget)
        {
            if(current.Count==combLength-1){
                for (int i = startIndex; i < 10; i++)
                {
                    if (current.Sum() + i == sumTarget)
                        output.Add(current.Concat(new List<int> { i }).ToList());
                    else if (current.Sum() + i > sumTarget)
                        break;
                }
            }
            else {
                for (int i = startIndex; i < 10; i++)
                {
                    if (current.Sum() + i <= sumTarget)
                    {
                        output = GenerateConbinations(output, current.Concat(new List<int>{i}).ToList(), i + 1, combLength, sumTarget);
                    }
                }
            }
            return output;

        }
    }
}