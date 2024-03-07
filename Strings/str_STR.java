import java.util.Scanner;


public class str_STR {

    public static void main(String[] args){

        Scanner in = new Scanner(System.in);

        String str1 = in.nextLine();
        String str2 = in.nextLine();

        System.out.println(strStr(str1, str2));


        in.close();
    }

    public static int strStr(String haystack, String needle){
        int res = -1;
        if(haystack.length() >= needle.length()){
            for(int i = 0; i < (haystack.length() - needle.length() + 1);  i++){ // Carefull with length of Strings
                if(haystack.charAt(i) == needle.charAt(0)){
                    for(int j = 0; j < needle.length(); j++){
                        if(haystack.charAt(i+j) != needle.charAt(j)){
                            break;
                        }else if(j == needle.length() - 1){
                            res = i;
                        }
                    }
                }else{
                    continue;
                }

                if(res != -1)break;
            }
        }

        return res;
    }
}
