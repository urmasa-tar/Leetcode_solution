from typing import List

class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        res = ""
        flag_out = False
        for i in range(self.__find_mn_Len__(strs)):
            res = strs[0][0:i+1]
            for j in range(len(strs)):
                if(res != strs[j][0:i+1]):
                    res = res[:-1]
                    flag_out = True
                    break
                else:
                    continue
            if(flag_out):break
        return res
    
    def __find_mn_Len__(self, strs: List[str]) -> int:
        res = 201
        for st in strs:
            if(len(st) < res):
                res = len(st)
        return res