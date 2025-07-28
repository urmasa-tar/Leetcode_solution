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
            if (hightComprasion == 0) { hightComprasion = Hight.CompareTo(other.Hight-); }
            return hightComprasion;
        }
    }
    public class russian_interval
    {
        //                           env[i][0] - wi env[i][1] - hi
        public int MaxEnvelopes(int[][] envelopes)
        {
            int res = 0;

            HightW[] arr_h_w = new HightW[envelopes.Length];


            return res;
        }
    }
}
