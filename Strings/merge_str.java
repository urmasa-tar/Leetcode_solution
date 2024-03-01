import java.util.Scanner;


public class merge_str {
    
    public static void main(String[] args){

        mergeAlternately("abc", "def");
        
    }
    
    public static void meow(int n){
        for(int i = 0; i < n; i++){
            System.out.print("meow\n");
        }
    }

    public static String mergeAlternately(String word1, String word2) {
        int n = word1.length();
        int m = word2.length();
        int i = 0;
        int j = 0;
        String res = "";

        // in cycle add chares by i and j
        while (true) { // How to decompose that function?
            if(i < n && j < m){
                if(i <= j){
                    res = res.concat(Character.toString(word1.charAt(i)));
                    i += 1;
                }else{
                    res = res.concat(Character.toString(word2.charAt(j)));
                    j += 1;
                }
            }else if(i < n){
                res = res.concat(Character.toString(word1.charAt(i)));
                i += 1;
            }else if(j < m){
                res = res.concat(Character.toString(word2.charAt(j)));
                j += 1;
            }else{
                break;
            }
        }


        System.out.print(res);
        return res;
    }
}