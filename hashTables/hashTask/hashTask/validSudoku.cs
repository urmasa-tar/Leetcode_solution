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

                    if (cell == '.') { continue; }
                    else if (haskArrRow[row].Contains(cell) || haskArrCol[col].Contains(cell) || haskArrBox[box_ind].Contains(cell))
                    {
                        flah_exit = true;
                        res = false;
                        break;
                    }
                    else
                    {
                        haskArrBox[box_ind].Add(cell);
                        haskArrRow[row].Add(cell);
                        haskArrCol[col].Add(cell);
                    }

                }
                if (flah_exit) { break; }
            }

            return res;
        }

        public int calc_boxInd(int row, int col)
        {
            int res = 0;

            res = ((int)(row / 3) * 3) + (col / 3);

            return res;
        }
    }
}
