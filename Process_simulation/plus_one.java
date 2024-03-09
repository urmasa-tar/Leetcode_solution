import java.util.Scanner;


public class plus_one {

    public static void main(String[] args){

    }

    public int[] plusOne(int[] digits) {
        
        for(int i = digits.length - 1; i >= 0; i--){
            digits[i] += 1;
            if(digits[i] == 10){

                digits[i] = 0;

                if(i == 0){
                    int[] digitr = new int[digits.length + 1];
                    digitr[0] = 1;
                    for(int j = 0; j < digits.length; j++){
                        digitr[j + 1] = digits[j];
                    }
                    digits = digitr;
                }


            }else{
                break;
            }
        }



        return digits;
    }
    
}