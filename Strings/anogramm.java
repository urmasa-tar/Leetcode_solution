import java.util.Scanner;

public class anogramm {
    
    public static void main(String[] args){

        Scanner in = new Scanner(System.in);

        in.close();

    }

    public static boolean isAnagram(String s, String t) {
        boolean status = true;
        int[] arr = new int[26];
        int[] anog = new int[26];

        for(int i = 0; i < 26; i++){
            arr[i] = 0;
            anog[i] = 0;
        }
        // for unicode a(int code) = 97(?)

        return status;
    }

}
