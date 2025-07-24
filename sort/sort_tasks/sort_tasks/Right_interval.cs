using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace sort_tasks
{
    public class Right_interval
    {
        Right_interval() { }
        public int[] FindRightInterval(int[][] intervals)
        {
            int[] result = new int[intervals.Length];

            int[] point_in_arr = new int[intervals.Length];
            for (int index = 0; index < intervals.Length; index++)
            {
                point_in_arr[index] = index;
                result[index] = 0;
            }
            // sorted points
            point_in_arr = sort_points(point_in_arr, intervals);


            return result;
        }

        private int[] sort_points(int[] points, int[][] intervals)
        {
            int[] result = points;
            for (int index = 1; index < points.Length; index++)
            {
                for (int j_ind = 0; j_ind < index; j_ind++)
                {
                    if (intervals[result[j_ind]][0] > intervals[result[index]][0])
                    {
                        
                    }
                }
            }
            return result;
        }
    }
}
