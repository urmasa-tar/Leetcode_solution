from typing import List

class Solution:

    def canJump(self, nums: List[int]) -> bool:
        res = False

        index = 0
        while(True):
            if(index == -1):
                break
            elif(index == (len(nums) - 1)):
                res = True
                break
            index = self.max_Jump__in_subarr(index, nums[index], nums)
            
        return res
    
    def max_Jump__in_subarr(self, i: int, step: int, nums: List[int]) -> int:
        res = -1
        for ind in range(i + 1, i + step + 1):
            if(ind == len(nums) - 1):
                res = ind
                break
            elif(nums[ind] > 0):
                if((res != -1) and (nums[ind] + ind > res + nums[res])):
                    res = ind
                elif(res == -1):
                    res = ind
            else:
                continue

        return res

if __name__ == "__main__":
    calc = Solution()
    nums = [int(i) for i in input().split()]
    print(calc.canJump(nums))
