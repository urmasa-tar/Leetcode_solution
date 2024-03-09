import java.util.Scanner;

public class anogramm {
    
    public static void main(String[] args){

        Scanner in = new Scanner(System.in);

        System.out.println(isAnagram("abc", "cbe"));

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
        if(s.length() != t.length()){
            status = false;
        }else{

            for(int i = 0; i < s.length(); i++){
                arr[Character.getNumericValue(s.charAt(i)) - 10] += 1;
                anog[Character.getNumericValue(t.charAt(i)) - 10]+= 1;
            }

            for(int i = 0; i < 26; i++){
                if(arr[i] != anog[i]){
                    status = false;
                    break;
                }
            }
        }
        return status;
    }

}
