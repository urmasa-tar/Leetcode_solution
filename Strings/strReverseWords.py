class Solution:
    def reverseWords(self, s: str) -> str:
        res = ""

        res_arr = s.split()
        i = len(res_arr) - 1
        while(True):
            res += res_arr[i]
            i -= 1
            if(i >= 0):
                res += " "
            else:
                break
            
        return res
