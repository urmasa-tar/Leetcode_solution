using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTask
{
    public class twoSumHash
    {

        HashSet<int> hash = new HashSet<int>();
        public int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = target - num;
                if (seen.Contains(complement))
                {
                    return new int[] { complement, num };
                }
                seen.Add(num);
            }

            return new int[0];
        }
    }
}
