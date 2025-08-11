namespace hashTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            wordsConcat checkCode = new wordsConcat();
            string s = "abcedabcderd";
            string[] search = { "abc"};
            string[] search2 = { "b", "c" };

            IList<int> res_test = checkCode.FindSubstring(s, search);
            foreach (int i in res_test) { Console.WriteLine(i); }
            */

            validSudoku isVal = new validSudoku();

            // check box fub=nction test
            /*
            Console.WriteLine($"Ожидаемый сектор 1 для строки 1 и колонки 4 . Результата: {isVal.calc_boxInd(1, 4)}");
            Console.WriteLine($"Ожидаемый сектор 2 для строки 2 и колонки 8 . Результата: {isVal.calc_boxInd(2, 8)}");
            Console.WriteLine($"Ожидаемый сектор 0 для строки 0 и колонки 0 . Результата: {isVal.calc_boxInd(0, 0)}");
            Console.WriteLine($"Ожидаемый сектор 7 для строки 8 и колонки 3 . Результата: {isVal.calc_boxInd(8, 3)}");
            Console.WriteLine($"Ожидаемый сектор 4 для строки 4 и колонки 4 . Результата: {isVal.calc_boxInd(4, 4)}");

            char[][] board = new char[][] {
                new char[] {'5','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };

            Console.WriteLine(isVal.IsValidSudoku(board));
            */


        }
    }
}