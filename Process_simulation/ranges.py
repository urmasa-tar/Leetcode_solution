from typing import List

class Solution:
    def summaryRanges(self, nums: List[int]) -> List[str]:
        res = []
        current_r = []
        for num in nums:
            if(len(current_r) == 0):
                current_r.append(num)
            else:
                if(num > current_r[-1] + 1):
                    res.append(self.__range_To_Str__(current_r))
                    current_r = []
                    current_r.append(num)
                else:
                    current_r.append(num)
        if(len(current_r) > 0):
            res.append(self.__range_To_Str__(current_r))
        return res
    
    def __range_To_Str__(self, range: List[int]) -> str:
        s = ""
        if(len(range) == 1):
            s = str(range[0])
        elif(len(range) > 1):
            s = str(range[0]) + "->" + str(range[-1]) 
        return s


if __name__ == "__main__":
    '''
    test = ""
    test += 3
    test += "->"
    test += 4'
    '''
    test = [0, 1, 2, 4, 5, 7]
    calc = Solution()
    print(calc.summaryRanges(test))