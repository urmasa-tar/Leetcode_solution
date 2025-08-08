using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTask
{
    public class longestinRow
    {
        public int LengthOfLongestSubstring(string s)
        {
            int longest_res = 0;
            int current_line = 0;
            HashSet<char> been_chars = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                for(int j = i; j < s.Length; j++)
                {
                    char c = s[j];
                    if (been_chars.Contains(c))
                    {
                        been_chars.Clear();
                        been_chars.Add(c);
                        current_line = 1;
                    }
                    else
                    {
                        been_chars.Add(c);
                        current_line += 1;
                        if (current_line > longest_res) { longest_res = current_line; }
                    }
                }
            }

            return longest_res;
        }
    }
}
