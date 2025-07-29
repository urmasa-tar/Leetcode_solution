using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_tasks
{
    public class major_element
    {
        public IList<int> MajorityElement(int[] nums)
        {
            IList<int> result = new List<int> {};
            int[] arr_copy = new int[nums.Length];
            for(int i = 0; i < arr_copy.Length; i++) { arr_copy[i] = nums[i]; }
            Array.Sort(arr_copy);
            int check_sum = arr_copy.Length / 3;
            int current_inLine = 1;

            if ((current_inLine > check_sum) && !(result.Contains(arr_copy[0]))) { result.Add(arr_copy[0]); }
            for (int i = 1; i < arr_copy.Length; i++)
            {
                if (arr_copy[i] == arr_copy[i - 1])
                {
                    current_inLine++;
                    if((current_inLine > check_sum) && !(result.Contains(arr_copy[i]))) { result.Add(arr_copy[i]); }
                }
                else{
                    current_inLine = 1;
                    if ((current_inLine > check_sum) && !(result.Contains(arr_copy[i]))) { result.Add(arr_copy[i]); }
                }
            }

            return result;
        }
    }
}
