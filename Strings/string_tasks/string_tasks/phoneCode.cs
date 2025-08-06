using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class phoneCode
    {
        private Dictionary<string, string> keyNumber = new Dictionary<string, string>()
        {
            { "2", "abc"},
            { "3", "def"},
            { "4", "ghi"},
            { "5", "jkl"},
            { "6", "mno"},
            { "7", "pqrs"},
            { "8", "tuv"},
            { "9", "wxyz"},

        };
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> res_list = new List<string>();
            res_list = recurent_Add("", digits, 0);
            return res_list;
        }

        public IList<string> recurent_Add(string current, string digits, int point)
        {
            IList<string> res_list = new List<string>();
            if (point == digits.Length - 1)
            {
                string options = keyNumber[digits];
                foreach (char opt in options)
                {
                    res_list.Add(current + opt);
                }
            }
            else
            {
                string options = keyNumber[digits];
                foreach(char opt in options)
                {
                    ((List<string>)res_list).AddRange(recurent_Add(current + opt, digits, point + 1));
                }
            }
            return res_list;
        }
    }
}
