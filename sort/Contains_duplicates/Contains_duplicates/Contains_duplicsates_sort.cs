using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_duplicates
{
    public class Contains_duplicsates_sort
    {
        public bool ContainsDuplicate(int[] nums)
        {
            bool res = false;

            QuickSort(nums, 0, nums.Length);
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        /*
        private int[] QuickSort(int[] nums)
        {
            int[] copy_arr = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++){ copy_arr[i] = nums[i]; }

            // int midle_point = nums.Length/2 + 1;
            copy_arr = Recurent_step(copy_arr);

            return copy_arr;
        }

        private int[] Recurent_step(int[] subarr)
        {
            int[] res_subarr = subarr;
            int midle_point = subarr.Length / 2 + 1;



            return res_subarr;
        }
        */

        public void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                    QuickSort(array, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(array, pivot + 1, right);
            }
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                    left++;

                while (array[right] > pivot)
                    right--;

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    // Swap
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

    }
}
