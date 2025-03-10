from typing import List

class Solution:

    def __init__(self):
        pass

    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        res = []
        i = 0
        j = len(numbers) - 1
        while(True):
            if(numbers[i] + numbers[j] == target):
                res.append(i + 1)
                res.append(j + 1)
                break
            elif((numbers[i] + numbers[j]) > target):
                j -= 1
                if(i >= j):
                    break
            else:
                i += 1
                if(i >= j):
                    break
        return res
    
if __name__ == "__main__":
    calc = Solution()
