

public class rober{

    public int Rob(int[] nums) {
        // need to create arr for mx sum
        int[] arrS = new int[nums.Length];
        for(int house = 0; house < nums.Length; house++){
            arrS[house] = nums[house];
            arrS[house] = maxInMoument(house, nums[house], arrS);
        }
        return maxC(arrS);
    }

    protected int maxInMoument(int house, int num, int[] nums){
        int res = nums[house];
        for(int i = 0; i < house - 1; i++){
            res = maxC(res, nums[house] + nums[i]);
        }
        return res;
    }

    public int maxC(int n, int m){
        int res = n;
        if(m > n)res = m;
        return res;
    }

    public int maxC(int[] nums){
        int res = nums[0];
        for(int i = 1; i < nums.Length; i++)res = maxC(res, nums[i]);
        return res;
    }

}