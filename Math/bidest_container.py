from typing import List

class Solution:

    def maxArea(self, height: List[int]) -> int:
        
        res = 0
        i = 0
        j = len(height) - 1
        while(True):
            if(i >= j):
                break
            current = self.calc_Pull(i, j, min(height[i], height[j]))
            if(current > res):
                res = current
            if(height[i] => height[j]):
                j -= 1
            else:
                i += 1

        return res
    
    def calc_Pull(self, start: int, end: int, min_board: int) -> int:

        res = (end - start) * min_board

        return res

    

if __name__ == "__main__":

    prog_test = Solution()