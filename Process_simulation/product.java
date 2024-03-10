import java.util.Arrays;

public class product {
    
    public static void main(String[] args){

    }

    public static int arraySign(int[] nums) {

        int nm = 0;

        for(int i = 0; i < nums.length; i++){
            if(nums[i] < 0){
                nm += 1;
            }
            if(nums[i] == 0){
                nm = -1;
                break;
            }
        }

        int res;

        if(nm == -1){
            res = 0;
        }else if(nm % 2 == 0){
            res = 1;
        }else{
            res = -1;
        }

        return res;
    }

    public boolean canMakeArithmeticProgression(int[] arr) {
        Arrays.sort(arr);
        arr[0] = arr[1] - arr[0];
        if(arr.length > 2){
            for(int i = 2; i < arr.length; i++){
                if((arr[0]) !=  (arr[i] - arr[i-1])){
                    return false;
                }
            }
        }

        return true;
    }

    public boolean isMonotonic(int[] nums) {
        boolean status = true;
        
        // Module in java
            for(int i = 2; i < nums.length; i++){
                try{
                    if((nums[i - 1] - nums[i - 2]) / Math.abs((nums[i - 1] - nums[i - 2])) != nums[i] - nums[i - 1] / Math.abs((nums[i] - nums[i - 1]))){
                        status = false;
                        break;
                    }
                } catch (ArithmeticException e){
                    continue;
                }
            }   
        
        return status;
    }

}
