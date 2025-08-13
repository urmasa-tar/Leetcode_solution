using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binSearch
{
    public class searchKStuoidTry
    {
        public bool Search(int[] nums, int target)
        {
            bool res = false;
            int[] arr_copy = nums;
            Array.Sort(arr_copy);

            int a = 0;
            int b = arr_copy.Length - 1;
            int k = (a + b) / 2;
            while (a <= b)
            {
                if (arr_copy[k] == target) { res = true; break; }
                else
                {
                    if (arr_copy[k] < target) { a = k + 1; }
                    else { b = k - 1; }
                }
                k = (a + b) / 2;
            }
            return res;
        }
    }
}
