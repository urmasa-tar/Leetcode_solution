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
            int correct_num = num;
            string res = "";
            int i = 0;
            int ln_d = RomtoInt.Count;
            while (num > 0)
            {
                if(i >= ln_d) { break; }
                if (RomtoInt.ElementAt(i).Value <= correct_num)
                {
                    correct_num -= RomtoInt.ElementAt(i).Value;
                    res += RomtoInt.ElementAt(i).Key;
                }
                else
                {
                    for(int j = i + 1; j < ln_d; j++)
                    {
                        if(RomtoInt.ElementAt(i).Value - RomtoInt.ElementAt(j).Value <= correct_num)
                        {
                            correct_num -= RomtoInt.ElementAt(i).Value - RomtoInt.ElementAt(j).Value;
                            res += RomtoInt.ElementAt(i).Key + RomtoInt.ElementAt(j).Key;
                        }
                        if(RomtoInt.ElementAt(i).Value - (RomtoInt.ElementAt(j).Value * 2) <= correct_num)
                        {
                            correct_num = correct_num - RomtoInt.ElementAt(i).Value + RomtoInt.ElementAt(j).Value * 2;
                            res += RomtoInt.ElementAt(j).Key * 2 + RomtoInt.ElementAt(i).Key;
                        }
                        if(RomtoInt.ElementAt(i).Value - (RomtoInt.ElementAt(j).Value * 3) <= correct_num)
                        {
                            correct_num = correct_num - RomtoInt.ElementAt(i).Value + RomtoInt.ElementAt(j).Value;
                            res += RomtoInt.ElementAt(j).Key * 3 + RomtoInt.ElementAt(i).Key;
                        }
                    }
                }
                if (RomtoInt.ElementAt(i).Value > correct_num) { i += 1; }
                if (correct_num == 0) { break; }
            }

            return res;
        }
    }
}
