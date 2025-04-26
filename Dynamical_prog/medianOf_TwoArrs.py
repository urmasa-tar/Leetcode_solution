from typing import List


class Solution:
    def __init__(self):
        pass

    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:

        res = 0.1
        counted_num = 0
        if len(nums1) + len(nums2) % 2 != 0:
            counted_num = (len(nums1) + len(nums2)) // 2 + 1
        else:
            counted_num = (len(nums1) + len(nums2)) // 2

        i_nums1 = 0
        j_nums2 = 0

        while True:

            if (i_nums1 < len(nums1)) and (j_nums2 < len(nums2)):

                if nums1[i_nums1] <= nums2[j_nums2]:
                    i_nums1 += 1
                    if((i_nums1 + j_nums2) == counted_num):
                        if(counted_num % 2 == 1):
                            res = min(nums1[i_nums1], nums2[j_nums2]) # !! Danger moment
                        else:
                            res = float(nums1[i_nums1 - 1]) + 0.5
                        break # Out from cicle
                else:
                    j_nums2 += 1
                    if((i_nums1 + j_nums2) == counted_num):
                        if(counted_num % 2 == 1):
                            res = min(nums1[i_nums1], nums2[j_nums2]) # !!! May be out of range
                        else:
                            res = float(nums1[i_nums1 - 1]) + 0.5
                        break # Out from cycle
            elif(i_nums1 >= len(nums1)):
                pass
            else:
                pass

        return res
