class Program
{   
    public static int Main(String[] args)
    {
        Console.WriteLine(GcdOfStrings("ABCABC", "ABC"));
        return 0;
    }

    public static string GcdOfStrings(string str1, string str2)
    {
        String res = "";

        if(str1.Length > str2.Length)
        {
            res = mx_SubStr(str1, str2);
        }
        else
        {
            res = mx_SubStr(str2, str1);
        }

        return res;
    }

    private static string mx_SubStr(string bigger_str, string sub)
    {
        String res = "";

        for (int end_subStr = 1; end_subStr <= sub.Length; end_subStr++)
        {
            String str_to_Check = sub.Substring(0, end_subStr);
            if(check_is_Sub(bigger_str, str_to_Check) && check_is_Sub(sub,  str_to_Check))
            {
                res = str_to_Check;
            }
        }

        return res;
    }

    private static bool check_is_Sub(string big_Str,  string sub)
    {
        Boolean res  = false;
        string temp = big_Str.Replace(sub, "");
        res = temp.Length == 0;
        return res;
    }
}
