import java.util.Scanner;

class find_diff {

    public static void main(String[] args){
        // 
        Scanner in = new Scanner(System.in);

        // tests for s and t
        System.out.println(findTheDifference("", "y"));

        in.close();
    }

    public static char findTheDifference(String s, String t) {
        int i = 0;;
        int n = s.length();
        char c = t.charAt(n);

        while (i < n) {
            if(s.charAt(i) != t.charAt(i)){
                c = t.charAt(i);
                break;
            }
        }

        return c;
    }
    
}