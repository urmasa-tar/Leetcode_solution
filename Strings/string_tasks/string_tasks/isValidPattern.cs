using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class isValidPattern
    {
        private Dictionary<char, char> open_to_Close = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };
        public bool IsValid(string s)
        {
            bool res = true;
            Stack<char> open_val = new Stack<char>();

            foreach (char cur in s)
            {
                if (open_to_Close.ContainsKey(cur))
                {
                    open_val.Push(cur);
                }
                else if (open_val.Count > 0)
                {
                    char out_c = open_val.Pop();
                    if (open_to_Close[out_c] != cur) { res = false; break; }
                }
                else
                {
                    res = false;
                    break;
                }
            }
            if(open_val.Count > 0) { res = false; }
            return res;
        }
    }
}
