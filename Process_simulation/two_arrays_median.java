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
                arr[i + j] = nums2[j];
                j += 1;
            }else if(j >= m){
                arr[i + j] = nums1[i];
                i += 1;
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

        if((n + m) % 2 == 0){
            res = (double) (arr[(n + m) / 2] + arr[(n + m) / 2 + 1]) / 2;
        }else{
            res = (double) arr[(n + m) / 2 + 1];
        }
        return res;

    }

}
