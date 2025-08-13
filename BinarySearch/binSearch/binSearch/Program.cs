namespace binSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            powForLong powForLong = new powForLong();

            // Console.WriteLine($"For 178 nearest int for sqrt is {powForLong.MySqrt(178)}");
            searchInMatrix searchTarget = new searchInMatrix();

            /*
            int[][] matrix = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };
            */
            int[][] matrix = new int[3][]; // 3 строки
            matrix[0] = new int[] { 1, 2, 3, 5 };    // 1-я строка (3 столбца)
            matrix[1] = new int[] { 5, 5, 6, 7 }; // 2-я строка (4 столбца, может быть другой длины)
            matrix[2] = new int[] { 8, 9, 14, 15 };       // 3-я строка (2 столбца)

            Console.WriteLine($" для матрицы поиск числа 6/true - ответ {searchTarget.SearchMatrix(matrix, 6)}");
            Console.WriteLine($" для матрицы поиск числа 4/false - ответ {searchTarget.SearchMatrix(matrix, 4)}");
        }
    }
}
