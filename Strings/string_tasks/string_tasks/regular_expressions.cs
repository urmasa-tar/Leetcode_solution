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
                if ((p[p_point] == s[s_point]) || (p[p_point] == '*') || (p[p_point] == '.'))
                {
                    res = true;
                }
            }else if ((s.Length - 1 == s_point) && (p.Length - 1 > p_point))
            {
                // check for * or . + *
                if ((p[p_point]) == '.' && (!out_s))
                {
                    res = rec_from_pointers(s, p, s_point, p_point + 1, true);
                }
                else if ( p[p_point] == '*')
                {
                    res = rec_from_pointers(s, p, s_point, p_point + 1, false);
                }
            }else if ((s.Length - 1 > s_point) && (p.Length - 1 == p_point))
            {
                // check for * - only way
                if (p[p_point] == '*') { res = true; }
            }
            else if((s.Length - 1 > s_point) && (p.Length - 1 > p_point))
            {
                // 1) p[i] is . --> . = s[j]
                // 2) p[i] is * --> 2.1) skip s[j]
                //                  2.2) skip p[i]
                // 3) p[i] is a/b/c/d ... --> calc difference


                if (p[p_point] == '.') { res = rec_from_pointers(s, p, s_point + 1, p_point + 1, false); } // 1)
                else if (p[p_point] == '*') { res = (rec_from_pointers(s, p, s_point + 1, p_point + 1, false) || rec_from_pointers(s, p, s_point + 1, p_point, false));  } // 2)
                else if (p[p_point] == s[s_point]) { res = rec_from_pointers(s, p, s_point + 1, p_point + 1, false); } // 3)
            }

            return res;
        }
    }
}
