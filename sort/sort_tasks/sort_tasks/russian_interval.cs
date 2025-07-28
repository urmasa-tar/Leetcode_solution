using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_tasks
{
    public struct HightW : IComparable<HightW>
    {
        public int Hight;
        public int Wight;

        public int CompareTo(HightW other)
        {
            int hightComprasion = Hight.CompareTo(other.Hight);
            if (hightComprasion == 0){ hightComprasion = Wight.CompareTo(other.Wight); }
            return hightComprasion;
        }
    }

    public struct WidthH : IComparable<WidthH>
    {
        public int Wight;
        public int Hight;

        public int CompareTo(WidthH other)
        {
            int hightComprasion = Wight.CompareTo(other.Wight);
            if (hightComprasion == 0) { hightComprasion = Hight.CompareTo(other.Hight); }
            return hightComprasion;
        }
    }
    public class russian_interval
    {
        //                           env[i][0] - wi env[i][1] - hi
        public int MaxEnvelopes(int[][] envelopes)
        {
            int res = 0;
            if (envelopes.Length > 0) { res = 1; }
            HightW[] arr_h_w = new HightW[envelopes.Length];
            WidthH[] arr_w_h = new WidthH[envelopes.Length];
            for(int i = 0; i < envelopes.Length; i++)
            {
                int w = envelopes[i][0];
                int h = envelopes[i][1];

                arr_w_h[i].Wight = w;
                arr_h_w[i].Hight = h;
                arr_w_h[i].Hight = h;
                arr_h_w[i].Wight = w;
            }
            Array.Sort(arr_w_h);
            Array.Reverse(arr_w_h);

            for(int i = 1; i < arr_w_h.Length; i++)
            {
                if (arr_w_h[i].Hight < arr_w_h[i - 1].Hight)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}
