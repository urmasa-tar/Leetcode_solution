using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTask
{
    public class wordFindBreak
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            bool res = true;
            res = recurentCheck(s, wordDict, 0, 0);
            return res;
        }

        public bool recurentCheck(string s, IList<string> wordDct, int i, int j)
        {
            bool res = false;
            if (s.Length == i) { res = true; }
            else
            {
                while(i < s.Length && j < s.Length)
                {
                    string sub = s.Substring(i, j);
                    if (wordDct.Contains(sub))
                    {
                        if(recurentCheck(s, wordDct, j + 1, j + 1))
                        {
                            res = true;
                            break;
                        }
                        else { j++; }
                    }
                    else { j++;  continue; }
                }
            }
            return res;
        }
    }
}
