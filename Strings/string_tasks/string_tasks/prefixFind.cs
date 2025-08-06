using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class prefixFind
    {
        public struct strringWithLebgth : IComparable<strringWithLebgth>
        {
            public int ln;
            public string str;

            public int CompareTo(strringWithLebgth other)
            {
                return ln.CompareTo(other.ln);
            }
        }
        public string LongestCommonPrefix(string[] strs)
        {
            string res = "";
            strringWithLebgth[] string_ln = new strringWithLebgth[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                string_ln[i].str = strs[i];
                string_ln[i].ln = strs[i].Length;
            }
            Array.Sort(string_ln);
            for(int pref = 0; pref < string_ln[0].ln; pref++)
            {
                if(ComparePref(pref, string_ln)) { res = string_ln[0].str.Substring(0, pref); }
                else { break; }
            }
            return res;
        }

        private bool ComparePref(int pref, strringWithLebgth[] strs)
        {
            bool res = true;
            for(int str_n = 0; str_n < strs.Length; str_n++)
            {
                if (strs[0].str.AsSpan(0, pref).SequenceEqual(strs[str_n].str.AsSpan(0, pref))) { continue; }
                else
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
    }
}
