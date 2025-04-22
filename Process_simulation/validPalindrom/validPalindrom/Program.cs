using System.ComponentModel.DataAnnotations;

class Program
{
 
    public static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("abccba"));
        Console.WriteLine(IsPalindrome("abcdefg"));
    }

    public static bool IsPalindrome(string s)
    {
        String to_Check = update_Str(s);
        bool res = false;
        int start = 0;
        // Len of string
        int end = to_Check.Length - 1;
        while (true)
        {
            if(end <= start)
            {
                res = true;
                break;
            }
            else
            {
                if (to_Check[start] != to_Check[end])
                {
                    break;
                }
                else
                {
                    start++;
                    end--;
                }
            }
        }
        return res;
    }
    
    public static String update_Str(String s)
    {
        char[] charactersList = { ' ', '"', ',', '{', '}' };
        String res = "";
        foreach (char c in s)
        {
            if (!charactersList.Contains(c))
            {
                res += c;
            }
        }

        return res;
    }
}