public class zero_move {
    
    public static void main(String[] args){

    }

    public static void moveZeroes(int[] nums) {
        
        int j = 0;

        for(int i = 0; i < nums.length; i++){
            if(nums[i] != 0){
                nums[j] = nums[i];
                j++;
            }
        }

        if(j < nums.length){
            for(int i = j; i < nums.length; i++){
                nums[i] = 0;
            }
        }

    }

}
