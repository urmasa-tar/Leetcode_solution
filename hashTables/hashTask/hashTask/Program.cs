namespace hashTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            wordsConcat checkCode = new wordsConcat();
            string s = "abcedabcderd";
            string[] search = { "abc"};
            string[] search2 = { "b", "c" };

            IList<int> res_test = checkCode.FindSubstring(s, search);
            foreach (int i in res_test) { Console.WriteLine(i); }
        }
    }
}