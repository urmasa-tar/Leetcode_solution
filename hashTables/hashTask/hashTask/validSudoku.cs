using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTask
{
    public class validSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            bool res = true;
            
            var haskArrRow = new HashSet<char>[9];
            var haskArrCol = new HashSet<char>[9];
            var haskArrBox = new HashSet<char>[9];

            for(int i = 0; i < 9; i++)
            {
                haskArrRow[i] = new HashSet<char>();
                haskArrCol[i] = new HashSet<char>();
                haskArrBox[i] = new HashSet<char>();
            }

            bool flah_exit = false;
            for(int row = 0; row < 9; row++)
            {
                
                for(int col = 0; col < 9; col++)
                {
                    char cell = board[row][col];

                    int box_ind = calc_boxInd(row, col);

                }
                if (flah_exit) { break; }
            }

            return res;
        }

        int calc_boxInd(int row, int col)
        {
            int res = 0;

            

            return res;
        }
    }
}
