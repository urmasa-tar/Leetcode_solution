package Process_simulation;

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

}
