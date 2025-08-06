using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class prefixFind
    {
        public struct strringWithLebgth : IComparable<strringWithLebgth>
        {
            public int Length;
            public string str;

            public int CompareTo(strringWithLebgth other)
            {
                return Length.CompareTo(other.Length);
            }
        }
        public string LongestCommonPrefix(string[] strs)
        {
            string res = "";

            return res;
        }
    }
}
