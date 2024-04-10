public class two_arrays_median {

    public static void main(String[] args){


    }

    public double findMedianSortedArrays(int[] nums1, int[] nums2) {

        double res = 0;

        int n = nums1.length;
        int m = nums2.length;

        int i = 0;
        int j = 0;
        int[] arr = new int[n + m];

        while (true){
            if((i >= n) && ( j >= m)){
                break;
            }else if(i >= n){

            }else if(j >= m){

            }else{
                if(nums1[i] > nums2[j]){
                    arr[i + j] = nums2[j];
                    j += 1;
                }else{
                    arr[i + j] = nums1[i];
                    i += 1;
                }
            }
        }

        return res;

    }

}
