using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        int num;
        string input = Console.ReadLine();

        int.TryParse(input, out num);
        Console.WriteLine(calcRev(num));
    }

    public static int calcRev(int num)
    {
        int res = 0;
        int cpNum = num;
        while (true)
        {
            if((cpNum > 0) && (cpNum % 10 > 0))
            {
                res = res * 10 + cpNum % 10;
                cpNum = cpNum / 10; 
            }else if(cpNum <= 0){ break; }
        }

        return res;
    }
}