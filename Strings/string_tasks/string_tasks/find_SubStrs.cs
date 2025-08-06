using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_tasks
{
    public class find_SubStr
    {
        Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();

        public IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> result = new List<int>();

            int wordLength = fillwordsFrequency(words, words[0].Length);

            int l = 0, r = 0;
            while (r <= s.Length - wordLength)
            {
                var subs = s.Substring(r, wordLength);
                if (wordsFrequency.ContainsKey(subs))
                {
                    wordsFrequency[subs]--;
                    if (wordsFrequency[subs] == 0)
                    {
                        wordsFrequency.Remove(subs);
                    }
                    r += wordLength;
                }
                else
                {
                    l = Reset(words, out wordLength, l, out r);
                }
                if (wordsFrequency.Count() == 0)
                {
                    result.Add(l);
                    l = Reset(words, out wordLength, l, out r);
                }

            }
            return result;
        }

        private int Reset(string[] words, out int wordLength, int l, out int r)
        {
            l++;
            r = l;
            wordLength = fillwordsFrequency(words, words[0].Length);
            return l;
        }

        int fillwordsFrequency(string[] words, int wordLength)
        {

            wordsFrequency.Clear();
            int CheckAllWordSame = 1;
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] != words[i + 1])
                {
                    CheckAllWordSame = 0;
                    break;
                }
            }
            if (wordLength == 1 && CheckAllWordSame == 1)
            {
                string a = string.Concat(words);
                if (wordsFrequency.ContainsKey(a))
                {
                    wordsFrequency[a]++;
                }
                else
                {
                    wordsFrequency.Add(a, 1);
                }

                wordLength = a.Length;

            }
            else
            {
                foreach (var item in words)
                {
                    if (wordsFrequency.ContainsKey(item))
                    {
                        wordsFrequency[item]++;
                    }
                    else
                    {
                        wordsFrequency.Add(item, 1);
                    }
                }

            }
            return wordLength;
        }


    }
}
