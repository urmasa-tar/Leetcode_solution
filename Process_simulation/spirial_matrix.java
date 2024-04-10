import java.util.ArrayList;
import java.util.List;

class spirial_matrix{

    public static void main(String[] args){

    }

    public List<Integer> SpiralOrder(int[][] matrix) {

        List<Integer> list_of_spiral = new ArrayList<>();
        int m = matrix[0].length; // - in row
        int n = matrix.length; // - number of rows
        int i, j = 0;
        char struct = 'r';// r -> d -> l -> u
        byte in_row = 0; // break status

        list_of_spiral.add(matrix[0][0]);

        while (true){

            switch (struct){
                    case ('r'):
                        if(){

                        }else{
                            struct = 'd';
                            in_row += 1;
                        }
                        break;

                    case ('d'):
                        if(){

                        }else {
                            struct = 'l';
                            in_row += 1;
                        }
                        break;

                    case ('l'):
                        if(){

                        }else {
                            struct = 'u';
                            in_row += 1;
                        }
                        break;

                    case ('u'):
                        if () {

                        }
                        
                        struct = 'r';
                        in_row += 1;

                        break;

                default:

                    //error moument
                    break;
            }


            if(in_row == 4)break;
        }

        return list_of_spiral;
    }

}