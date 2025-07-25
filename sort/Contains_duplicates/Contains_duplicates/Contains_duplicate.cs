using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_duplicates
{
    // That solution is out of memory
    public class Contains_duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            bool res = false;
            if(nums.Length > 0)
            {
                int max_in_nums = max_Search(nums);
                int min_in_nums = min_Search(nums);
                res = search_Dublicates(max_in_nums, min_in_nums, nums);

            }
            return res;
        }

        private bool search_Dublicates(int max, int min, int[] arr)
        {
            bool res = false;

            int[] calc_arr = new int[max - min + 1];
            for(int i = 0; i < calc_arr.Length; i++)
            {
                calc_arr[i] = 0;
            }
            foreach (int i in arr)
            {
                calc_arr[i - min] += 1;
                if (calc_arr[i - min] > 1)
                {
                    res = true;
                    break;
                }
            }

            return res;
        }

        private int max_Search(int[] arr) 
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (i > max) { max = i; }
            }
            return max;
        }

        private int min_Search(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
            {
                if (i < min) { min = i; }
            }
            return min;
        }
    }
}
