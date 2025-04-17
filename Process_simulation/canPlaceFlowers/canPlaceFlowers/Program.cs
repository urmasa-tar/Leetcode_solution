class Program
{
    public static int Main(string[] args)
    {
        Console.WriteLine(CanPlaceFlowers([1, 0, 0, 0, 1], 1));

        return 0;
    }

    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        bool res = false;
        int priv = 0;
        int need_to_palce = n;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if(flowerbed[i] == 0)
            {
                if(priv == 0)
                {
                    need_to_palce--;
                    priv = 1;
                    if(need_to_palce == 0)
                    {
                        res = true;
                        break;
                    }
                }
                else
                {
                    priv = 0;
                }
            }
            else
            {
                priv = 1;
            }

        }
        return res;
    }
}