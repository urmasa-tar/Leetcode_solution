import java.util.Scanner;

public class multiple_str {

    public static void main(String[] args){

        Scanner in = new Scanner(System.in);

        System.out.println(repeatedSubstringPattern("ababac"));

        in.close();
    }

    public static boolean repeatedSubstringPattern(String s) {
        boolean res = false;

        for(int i = 1; i < s.length()/2 + 1; i++){
            if(s.length() % i == 0){

                int parts = s.length()/i; // - > How many parts of that str in 

                boolean local_res = true;

                for(int j = 0; j < i; j++){
                    
                    for(int t = 1; t < parts; t++){
                        if(s.charAt(j) != s.charAt(j + i * t)){
                            local_res = false;
                            break;
                        }
                    }


                    if ( local_res != true)break;
                }

                if(local_res != true)continue;
                res = true;
                break;
            }
        }

        return res;
    }
    
}
