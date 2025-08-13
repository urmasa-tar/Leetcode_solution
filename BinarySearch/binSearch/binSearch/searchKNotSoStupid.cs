using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace binSearch
{
    public class searchKNotSoStupid
    {
        public bool Search(int[] nums, int target)
        {
            bool res = false;
            int move_int = 0;
            for (int i = 1; i < nums.Length; i++) { if (nums[i] < nums[i - 1]) { move_int = i; break; } }

            int a = 0;
            int b = nums.Length - 1;
            int k = (a + b) / 2;
            while (a <= b)
            {
                if (nums[newIndex(k, move_int, nums.Length)] == target) { res = true; break; }
                else
                {
                    if (nums[newIndex(k, move_int, nums.Length)] < target) { a = k + 1; }
                    else { b = k - 1; }
                }
                k = (a + b) / 2;
            }
            return res;
        }

        private int newIndex(int ind, int move, int ln)
        {
            return (ind + move) % ln; 
        }
    }
}
