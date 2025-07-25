using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_duplicates
{
    public class Contains_lib_sort
    {
        public bool ContainsDuplicate(int[] nums)
        {
            bool res = false;

            int[] arr_to_sort = GetArrayCopy(ref nums); 
            Array.Sort(arr_to_sort);
            for(int i = 1; i < arr_to_sort.Length; i++)
            {
                if (arr_to_sort[i] == arr_to_sort[i - 1])
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        public int[] GetArrayCopy(ref int[] data)
        {
            var copy = new int[data.Length];
            Array.Copy(data, copy, data.Length);
            return copy;
        }
    }
}
