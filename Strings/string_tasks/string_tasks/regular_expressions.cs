using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class regular_expressions
    {
        char[] to_check = { '*', '.'};
        public bool IsMatch(string s, string p)
        {
            bool res = false;
            res = rec_from_pointers(s, p, 0, 0, false);
            return false;
        }

        private bool rec_from_pointers(string s, string p, int s_point, int p_point, bool out_s)
        {
            bool res = false;

            if((s.Length - 1 == s_point) && (p.Length - 1 == p_point))
            {
                // check for same
                
            }else if ((s.Length - 1 == s_point) && (p.Length - 1 > p_point))
            {
                // check for * or . + *

            }else if ((s.Length - 1 > s_point) && (p.Length - 1 == p_point))
            {

            }

            return res;
        }
    }
}
