from typing import List

class Solution:
    def trap(self, height: List[int]) -> int:
        res = 0

        i = 0
        while(True):
            if(i >= len(height)):
                break
            elif( height[i] > 0):

                flag_move = True
                sum_trap = 0

                for j in range(i + 1, len(height)):
                    if(height[i] <= height[j]):
                        res += sum_trap
                        i = j
                        flag_move = False
                        break
                    else:
                        sum_trap += height[i] - height[j]

                if(flag_move):
                    i += 1
            else:
                i += 1

        return res
    
def main():

    test1_data = [0,1,0,2,1,0,1,3,2,1,2,1]

    test1 = Solution.trap(test1_data)
    print(test1)

if __name__ == "main":
    main()