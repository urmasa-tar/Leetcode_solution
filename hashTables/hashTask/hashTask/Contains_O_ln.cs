using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTask
{
    public class Contains_O_ln
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> result = new List<int>();
            if (words.Length == 0 || s.Length == 0) return result;

            int wordLength = words[0].Length;
            int totalWords = words.Length;
            int substringLength = wordLength * totalWords;
            if (s.Length < substringLength) return result;

            // Шаг 1: Создаем словарь частот слов (O(m))
            var wordCount = words
                .GroupBy(w => w)
                .ToDictionary(g => g.Key, g => g.Count());

            // Шаг 2: Проверяем все возможные стартовые позиции (O(n/wordLength))
            for (int start = 0; start < wordLength; start++)
            {
                int left = start;
                var currentWindow = new Dictionary<string, int>();
                int matchedWords = 0;

                // Шаг 3: Скользящее окно (O(n/wordLength))
                for (int right = start; right <= s.Length - wordLength; right += wordLength)
                {
                    string currentWord = s.Substring(right, wordLength);

                    // Если слово не из списка - сбрасываем окно
                    if (!wordCount.ContainsKey(currentWord))
                    {
                        currentWindow.Clear();
                        matchedWords = 0;
                        left = right + wordLength;
                        continue;
                    }

                    // Добавляем слово в текущее окно
                    currentWindow[currentWord] = currentWindow.GetValueOrDefault(currentWord, 0) + 1;
                    matchedWords++;

                    // Если слово встречается слишком часто - сдвигаем левую границу
                    while (currentWindow[currentWord] > wordCount[currentWord])
                    {
                        string leftWord = s.Substring(left, wordLength);
                        currentWindow[leftWord]--;
                        matchedWords--;
                        left += wordLength;
                    }

                    // Если нашли подходящую подстроку
                    if (matchedWords == totalWords)
                    {
                        result.Add(left);
                        string leftWord = s.Substring(left, wordLength);
                        currentWindow[leftWord]--;
                        matchedWords--;
                        left += wordLength;
                    }
                }
            }

            return result;
        }
    }
}
