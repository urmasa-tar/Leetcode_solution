using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_tasks
{
    public class correct_intervals
    {
        public struct Interval : IComparable<Interval>
        {
            int start, end;
            public int CompareTo(Interval other)
            {
                int hightComprasion = start.CompareTo(other.start);
                if (hightComprasion == 0) { hightComprasion = end.CompareTo(other.end); }
                return hightComprasion;
            }
        }
        public int EraseOverlapIntervals(int[][] intervals)
        {
            int res = -1;

            return res;
        }
    }
}
