using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTask
{
    public class wordsConcat
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> res = new List<int>();
            int ln_of_strs = getFullLengtth(words);

            for (int i = 0; i < s.Length - ln_of_strs; i++)
            {
                
            }

            return res;
        }

        private int getFullLengtth(string[] strs)
        {
            int res_ln = 0;
            foreach (string str in strs)
            {
                res_ln += str.Length;
            }
            return res_ln;
        }

        private bool fromPoint(int i, string s, string[] words)
        {
            bool res_check = true;

            HashSet<string> have_been = new HashSet<string>();


            return res_check;
        }
    }
}
