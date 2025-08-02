using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class intToroman
    {
        Dictionary<char, int> RomtoInt = new Dictionary<char, int>()
        {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
        };
        public String intToRoman(int num)
        {
            string res = "";
            int i = 0;
            int ln_d = RomtoInt.Count;
            while (num > 0)
            {
                if(i >= ln_d) { break; }

            }

            return res;
        }
    }
}
