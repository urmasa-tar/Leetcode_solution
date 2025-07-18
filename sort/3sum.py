from typing import List

class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        
        self.res = []
        self.sort_lst = sorted(nums)  # Используем sorted() вместо nums.sort()

        # For every possible j (middle pointer)
        for j_point in range(1, len(self.sort_lst) - 2):  # Исправлены границы
            # check for sum
            self.with_point_j(0, j_point, len(self.sort_lst) - 1)  # Исправлен последний аргумент
    
    def with_point_j(self, i: int, j: int, k: int) -> bool:
        
        res = True
        i = 0
        k = len(self.sort_lst) - 1
        
        if( (i < j) and (j < k)):
            
            if( (self.sort_lst[i] + self.sort_lst[j] + self.sort_lst[k]) == 0):
                
                self.res.append([self.sort_lst[i], self.sort_lst[j], self.sort_lst[k]])
                self.with_point_j(i + 1, j, k)
                self.with_point_j(i, j, k - 1)
                
            elif( (self.sort_lst[i] + self.sort_lst[j] + self.sort_lst[k]) > 0):
                self.with_point_j(i, j, k - 1)
            
            else:
                self.with_point_j(i + 1, j, k)
        else:
            res = False
            
        return res                  
                
    def check_same_neibor(self, i: int, j: int, k: int) -> None:
        
        return None
        
    
def main_func() -> None:
    
    sol_class = Solution()
    print(sol_class.threeSum([-1,0,1,2,-1,-4]))
    
    return None

if __name__ == "__main__":
    
    main_func()