import java.util.Scanner;

/**
 * stairse
 */
public class stairse {

    public static void main(String[] args){

    }

    public int climbStairs(int n) {
        int[] mas = new int[n];
        
        // Recurent base
        mas[0] = 1;
        if(n >= 2)mas[1] = 2;

        for(int i = 2; i < n; i++){
            mas[i] += mas[i - 1] + mas[i - 2];
        }

        return mas[n-1];
    }
    
    /* - with recurtion
    public int fib(int n) {
        // F(n) = F(n - 1) + F(n - 2), for n > 1.

        int res = 0;
        if(n > 1){
            res = fib(n - 1) + fib(n - 2);
        }else if(n == 1){
            res = 1;
        }

        return res;
    }
    */

    public int fib(int n) { // the same as stairse
        int[] mas = new int[n+1];
        
        // Recurent base
        mas[0] = 0;
        if(n >= 1)mas[1] = 1;

        for(int i = 2; i < n+1; i++){
            mas[i] += mas[i - 1] + mas[i - 2];
        }

        return mas[n];
    }

    public int uniquePaths(int m, int n) {
        int[][] mas = new int[m][n];
        
        for(int i = 0; i < m; i++){

            for(int j = 0; j < n; j++){
                
                mas[j][i] = 0;

            }

        }

        

        return mas[m - 1][n - 1];
    }

}