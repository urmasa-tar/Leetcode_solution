using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_tasks
{
    public class find_Kf_largest
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int res = -1;

            int[] arr_copy = new int[nums.Length];
            for(int i = 0; i < arr_copy.Length; i++) { arr_copy[i] = nums[i]; }
            Array.Sort(arr_copy);
            Array.Reverse(arr_copy);
            if (arr_copy.Length >= k)
            {
                res = arr_copy[k - 1];
            }

            return res;
        }
    }
}
