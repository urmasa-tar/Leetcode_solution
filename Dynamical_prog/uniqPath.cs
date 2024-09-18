public class uniqPath{
    public static void main(){

        public int UniquePaths(int m, int n) {
            int[][] grid = new int[m][];
            for(int i = 0; i < m; i++){
                grid[i] = new int[n];
            }
            for(int row = 0; row < m; row++){
                for(int cloumn = 0; cloumn < n; cloumn++){
                    grid[row][cloumn] = calculPos(row, column, grid);
                }
            }

            return grid[m - 1][n - 1];
        }

        public int calculPos(int row, int col, int[][] grid){
            int res = 1;
            if(row != 0 && col != 0){
                res += grid[row - 1][col] + grid[row][col - 1];
            }else if(row == 0 && col != 0){
                res += grid[0][col - 1];
            }else if(row != 0 && col == 0){
                res += grid[row - 1][0];
            }
            return res;
        }
    }
}