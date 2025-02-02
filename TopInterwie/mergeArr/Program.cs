using System;

namespace mergeArr
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[4] { 1, 2, 3, 4 };
            int[] arr2 = new int[] { 1 };

            Solution solution = new Solution();

            solution.Merge(arr1, 3, arr2, 1);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
    }
}
