from typing import List

class Solution:

    def maxArea(self, height: List[int]) -> int:
        res = 0
        i = 0
        j = len(height) - 1
        while(True):
            # res = max(res, (max(height[i], height[j]) * (j - i - 1))) # Error with [1, 1] -> Not valid with i and j diff 1
            res = max(self.calc_Container(i, j, height[i], height[j]), res)
            if(height[i] >= height[j]):
                j -= 1
            else:
                i += 1   
            if ((i == j) or (i > j)):
                break
        return res
    
    def calc_Container(self, index_i, index_j, h_for_i, h_for_j) -> int:
        res = 0
        if (index_j - index_i == 1):
            res = min(h_for_i, h_for_j) 
        else:
            res = min(h_for_i, h_for_j) * (index_j - index_i)

        return res

if __name__ == "__main__":
    calc = Solution()
    print(calc.maxArea([4,3,2,1,4]))