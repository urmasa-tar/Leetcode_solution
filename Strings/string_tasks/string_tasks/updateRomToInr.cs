using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class updateRomToInr
    {
        Dictionary<int, string> IntToRom = new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"} 
        };

        public string IntToRoman(int num)
        {
            StringBuilder roman = new StringBuilder();

            foreach (var kvp in IntToRom.OrderByDescending(x => x.Key))
            {
                while (num >= kvp.Key)
                {
                    roman.Append(kvp.Value);
                    num -= kvp.Key;
                }
            }

            return roman.ToString();
        }
    }
}
