import java.util.Scanner;

class find_diff {

    public static void main(String[] args){
        // 
        Scanner in = new Scanner(System.in);

        // tests for s and t
        System.out.println(findTheDifference("ryq", "rtqy"));

        in.close();
    }

    public static char findTheDifference_for_no_rand(String s, String t) {
        int i = 0;
        int n = s.length();
        char c = t.charAt(n);

        while (i < n) {
            if(s.charAt(i) != t.charAt(i)){
                c = t.charAt(i);
                break;
            }
            i += 1;
        }

        return c;
    }

    // here t - is random generated string from s
    public static char findTheDifference(String s, String t) {
        int n = s.length();
        int[] mas_of_s = new int[26];
        int[] mas_of_t = new int[26];
        char res = t.charAt(n);

        for(int i = 0; i < 26; i++){
            mas_of_s[i] = 0;
            mas_of_t[i] = 0;
        }

        for(int i = 0; i < n; i++){
            mas_of_s[Character.getNumericValue(s.charAt(i)) - 10] += 1;
            mas_of_t[Character.getNumericValue(t.charAt(i)) - 10] += 1;
        }
        
        for(int i = 0; i < 26; i++){
            if(mas_of_t[i] > mas_of_s[i]){
                res = (char)(i + 97);
                break;
            }
        }

        return res;
    }
    

    // First str1 in str2
    public static int strStr(String haystack, String needle) {
        int res = -1;
        if(haystack.length() >= needle.length()){
            for(int i = 0; i < haystack.length(); i ++){
                if(haystack.charAt(i) == needle.charAt(0)){
                    for(int j = 1; j < needle.length(); j++){
                        if(haystack.charAt(i + j) != needle.charAt(j)){
                            break;
                        }else if(j + 1 == needle.length()){
                            // checkd first char in str
                            res = i;
                        }
                    }

                    if(res != -1)break;
                    if(needle.length() == 1){
                        res = i;
                        break;
                    }
                }else{
                    if(i + needle.length() >= haystack.length()) break;
                }
            }
        }

        return res;
    }

}