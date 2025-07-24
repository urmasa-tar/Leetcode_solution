using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sort_tasks
{
    public class Right_interval
    {
        public int[] FindRightInterval(int[][] intervals)
        {
            int[] result = new int[intervals.Length];

            int[] point_in_arr = new int[intervals.Length];
            for (int index = 0; index < intervals.Length; index++)
            {
                point_in_arr[index] = index;
                result[index] = -1;
            }
            // sorted points
            point_in_arr = sort_points(point_in_arr, intervals);
            update_Result(ref result, point_in_arr, intervals);
            Console.WriteLine(String.Join(",", point_in_arr));
            return result;
        }
        // Buble sort O(n**2)
        private int[] sort_points(int[] points, int[][] intervals)
        {
            int[] result = points;
            for (int index = 1; index < points.Length; index++)
            {
                for (int j_ind = 0; j_ind < index; j_ind++)
                {
                    if (intervals[result[j_ind]][0] > intervals[result[index]][0])
                    {
                        SwapInts(ref result[j_ind], ref result[index]);
                    }else if(intervals[result[j_ind]][0] == intervals[result[index]][0])
                    {
                        if(intervals[result[j_ind]][1] > intervals[result[index]][1]) { SwapInts(ref result[j_ind], ref result[index]); }
                    }
                }
            }
            return result;
        }

        private void update_Result(ref int[] result, int[] point_in_arr, int[][] arr)
        {
            // Calc with two points
            // int i = 0; // find his interval
            int j = 0; // it's may be his interval
            for(int i = 0; i < point_in_arr.Length; i++)
            {
                if(j == i)
                {
                    j += 1;
                }

                if (j == point_in_arr.Length)
                {
                    break;
                }

                while (true)
                {
                    // current situation
                    if (arr[point_in_arr[i]][1] <= arr[point_in_arr[j]][0])
                    {
                        result[point_in_arr[i]] = point_in_arr[j];
                        break;
                    }
                    else
                    {
                        j += 1;
                        if (j >= point_in_arr.Length) { break; }
                    }
                }
            }
        }

        private void SwapInts(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        void SwapArrays(ref int[] arr1, ref int[] arr2)
        {
            int[] temp = arr1;
            arr1 = arr2;
            arr2 = temp;
        }

    }
}
