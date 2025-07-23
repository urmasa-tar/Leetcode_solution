namespace SortLibleri
{
    public class sortClass
    {
        private int[] date;
        private Dictionary<string, int> sort_Methods = new Dictionary<string, int>()
        {
            { "Buble", 0},
            { "Line_sort", 1},
            { "Calc_sort", 2}
        };
        public sortClass(int[] arr)
        {
            if(arr == null)
            {
                // ?
                throw new ArgumentNullException(nameof(arr));
            }
            else
            {
                date = new int[arr.Length];
                Array.Copy(arr, date, arr.Length);
            }
            
        }

        public int[] GetArrayCopy()
        {
            var copy = new int[date.Length];
            Array.Copy(date, copy, date.Length);
            return copy;
        }

        public bool to_sort_Array(String method)
        {
            bool res = true;
            try
            {
                int method_num = sort_Methods[method];
                switch (method_num)
                {
                    case 0:
                        // код для buble sort
                        buble_sort();
                        break;
                    case 1:
                        // код для input_sort
                        break;
                    case 2:
                        // код для calcs_sort
                        break;
                    default:
                        // код, если ни одно case не совпало
                        break;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error base on" + ex.Message);
                res = false;
            }
            return res;
        }

        private bool buble_sort()
        {
            bool res = true;
            int[] arr_to_sort = GetArrayCopy();
            for (int i = 0; i < arr_to_sort.Length; i++)
            {
                for(int j = 0; j < arr_to_sort.Length - 1; j++)
                {
                    if (arr_to_sort[j] >  arr_to_sort[j + 1])
                    {
                        // swap of elements
                        Swap(ref arr_to_sort[j], ref arr_to_sort[j + 1]);
                    }
                }
            }

            // write to current array
            Array.Copy(arr_to_sort, date, arr_to_sort.Length);
            return res;
        }

        private void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
    }
}
