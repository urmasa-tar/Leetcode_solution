using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_tasks
{
    public class k_elem_inarrays
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            int res = 0;

            int[] pointer_on_arr = new int[matrix.Length];
            for(int i = 0; i < pointer_on_arr.Length; i++)
            {
                pointer_on_arr[i] = 0;
            }

            int num_bk = 0;
            int last_ind = -1;
            while (num_bk < k)
            {
                int min_current = int.MaxValue;
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (pointer_on_arr[i] < matrix[i].Length) {
                        // for every row
                        if (matrix[i][pointer_on_arr[i]] < min_current)
                        {
                            last_ind = i;
                            min_current = matrix[i][pointer_on_arr[i]];
                        }
                    }
                }

                res = min_current;
                pointer_on_arr[last_ind] += 1;
                num_bk += 1;
            }

            return res;
        }
    }
}
