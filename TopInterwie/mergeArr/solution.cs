namespace mergeArr
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] newArr = new int[n + m];
            int i = 0, j = 0;
            while (true)
            {
                if ((i >= m) && (j >= n))
                {
                    break;
                }
                if (i >= m)
                {
                    newArr[i + j] = nums2[j];
                    j += 1;
                }
                else if (j >= n)
                {
                    newArr[i + j] = nums1[i];
                    i += 1;
                }
                else
                {
                    if (nums1[i] <= nums2[j])
                    {
                        newArr[i + j] = nums1[i];
                        i += 1;
                    }
                    else
                    {
                        newArr[i + j] = nums2[j];
                        j += 1;
                    }
                }
            }

            for (int k = 0; k < newArr.Length; k++)
            {
                nums1[k] = newArr[k];
            }
        }
    }
}
