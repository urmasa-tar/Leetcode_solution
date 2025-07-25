using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_duplicates
{
    public class Duplicates_with_diff
    {
        public struct ElementWithIndex : IComparable<ElementWithIndex>
        {
            public int Value;    // Первый элемент - значение
            public int Index;    // Второй элемент - индекс в исходном массиве

            // Реализация интерфейса IComparable для сортировки по Value
            public int CompareTo(ElementWithIndex other)
            {
                return Value.CompareTo(other.Value);
            }
        }
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
        {
            bool res = false;
            ElementWithIndex[] elements = new ElementWithIndex[nums.Length];
            for(int i = 0; i < elements.Length; i++)
            {
                elements[i].Index = i;
                elements[i].Value = nums[i];
            }
            Array.Sort(elements);

            res = calc_with_Values(elements, indexDiff, valueDiff);

            return res;
        }

        private bool calc_with_Values(ElementWithIndex[] sort_arr, int indexDiff, int valueDiff)
        {
            bool res = false;
            if(indexDiff <= sort_arr.Length)
            {
                int j = 0;
                for (int i = indexDiff; i < sort_arr.Length; i++)
                {
                    while (true)
                    {
                        if (j >= i) { break; }
                        else if (sort_arr[i].Value - sort_arr[j].Value < valueDiff) { break; }
                        else if (sort_arr[i].Value - sort_arr[j].Value > valueDiff)
                        {
                            j += 1;
                            continue;
                        }
                        else
                        {
                            if (sort_arr[i].Index - sort_arr[j].Index == indexDiff)
                            {
                                res = true;
                                break;
                            }
                        }
                    }
                    if (res) { break; }
                }
            }
            return res;
        }

        public int[] GetArrayCopy(ref int[] data)
        {
            var copy = new int[data.Length];
            Array.Copy(data, copy, data.Length);
            return copy;
        }
    }
}
