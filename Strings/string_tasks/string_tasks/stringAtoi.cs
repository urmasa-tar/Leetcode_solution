using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
            { '-', -1},
            { '+', 2}
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
            bool fl_to_stop = false;
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    int local_digit = charCount[c];
                    if (((local_digit == -1) && (fl_to_m)) || ((c == '+') && (fl_to_m)))
                    {
                        if (local_digit == -1) { num = -1; }
                        fl_to_m = false;
                    }else if (local_digit == 0)
                    {
                        fl_to_m = false;
                        // check
                        // if (res > 0) { res = res * 10; }
                        if (res > 0) { fl_to_stop = check_board(ref res, num, charCount[c]); }
                        else { continue; }
                    }
                    else if ((local_digit != -1) && (local_digit != 2))
                    {
                        fl_to_m = false;
                        // check
                        fl_to_stop = check_board(ref res, num, charCount[c]);
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
                if (fl_to_stop) { break; } 
            }

            return num * res;
        }

        // if our res is bigger than 
        private bool check_board(ref int current, int num, int to_add)
        {
            bool res = false;
            int mx_var = int.MinValue;
            int min_var = int.MinValue;

            if(to_add == 0)
            {
                // Calc with max
                if(num == 1)
                {
                    if(mx_var / 10 <= current)
                    {
                        current = int.MaxValue;
                        res = true;
                    }
                    else{ current = current * 10; }
                }else if(num == -1) // calc with min
                {
                    if ((min_var / 10) >= (current * -1))
                    {
                        current = int.MinValue;
                        res = true;
                    }
                    else{ current = current * 10; }
                }
            }
            else
            {
                // Calc with max
                if (num == 1)
                {
                    if ((mx_var - to_add) / 10 <= current)
                    {
                        current = int.MaxValue;
                        res = true;
                    }
                    else { current = current * 10 + to_add; }
                }
                else if (num == -1) // calc with min
                {
                    if (((min_var + to_add) / 10) >= (current * -1))
                    {
                        current = int.MinValue;
                        res = true;
                    }
                    else { current = current * 10 + to_add; }
                }
            }
            return res;
        }
    }
}
