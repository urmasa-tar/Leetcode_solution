using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTask
{
    public class WordBreak02
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var wordSet = new HashSet<string>(wordDict);
            var result = new List<string>();
            var current = new List<string>();

            void Backtrack(int i)
            {
                if (i == s.Length)
                {
                    result.Add(string.Join(" ", current));
                    return;
                }

                for (int j = i; j < s.Length; j++)
                {
                    string word = s.Substring(i, j - i + 1);
                    if (wordSet.Contains(word))
                    {
                        current.Add(word);
                        Backtrack(j + 1);
                        current.RemoveAt(current.Count - 1);
                    }
                }
            }

            Backtrack(0);
            return result;
        }
    }
}
