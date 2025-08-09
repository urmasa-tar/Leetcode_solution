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
                if (fromPoint(i, ln_of_strs, s, words))
                {
                    res.Add(i);
                }
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

        private bool fromPoint(int i, int ln_of_sub, string s, string[] words)
        {
            bool res_check = true;
            int word_ln = words[0].Length;
            HashSet<string> have_been = new HashSet<string>();

            for(int num_s = 0; num_s < words.Length; num_s++)
            {
                string str_w = s.Substring(num_s * word_ln, (num_s * word_ln + word_ln));
                if(Array.IndexOf(words, str_w) != -1)
                {
                    if (have_been.Contains(str_w))
                    {
                        res_check = false;
                        break;
                    }
                    else { have_been.Add(str_w); }
                }
                else
                {
                    res_check = false;
                    break;
                }
            }

            return res_check;
        }
    }
}
