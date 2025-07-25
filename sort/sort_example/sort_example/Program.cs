using SortLibleri;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
        int[] arr = new int[10];
        for( int i = 0; i < 10;  i++)
        {
            arr[i] = 10 - i;
        }

        var solution = new SortLibleri.sortClass(arr);
        int[] check_save_Arr = solution.GetArrayCopy();
        Console.WriteLine("Вид до сортировки:");
        print_Arr(check_save_Arr);

        solution.to_sort_Array("Line_sort");
        check_save_Arr = solution.GetArrayCopy();
        Console.WriteLine("После сортировки:");
        print_Arr(check_save_Arr);
    }

    public static bool print_Arr(int[] to_print)
    {
        bool res = true;
        if(to_print != null)
        {
            for(int i = 0; i < to_print.Length; i++)
            {
                Console.Write(to_print[i] + " ");
                if(i >=  to_print.Length - 1)
                {
                    Console.Write("\n");
                }
            }
        }
        else
        {
            res = false;
        }
        return res;
    }
}