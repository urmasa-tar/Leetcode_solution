from typing import List

class Solution:

    def generateParenthesis(self, n: int) -> List[str]:
        self.num = n
        return self.__open_close_rec__(0, 0, "")
    
    def __open_close_rec__(self, open:int, close:int, cur_str:str) -> List[str]:

        res = []

        if(close < open):
            if(close < self.num):
                res = self.__open_close_rec__(open, close + 1, cur_str.append(')'))
            if(open < self.num):
                res += self.__open_close_rec__(open + 1, close, cur_str.append('('))
        else:
            if(open < self.num):
                res += self.__open_close_rec__(open + 1, close, cur_str.append('('))
            else:
                res.append(cur_str)

        return res

