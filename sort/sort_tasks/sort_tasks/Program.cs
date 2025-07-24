namespace sort_tasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            Right_interval class_for_calc = new Right_interval();
            int[] array_input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if((array_input.Length > 0) && ((array_input.Length % 2) == 0))
            {
                // int[][] pair_inp = new int[array_input.Length][];
                int[][] pair_inp = to_pairs(array_input);
                int[] interval_out = class_for_calc.FindRightInterval(pair_inp);
                Console.WriteLine(String.Join(",", interval_out));

                /*
                for(int i = 0; i < pair_inp.Length; i++)
                {
                    Console.WriteLine(String.Join(",", pair_inp[i]));
                }
                */
            }
            else
            {
                Console.WriteLine("Uncorrect input, please repeat");
            }


        }

        public static int[][] to_pairs(int[] arr)
        {
            int[][] pairs_res = new int[arr.Length/2][];
            int arr_index = 0;
            while(arr_index < arr.Length)
            {
                pairs_res[arr_index / 2] = new int[2];
                pairs_res[arr_index/2][0] = arr[arr_index];
                pairs_res[arr_index / 2][1] = arr[arr_index + 1];
                arr_index += 2;
            }
            
            /*
            for (int i = 0; i < arr.Length; i++)
            {

            }
            */
            return pairs_res;
        }
    }
}