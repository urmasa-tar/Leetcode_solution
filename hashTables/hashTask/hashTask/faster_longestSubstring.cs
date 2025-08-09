using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTask
{
    public class faster_longestSubstring
    {
        // O(n)
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charSet = new HashSet<char>();
            int left = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right];

                // Если символ уже есть в HashSet, двигаем левый указатель
                while (charSet.Contains(currentChar))
                {
                    charSet.Remove(s[left]);
                    left++;
                }

                // Добавляем текущий символ в HashSet
                charSet.Add(currentChar);

                // Обновляем максимальную длину
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
