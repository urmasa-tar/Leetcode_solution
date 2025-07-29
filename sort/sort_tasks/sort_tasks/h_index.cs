using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_tasks
{
    public class h_index
    {
        public int HIndex(int[] citations)
        {
            int result_j = 0;
            int[] arr_cope = new int[citations.Length];
            for (int i = 0; i < citations.Length; i++) { arr_cope[i] = citations[i]; }

            Array.Sort(arr_cope);
            if(arr_cope[0] > 0) { result_j = 1; }
            for (int i = 0; i < arr_cope.Length; i++)
            {
                if (((arr_cope.Length - i) >= arr_cope[i]) && (arr_cope[i] > result_j)) { result_j = max_in(arr_cope[i], 1); }
                else { continue; }
            }
            return result_j;
        }

        private int max_in(int a, int b)
        {
            int res = a;
            if (a < b) { res = b; }
            return res;
        }
    }
}
