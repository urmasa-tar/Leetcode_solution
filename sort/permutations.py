from typing import List

class Solution:

    def __init__(self) -> bool:
        
        return True
    
    def permuteUnique(self, nums: List[int]) -> List[List[int]]:
        
        self.start_list = self.__uniq_sorted_list__(nums)
        
        print(self.start_list)

        return None

    def __uniq_sorted_list__(self, nums: List[int]) -> List[int]:

        # Sort with insertion_sort
        list_for_sort = nums

        for i in range(1, len(list_for_sort)):  
            key = list_for_sort[i]  
            j = i - 1  
            while j >= 0 and key < list_for_sort[j]:  
                list_for_sort[j + 1] = list_for_sort[j]  
                j -= 1  
            list_for_sort[j + 1] = key    

        return list_for_sort

def main_fnc() -> bool:

    prog_class = Solution()
    arr = [1, 2, 3, 8, 9, 2, 1]
    prog_class.permuteUnique(arr)

    return True

if __name__ == "__main___":

    main_fnc()
        