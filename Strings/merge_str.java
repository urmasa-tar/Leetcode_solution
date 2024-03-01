import java.util.Scanner;
import java.util.Strings;


public class merge_str {
    
    public static void main(String[] args){
        // ---> meow(14);

        // Scanner example
        Scanner in = new Scanner(System.in);

        int mw_num = in.nextInt();

        meow(mw_num);

        in.close();
        // <---
        
    }
    
    public static void meow(int n){
        for(int i = 0; i < n; i++){
            System.out.println("meow\n");
        }
    }
}