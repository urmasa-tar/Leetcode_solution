from typing import List


class Solution:
    
    def countAndSay(self, n: int) -> str:
        res = ""
        arr = []
        
        arr = self.int_to_arr(n)
        
        if(len(arr) % 2 == 0):
            for i in range(0, len(arr), 2):
                res += arr[i]
        else:
            res = "Error"

        return res
    
    def int_to_arr(self, num: int) -> List[int]:

        res_arr = []

        while(num > 0):
            res_arr.append(num % 10)
            num = num / 10
        
        return res_arr.reverse()

    def pair_to_str(self) -> str:
        res = ""

        return res

    def sub_str_decode(self) -> tuple[int, str]:
        res_substr = ""
        new_ind = 0
        return res_substr, new_ind

if __name__ == "__main__":

    prog = Solution()