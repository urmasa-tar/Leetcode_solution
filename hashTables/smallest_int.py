from typing import List

class Solution:

    def firstMissingPositive(self, nums: List[int]) -> int:
        
        res = 1
        lstt_calc = self.list_of_int(max(nums))
        for num in nums:
            if(num > 0):
                lstt_calc[num - 1] = False
            else:
                continue
        
        for ind_num in range(len(lstt_calc)):
            if(lstt_calc[ind_num]):
                res = ind_num + 1
                break
            else:
                continue

        return res

    def list_of_int(self, mx_int: int) -> List[bool]:
        arr_res = []
        #               Max int with bit operation
        for i in range(max(mx_int, 1)):
            arr_res.append(True)
        return arr_res

if __name__ == "__main__":

    prog = Solution()
    print(prog.firstMissingPositive([0,2,1]))