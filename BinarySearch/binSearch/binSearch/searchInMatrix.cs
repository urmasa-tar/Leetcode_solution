using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binSearch
{
    public class searchInMatrix
    {
        public struct pairIndElem
        {
            public int row; public int col;
            public int elem;
        }
        public bool SearchMatrix(int[][] matrix, int target)
        {
            bool result = false;
            pairIndElem[] elemWithindex = new pairIndElem[matrix.Length * matrix[0].Length];
            int pointer_k = 0;
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    elemWithindex[pointer_k].elem = matrix[i][j];
                    elemWithindex[pointer_k].row = i;
                    elemWithindex[pointer_k].col = j;
                    pointer_k++;
                }
            }

            int a = 0;
            int b = elemWithindex.Length - 1;
            int k = (a + b)/2;
            while (a <= b)
            {
                if (elemWithindex[k].elem == target) { result = true; break; }
                else
                {
                    if (elemWithindex[k].elem < target) { a = k + 1; }
                    else { b = k - 1; }
                }
                k = (a + b)/2;
            }

            return result;
        }
    }
}
