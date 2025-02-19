from typing import List


class Solution:
    def __init__(self):
        pass

    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:

        counted_num = 0
        if len(nums1) + len(nums2) % 2 != 0:
            counted_num = (len(nums1) + len(nums2)) // 2 + 1
        else:
            counted_num = (len(nums1) + len(nums2)) // 2

        i_nums1 = 0
        j_nums2 = 0

        while True:

            if (i_nums1 < len(nums1)) and (j_nums2 < len(nums2)):

                if nums1[i_nums1] < nums2[j_nums2]:

                    i_nums1 += 1

        return None
