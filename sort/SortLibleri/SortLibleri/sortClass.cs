namespace SortLibleri
{
    public class sortClass
    {
        private int[] date;
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

    }
}
