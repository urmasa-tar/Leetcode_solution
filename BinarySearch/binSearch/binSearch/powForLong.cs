using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binSearch
{
    public class powForLong
    {
        public int MySqrt(int x)
        {
            int res = -1;
            int[] serch_arr = new int[int.MaxValue / 2 + 1];
            for(int i = 0; i < int.MaxValue / 2 + 1; i++) { serch_arr[i] = i; }

            int a = 0;
            int b = int.MaxValue / 2 + 1;
            int k = (a + b) / 2;
            // double sqr_x = Math.Sqrt(x);
            while (a <= b)
            {
                k = (a + b) / 2;
                if ((serch_arr[k] * serch_arr[k] <= x) && (serch_arr[k + 1] * serch_arr[k + 1] > x))
                {
                    res = serch_arr[k];
                    break;
                }
                else
                {
                    if (serch_arr[k] * serch_arr[k] < x) { a = k + 1; }
                    else { b = k - 1; }
                }
            }
            return res;
        }
    }
}
