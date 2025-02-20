from typing import List

class Solution:
    def fullJustify(self, words: List[str], maxWidth: int) -> List[str]:
        strs_res = []
        str_i = 0
        word_to_str = []
        for str_w in words:

            if(len(strs_res) == 0):
                strs_res.append([])
                word_to_str.append(str_w)
                if((sum(len(s) for s in word_to_str)) >= maxWidth):
                    strs_res[str_i] = addStrs()
                    str_i += 1

                

        return strs_res

    def addStrs(str_to_update: List[str]) -> str:
        str_res = ""


        return str_res 