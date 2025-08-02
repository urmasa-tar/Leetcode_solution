namespace string_tasks
{

    class Program
    {
        public static void Main(string[] args)
        {
            regular_expressions regular_Expressions = new regular_expressions();
            string test1_s = "aa";
            string test1_p = "a*";

            Console.WriteLine(regular_Expressions.IsMatch(test1_s, test1_p));
        }
    }
}