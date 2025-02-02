namespace mergeArr{

    public class Solution {

        public void Merge(int[] nums1, int m, int[] nums2, int n) {
            int i = 0;
            int j = 0;
            while(true){
                if((i >= m) && (j >= n)){ break; }
                else
                {
                    if( i >= m){
                        nums1 = moveToRight(nums1, i + j, nums2[j], i + j + 1);
                        j += 1;
                        i += 1;
                    }else if(j >= n){
                        break;
                    }else{
                        if(nums1[i] < nums2[j]){
                            i += 1;
                        }else{
                            nums1 = moveToRight(nums1, i + j, nums2[j], i + j + 1);
                            j += 1;
                            i += 1;
                        }
                    }
                }
            }   
        }

        public int[] moveToRight(int[] nums1, int from, int newN, int newLength){

            int skipedNum = -1;
            for(int i = 0; i < newLength; i++){
                if(i < from){
                    continue;
                }else{
                    if(skipedNum == -1){
                        skipedNum = nums1[i];
                        nums1[i] = newN;
                    }else{
                        int p = nums1[i];
                        nums1[i] = skipedNum;
                        skipedNum = p;
                    }
                }
            }

            return nums1;
        }


    }
}