from typing import List

class Solution:

    def removeDuplicates(self, nums: List[int]) -> int:
        
        res = 0
        straigt = [-1, 0]
        to_write = 0
        
        for i in range(len(nums)):

            if straigt[0] == -1:

                res += 1
                straigt[0] = nums[i]
                straigt[1] = 1

            else:

                if( straigt[0] == nums[i]):
                    straigt[1] += 1
                    if(straigt <= 2):
                        res += 1
                        nums[to_write] = nums[i]
                    else:
                        continue
                else:
                    res += 1
                    straigt[0] = nums[i]
                    straigt[0] = 1
                    nums[to_write] = nums[i]

        return res
    

def main() -> None:

    arr = [int(i) for i in input().split()]
    res = Solution.removeDuplicates(arr)
    print(f"k is {res}, for final arr:{arr}")
    return None

if __name__ == "__main__":
    main()