using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class stringAtoi
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>
        {
            { '1', 1 },
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { '0', 0 },
            { '-', -1}
        };
        public int MyAtoi(string s)
        {
            int res = 0;

            string to_calc = s;
            to_calc = to_calc.ToLower();
            res = calc_res(to_calc);

            return res;
        }

        private int calc_res(string s)
        {
            int res = 0;
            int num = 1; // for res >= 0 -> 1
                         // for res < 0 -> -1
            bool fl_to_m = true;
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    int local_digit = charCount[c];
                    if ((local_digit == -1) && (fl_to_m))
                    {
                        num = -1;
                        fl_to_m = false;
                    }else if (local_digit == 0)
                    {
                        fl_to_m = false;
                        if (res > 0) { res = res * 10; }
                        else { continue; }
                    }
                    else if (local_digit != -1)
                    {
                        fl_to_m = false;
                        res = res * 10 + local_digit;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if((res == 0)  && (num == 1) && (c == ' '))
                    {
                        continue;
                    }
                    break;
                }
            }

            return num * res;
        }

        

    }
}
