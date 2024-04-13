import java.util.Arrays;

public class My_Rectanle {

    public int maximalRectangle(char[][] matrix) {
        int res;

        if (matrix == null || matrix.length == 0 || matrix[0].length == 0) {
            res = 0;
        }else{
            res = 0;

            int n = matrix.length;
            int m = matrix[0].length;

            byte[][] stat_arr = new byte[n][m];

            for(int i = 0; i < n; i++){
                for(int j = 0; j < m; j++){

                    stat_arr[i][j] = 0;

                }
            }



        }



        return res;
    }

    public byte[][] status_in_row(char[][] input_mat, byte[][] stat, int st_row, int st_col){
        byte[][] stat_cop = Arrays.copyOf(stat, stat.length);



        return stat_cop;
    }

    public byte[][] status_in_column(char[][] input_mat, byte[][] stat){
        byte[][] stat_cop = Arrays.copyOf(stat, stat.length);

        return stat_cop;
    }

}
