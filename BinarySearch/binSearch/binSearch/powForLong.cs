using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binSearch
{
    public class powForLong
    {
        public int MySqrt(int x)
        {
            if (x < 0) throw new ArgumentException("x must be non-negative");
            if (x < 2) return x; // √0=0, √1=1

            int left = 1;
            int right = Math.Min(x, 46_340); // Максимально возможный корень для int

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long square = (long)mid * mid;

                if (square == x) return mid;
                if (square < x) left = mid + 1;
                else right = mid - 1;
            }

            return right; // Возвращаем округлённый вниз корень
        }
    }
}
